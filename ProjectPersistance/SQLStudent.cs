using Microsoft.EntityFrameworkCore;
using Tasks.Controllers.Repositories;
using Tasks.Models;

namespace TrialProject.Controllers.Repositories
{
    public class SQLStudent : IRepository<Student>
    {
        private ProjectContext db;

        public SQLStudent(ProjectContext context)
        {
            this.db = context;
        }

        public void Create(Student student)
        {
            db.student.Add(student);
        }

        public void Delete(int id)
        {
            Student student = db.student.Find(id);
            if (student != null)
            {
                db.student.Remove(student);
            }
        }

        public Student GetItem(int id)
        {
            return db.student.Find(id);
        }

        public IEnumerable<Student> GetItemList()
        {
            return db.student;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Student student)
        {
            db.student.Update(student);
        }
    }
}
