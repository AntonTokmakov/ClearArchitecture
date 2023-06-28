using ProjectApplication.Interface;
using Tasks.Controllers.Repositories;
using Tasks.Models;

namespace TrialProject.UseCase
{
    public class ProjectService : IService<Project>
    {
        private readonly IRepository<Project> repository;

        public ProjectService(IRepository<Project> repository)
        {
            this.repository = repository;
        }

        public void Create(Project project)
        {
            repository.Create(project);
            repository.Save();
        }

        public void Delete(int id)
        {
            repository.Delete(id);
            repository.Save();
        }

        public Project GetById(int id)
        {
            return repository.GetItem(id);
        }

        public IEnumerable<Project> GetItems()
        {
            return repository.GetItemList();
        }

        public void Update(Project project)
        {
            repository.Update(project);
            repository.Save();
        }
    }
}
