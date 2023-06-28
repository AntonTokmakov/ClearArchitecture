using ProjectApplication.Interface;
using Tasks.Controllers.Repositories;

namespace ProjectApplication
{
    public class TaskService : ITaskService
    {
        IRepository<Task> repository;

        public TaskService(IRepository<Task> repository) 
        {
            this.repository = repository;
        }

        public void AddTask(Task task)
        {
            repository.Create(task);
            repository.Save();
        }

        public void DeleteTask(int id)
        {
            repository.Delete(id);
            repository.Save();
        }

        public Task GetTaskById(int id)
        {
            return repository.GetItem(id);
        }

        public IEnumerable<Task> GetTasks()
        {
            return repository.GetItemList();
        }

        public void UpdateTask(Task task )
        {
            repository.Update(task);
            repository.Save();
        }
    }
}
