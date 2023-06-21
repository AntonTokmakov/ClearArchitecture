using Tasks.Controllers.Repositories;
using Tasks.Models;

namespace TrialProject.Controllers.Repositories
{
    public class SQLProjectStatus : IRepository<ProjectStatus>
    {
        private ProjectContext db;

        public SQLProjectStatus(ProjectContext context)
        {
            this.db = context;
        }

        public void Create(ProjectStatus projectStatus)
        {
            db.project_status.Add(projectStatus);
        }

        public void Delete(int id)
        {
            ProjectStatus projectStatus = db.project_status.Find(id);
            if (projectStatus != null)
            {
                db.project_status.Remove(projectStatus);
            }
        }

        public ProjectStatus GetItem(int id)
        {
            return db.project_status.Find(id);
        }

        public IEnumerable<ProjectStatus> GetItemList()
        {
            return db.project_status;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(ProjectStatus projectStatus)
        {
            db.project_status.Update(projectStatus);
        }
    }
}
