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
        T GetById(int id);
        IEnumerable<T> GetItems();
        void Delete(int id);
    }
}
