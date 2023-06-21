using Tasks.Models;

namespace Tasks.Controllers.Repositories
{
    public class SQLProjectRepository : IRepository<Project>
    {
        private ProjectContext db;

        public SQLProjectRepository(ProjectContext context)
        {
            this.db = context;
        }

        public void Create(Project project)
        {
            db.project.Add(project);
        }

        public void Delete(int id)
        {
            Project project = db.project.Find(id);
            if (project != null)
               db.project.Remove(project);
        }

        public Project GetItem(int id)
        {
            return db.project.Find(id);
        }

        public IEnumerable<Project> GetItemList()
        {
            return db.project;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Project project)
        {
            db.project.Update(project);
        }
    }
}
