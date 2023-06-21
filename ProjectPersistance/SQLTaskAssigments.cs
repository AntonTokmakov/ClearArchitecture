using Tasks.Controllers.Repositories;
using Tasks.Models;

namespace TrialProject.Controllers.Repositories
{
    public class SQLTaskAssigments : IRepository<TaskAssigments>
    {
        private ProjectContext db;

        public SQLTaskAssigments(ProjectContext context)
        {
            this.db = context;
        }

        public void Create(TaskAssigments taskAssigments)
        {
            db.task_assigments.Add(taskAssigments);
        }

        public void Delete(int id)
        {
            TaskAssigments taskAssigments = db.task_assigments.Find(id);
            if (taskAssigments != null)
            {
                db.task_assigments.Remove(taskAssigments);
            }
        }

        public TaskAssigments GetItem(int id)
        {
            return db.task_assigments.Find(id);
        }

        public IEnumerable<TaskAssigments> GetItemList()
        {
            return db.task_assigments;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(TaskAssigments taskAssigments)
        {
            db.task_assigments.Update(taskAssigments);
        }
    }
}
