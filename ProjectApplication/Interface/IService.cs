using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.Models;

namespace ProjectApplication.Interface
{
    public interface IService
    {
        void Create(Project project);
        void Update(Project project);
        Project GetById(int id);
        IEnumerable<Project> GetItems();
        void Delete(int id);
    }
}
