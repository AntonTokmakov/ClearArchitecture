using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectApplication.Interface;
using System.Net.NetworkInformation;
using TrialProject.Models;

namespace ProjectWebApi.Controllers
{
    public class TaskController : Controller
    {
        IService<TasksProject> _taskService;
        public TaskController(IService<TasksProject> _taskService) 
        { 
            this._taskService = _taskService;
        }

        public IActionResult Create(int id)
        {
            TasksProject task = new TasksProject();
            task.id_project = id;
            return View(task);
        }

        [HttpPost]
        public IActionResult Create(TasksProject task)
        {
            if (ModelState.IsValid)
            {
                _taskService.Create(task);
                return RedirectToAction("GetProjects", "Project");
            }
            return View(task);
        }
    }
}
