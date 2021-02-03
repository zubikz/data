using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practice1.Models;
namespace practice1.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;
        public HomeController()
        {
            _context = new Context();
        }

        public JsonResult List()
        {
            return Json(_context.Students.ToList(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Add(student std)
        {
            _context.Students.Add(std);
            _context.SaveChanges();
            return Json(JsonRequestBehavior.AllowGet);
        }
        

        
        public ActionResult Index()
        {
            ViewBag.data = _context.Students.Count();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public JsonResult GetId(int id)
        {
            return Json(_context.Students.FirstOrDefault(x => x.Id == id), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult Update(student std)
        {
            var data = _context.Students.FirstOrDefault(x => x.Id == std.Id);
            if (data != null)
            {
                data.Name = std.Name;
                data.Age = std.Age;
                data.state = std.state;
                data.Country = std.Country;
                _context.SaveChanges();
            }
            return Json(JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(int Id)
        {
            var data = _context.Students.FirstOrDefault(x => x.Id == Id);
            
                _context.Students.Remove(data);
                _context.SaveChanges();
            
            return Json(JsonRequestBehavior.AllowGet);
        }
    }
}