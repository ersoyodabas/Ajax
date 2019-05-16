using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        Student st = new Student();


        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetListStudent()  
        {
            return Json(Student.StudentList, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult InsertOrUpdateStudent(Student student)
        {
            Student.StudentList.Add(student);
            return Json(Student.StudentList, JsonRequestBehavior.AllowGet);
        }
    }
}