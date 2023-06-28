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
     public class TechnicalSpecificationService : IServices
    {
        private readonly IRepository<TechnicalSpecification> _repository;

        public TechnicalSpecificationService(IRepository<TechnicalSpecification> _repository) 
        {
            this._repository = _repository;
        }

        public void AddTS(TechnicalSpecification project)
        {
            _repository.Create(project);
            _repository.Save();
        }

        public void DeleteTS(int id)
        {
            _repository.Delete(id);
            _repository.Save();
        }

        public TechnicalSpecification GetTSItem(int id)
        {
            return _repository.GetItem(id);
        }

        public IEnumerable<TechnicalSpecification> GetTS()
        {
            return _repository.GetItemList();
        }

        public void UpdateTS(TechnicalSpecification project)
        {
            _repository.Update(project);
            _repository.Save();
        }
    }
}
