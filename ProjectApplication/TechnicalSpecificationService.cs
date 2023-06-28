using ProjectApplication.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.Controllers.Repositories;
using TrialProject.Models;

namespace ProjectApplication
{
     public class TechnicalSpecificationService : IService<TechnicalSpecification>
    {
        private readonly IRepository<TechnicalSpecification> _repository;

        public TechnicalSpecificationService(IRepository<TechnicalSpecification> _repository) 
        {
            this._repository = _repository;
        }

        public void Create(TechnicalSpecification project)
        {
            _repository.Create(project);
            _repository.Save();
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
            _repository.Save();
        }

        public TechnicalSpecification GetById(int id)
        {
            return _repository.GetItem(id);
        }

        public IEnumerable<TechnicalSpecification> GetItems()
        {
            return _repository.GetItemList();
        }

        public void Update(TechnicalSpecification project)
        {
            _repository.Update(project);
            _repository.Save();
        }
    }
}
