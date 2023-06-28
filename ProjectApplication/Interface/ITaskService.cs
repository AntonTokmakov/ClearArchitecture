using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Tasks.Models;
using TrialProject.Models;

namespace ProjectApplication.Interface
{
    public interface ITaskService
    {
        void AddTask(TasksProject project);
        void UpdateTask(TasksProject project);
        TasksProject GetTaskById(int id);
        IEnumerable<TasksProject> GetTasks();
        void DeleteTask(int id);
    }
}
