
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Threading.Tasks;
using Tasks.Controllers.Repositories;
using Tasks.Models;
using TrialProject.Models;

namespace TrialProject.Controllers.Repositories
{
    public class UnitOfWork// : IDisposable
    {
        /*private ProjectContext db = new ProjectContext();
        private SQLComplexity sqlComplexity;
        private SQLProjectRepository sqlProjectRepository;
        private SQLProjectStatus sqlProjectStatus;
        private SQLProjectTaskStatus sqlProjectTaskStatus;
        private SQLProjectTeam sqlProjectTeam;
        private SQLStudent sqlStudent;
        private SQLTaskProject sqlTaskProject;
        private SQLTaskAssigments sqlTaskAssigments;
        private SQLTechnicalSpecification sqlTechnicalSpecification;

        public SQLComplexity Complexity
        {
            get
            {
                if (sqlComplexity == null)
                    sqlComplexity = new SQLComplexity(db);
                return sqlComplexity;
            }
        }

        public SQLProjectRepository ProjectRepository 
        {
            get
            {
                if (sqlProjectRepository == null)
                {
                    sqlProjectRepository = new SQLProjectRepository(db);
                }
                return sqlProjectRepository; 
            } 
        }

        public SQLProjectStatus ProjectStatus
        {
            get
            {
                if (sqlProjectStatus == null)
                {
                    sqlProjectStatus = new SQLProjectStatus(db);
                }
                return sqlProjectStatus;
            }
        }

        public SQLProjectTaskStatus ProjectTaskStatus
        {
            get
            {
                if (sqlProjectTaskStatus == null)
                {
                    sqlProjectTaskStatus = new SQLProjectTaskStatus(db);
                }
                return sqlProjectTaskStatus;
            }
        }

        public SQLProjectTeam ProjectTeam
        {
            get
            {
                if (sqlProjectTeam == null)
                {
                    sqlProjectTeam = new SQLProjectTeam(db);
                }
                return sqlProjectTeam;
            }
        }

        public SQLStudent Student
        {
            get
            {
                if (sqlStudent == null)
                {
                    sqlStudent = new SQLStudent(db);
                }
                return sqlStudent;
            }
        }

        public SQLTaskAssigments TaskAssigments
        {
            get
            {
                if (sqlTaskAssigments == null)
                {
                    sqlTaskAssigments = new SQLTaskAssigments(db);
                }
                return sqlTaskAssigments;
            }
        }

        public SQLTaskProject TaskProject
        {
            get
            {
                if (sqlTaskProject == null)
                {
                    sqlTaskProject = new SQLTaskProject(db);
                }
                return sqlTaskProject;
            }
        }

        public SQLTechnicalSpecification TechnicalSpecification
        {
            get
            {
                if (sqlTechnicalSpecification == null)
                {
                    sqlTechnicalSpecification = new SQLTechnicalSpecification(db);
                }
                return sqlTechnicalSpecification;
            }
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }*/
    }
}
