using Tasks.Controllers.Repositories;
using Tasks.Models;

namespace TrialProject.UseCase
{
    public class ProjectService : IProjectService
    {
        private readonly IRepository<Project> repository;

        public ProjectService(IRepository<Project> repository)
        {
            this.repository = repository;
        }

        public void AddProject(Project project)
        {
            repository.Create(project);
            repository.Save();
        }

        public void DeleteProject(int id)
        {
            repository.Delete(id);
            repository.Save();
        }

        public Project GetProjectById(int id)
        {
            return repository.GetItem(id);
        }

        public IEnumerable<Project> GetProjects()
        {
            return repository.GetItemList();
        }

        public void UpdateProject(Project project)
        {
            repository.Update(project);
            repository.Save();
        }
    }
}
