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

namespace ProjectApplication
{
    public class ProjectAndTaskService : IProjectAndTaskService
    {
        IProjectAndTaskRepository _repository;

        public ProjectAndTaskService(IProjectAndTaskRepository _repository) 
        {
            this._repository = _repository;
        }

        public ProjectAndTask GetItem(int id)
        {
            return _repository.GetProjectAndTasks(id);
        }
    }
}
