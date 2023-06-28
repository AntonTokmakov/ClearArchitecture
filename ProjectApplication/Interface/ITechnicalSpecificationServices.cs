using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.Models;
using TrialProject.Models;

namespace ProjectApplication.Interface
{
    public interface IServices
    {
        void AddTS(TechnicalSpecification project);
        void UpdateTS(TechnicalSpecification project);
        TechnicalSpecification GetTSItem(int id);
        IEnumerable<TechnicalSpecification> GetTS();
        void DeleteTS(int id);
    }
}
