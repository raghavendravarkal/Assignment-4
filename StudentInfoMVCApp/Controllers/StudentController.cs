using StudentInfoMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentInfoMVCApp.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/
        public ActionResult Index()
        {
            StudentContext studentContext = new StudentContext();
            List<Student> lststudents = studentContext.Students.ToList();
            return View(lststudents);
        }
        public ActionResult Details(int Id)
        {
            StudentContext studentContext = new StudentContext();
            Student student = studentContext.Students.Single(stn => stn.StudentID == Id);

            return View(student);
        }
    }
}