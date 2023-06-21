using Tasks.Controllers.Repositories;
using TrialProject.Models;

namespace TrialProject.Controllers.Repositories
{
    public class SQLProjectTaskStatus : IRepository<ProjectTaskStatus>
    {
        private ProjectContext db;

        public SQLProjectTaskStatus(ProjectContext context)
        {
            this.db = context;
        }

        public void Create(ProjectTaskStatus projectTaskStatus)
        {
            db.task_status.Add(projectTaskStatus);
        }

        public void Delete(int id)
        {
            ProjectTaskStatus projectTaskStatus = db.task_status.Find(id);
            if (projectTaskStatus != null)
            {
                db.task_status.Remove(projectTaskStatus);
            }
        }

        public ProjectTaskStatus GetItem(int id)
        {
            return db.task_status.Find(id);
        }

        public IEnumerable<ProjectTaskStatus> GetItemList()
        {
            return db.task_status;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(ProjectTaskStatus projectTaskStatus)
        {
            db.task_status.Update(projectTaskStatus);
        }
    }
}
