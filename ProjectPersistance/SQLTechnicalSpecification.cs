using Tasks.Controllers.Repositories;
using TrialProject.Models;

namespace TrialProject.Controllers.Repositories
{
    public class SQLTechnicalSpecification : IRepository<TechnicalSpecification>
    {
        private ProjectContext db;

        public SQLTechnicalSpecification(ProjectContext context)
        {
            this.db = context;
        }

        public void Create(TechnicalSpecification technicalSpecification)
        {
            db.technical_specifications.Add(technicalSpecification);
        }

        public void Delete(int id)
        {
            TechnicalSpecification technicalSpecification = db.technical_specifications.Find(id);
            if (technicalSpecification != null)
            {
                db.technical_specifications.Remove(technicalSpecification);
            }
        }

        public TechnicalSpecification GetItem(int id)
        {
            return db.technical_specifications.Find(id);
        }

        public IEnumerable<TechnicalSpecification> GetItemList()
        {
            return db.technical_specifications;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(TechnicalSpecification technicalSpecification)
        {
            db.technical_specifications.Update(technicalSpecification);
        }
    }
}
