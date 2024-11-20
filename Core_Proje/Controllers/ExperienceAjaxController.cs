using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core_Proje.Controllers
{
    public class ExperienceAjaxController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListExperience()
        {

            var values = JsonConvert.SerializeObject(experienceManager.GetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            experienceManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
        public IActionResult GetById(int ExperienceId)
        {
            var v = experienceManager.TGetByID(ExperienceId);
            var values=JsonConvert.SerializeObject(v);
            return Json(values);
        }
        public IActionResult DeleteExperience(int id)
        {
            var v = experienceManager.TGetByID(id);
            experienceManager.TDelete(v);
            return NoContent();
        }
        public IActionResult UpdateExperience(Experience p)
        {
            var existingExperience = experienceManager.TGetByID(p.ExperienceId);
            existingExperience.Name = p.Name;
            existingExperience.ImageUrl = p.ImageUrl;
            existingExperience.Date = p.Date;
            existingExperience.Decription = p.Decription;

            experienceManager.TUpdate(existingExperience);
            var updatedValues = JsonConvert.SerializeObject(existingExperience);
            return Json(updatedValues);

        }
    }
}