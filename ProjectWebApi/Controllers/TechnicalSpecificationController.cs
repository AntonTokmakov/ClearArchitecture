using Microsoft.AspNetCore.Mvc;
using ProjectApplication.Interface;
using Tasks.Controllers.Repositories;
using TrialProject.Models;

namespace ProjectWebApi.Controllers
{
    public class TechnicalSpecificationController : Controller
    {
        private readonly ITechnicalSpecificationServices _technicalSpecificationServices;

        public TechnicalSpecificationController(ITechnicalSpecificationServices technicalSpecificationServices)
        {
            _technicalSpecificationServices = technicalSpecificationServices;
        }

        public ActionResult GetAllTS()
        {
            var technicalSpecifications = _technicalSpecificationServices.GetTS();
            return View(technicalSpecifications);
        }

        public ActionResult GetTSItem(int id)
        {
            var technicalSpecification = _technicalSpecificationServices.GetTSItem(id);
            return View(technicalSpecification);
        }

        [HttpGet]
        public ActionResult Create()
        {
            TechnicalSpecification technicalSpecification = new TechnicalSpecification();
            return View(technicalSpecification);
        }

        [HttpPost]
        public ActionResult Create(TechnicalSpecification technicalSpecification)
        {
            if (ModelState.IsValid)
            {
                _technicalSpecificationServices.AddTS(technicalSpecification);
                TempData["create_id_ts"] = technicalSpecification.id_ts;
                //return Redirect(Request.Headers["Referer"].ToString());
                return RedirectToAction("AddProject", "Project");
            }

            return View(technicalSpecification);
        }

        public ActionResult Edit(int id)
        {
            var technicalSpecification = _technicalSpecificationServices.GetTSItem(id);
            return View(technicalSpecification);
        }

        [HttpPost]
        public ActionResult Edit(TechnicalSpecification technicalSpecification)
        {
            if (ModelState.IsValid)
            {
                _technicalSpecificationServices.UpdateTS(technicalSpecification);
                return RedirectToAction("Index");
            }

            return View(technicalSpecification);
        }

        public ActionResult Delete(int id)
        {
            var technicalSpecification = _technicalSpecificationServices.GetTSItem(id);
            return View(technicalSpecification);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            _technicalSpecificationServices.DeleteTS(id);
            return RedirectToAction("Index");
        }

    }
}
