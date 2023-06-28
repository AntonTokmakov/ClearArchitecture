using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectApplication.Interface;
using ProjectDomain;
using ProjectWebApi.Controllers;
using TrialProject.Models;
using TrialProject.UseCase;

namespace Tasks.Models
{
    public class ProjectController : Controller
    {
        IService<Project> _projectService;

        public ProjectController(IService<Project> projectService)
        {
            this._projectService = projectService;
        }

        [HttpGet]
        public IActionResult AddProject()
        {
            Project project = new Project();
            if (TempData["create_id_ts"] != null) { project.id_ts = (int)TempData["create_id_ts"]; }
            return View(project);
        }

        [HttpPost]
        public IActionResult AddProject(Project project)
        {
            if (ModelState.IsValid)
            {
                _projectService.Create(project);
                return RedirectToAction("GetProjects");
            }
            return View(project);
        }

        public IActionResult GetProjects()
        {
            return View(_projectService.GetItems());
        }

        public IActionResult Edit(int id)
        {
            var project = _projectService.GetById(id);

            if (project == null)
            {
                return NotFound();
            }

            return View("Edit", project);
        }

        [HttpPost]
        public IActionResult Edit(Project project)
        {
            if (ModelState.IsValid)
            {
                _projectService.Update(project);

                return RedirectToAction("GetProjects", "Project");
            }

            return View(project);
        }

        public IActionResult Delete(int id)
        {
            _projectService.Delete(id);
            return RedirectToAction("GetProjects", "Project");
        }
    }
}
