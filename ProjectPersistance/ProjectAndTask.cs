using ProjectApplication;
using ProjectApplication.Interface;
using ProjectDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.Controllers.Repositories;
using Tasks.Models;
using TrialProject.Models;

namespace ProjectPersistance
{
    public class SQLProjectAndTask : IProjectAndTaskRepository
    {
        private ProjectContext db;
        public SQLProjectAndTask(ProjectContext db) 
        {
            this.db = db;
        }

        public ProjectAndTask GetProjectAndTasks(int id)
        {
            Project project = db.project.Find(id);
            List<TasksProject> tasksProject = new List<TasksProject>();
            IEnumerable<TasksProject> tasks = db.tasks;
            foreach (TasksProject task in tasks)
            {
                if (task.id_project == id)
                {
                    tasksProject.Add(task);
                }
            }
            //List<TasksProject> tasksProject = tasks.Where(t => t.id_project == id).ToList();
            ProjectAndTask projectAndTask = new ProjectAndTask()
            {
                Project = project,
                Tasks = tasksProject
            };
            return projectAndTask;
        }
    }
}
