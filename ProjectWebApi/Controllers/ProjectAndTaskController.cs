using Microsoft.AspNetCore.Mvc;
using ProjectApplication.Interface;
using ProjectDomain;
using Tasks.Models;

namespace ProjectWebApi.Controllers
{
    public class ProjectAndTaskController : Controller
    {
        IProjectAndTaskRepository _repository;
        public ProjectAndTaskController(IProjectAndTaskRepository _repository) 
        {
            this._repository = _repository;
        }

        public IActionResult InfoProject(int id)
        {
            ProjectAndTask projectAndTask = _repository.GetProjectAndTasks(id);
            if (projectAndTask == null) { return NotFound(); }
            return View(projectAndTask);
        }

    }
}
