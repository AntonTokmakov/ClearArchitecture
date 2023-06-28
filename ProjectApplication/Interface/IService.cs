using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.Models;

namespace ProjectApplication.Interface
{
    public interface IService<T> where T : class
    {
        void Create(T item);
        void Update(T item);
        Project GetById(int id);
        IEnumerable<Project> GetItems();
        void Delete(int id);
    }
}
