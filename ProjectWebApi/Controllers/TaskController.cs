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
        ITaskService _taskService;
        public TaskController(ITaskService _taskService) 
        { 
            this._taskService = _taskService;
        }

        // GET: TaskController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TaskController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public List<TasksProject> GetTasks(int id)
        {
            IEnumerable<TasksProject> tasks = _taskService.GetTasks();
            List<TasksProject> tasksProject = tasks.Where(t => t.IdProject == id).ToList();
            return tasksProject;
        }

        // GET: TaskController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaskController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Task task)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TaskController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TaskController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TaskController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TaskController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
