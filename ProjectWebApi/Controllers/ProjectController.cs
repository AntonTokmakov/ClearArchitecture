using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrialProject.Models;
using TrialProject.UseCase;

namespace Tasks.Models
{
    public class ProjectController : Controller
    {
        IProjectService _projectService;

        public ProjectController(IProjectService projectService)
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
                _projectService.AddProject(project);
                return RedirectToAction("GetProjects");
            }
            return View(project);
        }

        public IActionResult GetProjects()
        {
            return View(_projectService.GetProjects());
        }

        public IActionResult Edit(int id)
        {
            var project = _projectService.GetProjectById(id);

            if (project == null)
            {
                return NotFound();
            }

            return View("AddProject", project);
        }

        [HttpPost]
        public IActionResult Edit(Project project)
        {
            if (ModelState.IsValid)
            {
                _projectService.UpdateProject(project);

                return RedirectToAction("GetProjects", "Project");
            }

            return View(project);
        }

        public IActionResult Delete(int id)
        {
            _projectService.DeleteProject(id);
            return RedirectToAction("GetProjects", "Project");
        }
    }
}
