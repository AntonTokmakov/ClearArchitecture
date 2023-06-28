using ProjectApplication.Interface;
using Tasks.Controllers.Repositories;
using TrialProject.Models;

namespace ProjectApplication
{
    public class TaskService : IService<TasksProject>
    {
        IRepository<TasksProject> repository;

        public TaskService(IRepository<TasksProject> repository) 
        {
            this.repository = repository;
        }

        public void Create(TasksProject task)
        {
            repository.Create(task);
            repository.Save();
        }

        public void Delete(int id)
        {
            repository.Delete(id);
            repository.Save();
        }

        public TasksProject GetById(int id)
        {
            return repository.GetItem(id);
        }

        public IEnumerable<TasksProject> GetItems()
        {
            return repository.GetItemList();
        }

        public void Update(TasksProject task )
        {
            repository.Update(task);
            repository.Save();
        }
    }
}
