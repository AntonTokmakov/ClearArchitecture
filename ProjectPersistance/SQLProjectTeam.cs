using Tasks.Controllers.Repositories;
using Tasks.Models;

namespace TrialProject.Controllers.Repositories
{
    public class SQLProjectTeam : IRepository<ProjectTeam>
    {
        private ProjectContext db;

        public SQLProjectTeam(ProjectContext context)
        {
            this.db = context;
        }

        public void Create(ProjectTeam projectTeam)
        {
            db.project_teams.Add(projectTeam);
        }

        public void Delete(int id)
        {
            ProjectTeam projectTeam = db.project_teams.Find(id);
            if (projectTeam != null)
            {
                db.project_teams.Remove(projectTeam);
            }
        }

        public ProjectTeam GetItem(int id)
        {
            return db.project_teams.Find(id);
        }

        public IEnumerable<ProjectTeam> GetItemList()
        {
            return db.project_teams;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(ProjectTeam projectTeam)
        {
            db.project_teams.Update(projectTeam);
        }
    }
}
