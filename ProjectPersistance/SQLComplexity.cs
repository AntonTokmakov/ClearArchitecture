using Tasks.Controllers.Repositories;
using Tasks.Models;

namespace TrialProject.Controllers.Repositories
{
    public class SQLComplexity : IRepository<Complexity>
    {
        private ProjectContext db;

        public SQLComplexity(ProjectContext context)
        {
            this.db = context;
        }

        public void Create(Complexity complexity)
        {
            db.complexity.Add(complexity);
        }

        public void Delete(int id)
        {
            Complexity complexity = db.complexity.Find(id);
            if (complexity != null)
            {
                db.complexity.Remove(complexity);
            }
        }

        public Complexity GetItem(int id)
        {
            return db.complexity.Find(id);
        }

        public IEnumerable<Complexity> GetItemList()
        {
            return db.complexity;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Complexity complexity)
        {
            db.complexity.Update(complexity);
        }
    }
}
