using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> l = GetAllStudents();

            return View(l);
        }

        private static List<Student> GetAllStudents()
        {
            List<Student> l = new List<Student>();
            l.Add(new Student { Age = 22, StudentId = 1, StudentName = "Mark Twain", Specialization = "Mathematics", University = "Some University1"});

            l.Add(new Student { Age = 20, StudentId = 2, StudentName = "Victoria Brown", Specialization = "Geography", University = "Some University2" });

            l.Add(new Student { Age = 21, StudentId = 3, StudentName = "Vera Lee", Specialization = "History", University = "Some University2" });

            l.Add(new Student { Age = 22, StudentId = 4, StudentName = "Ashton Twin", Specialization = "Diplomacy", University = "Some University2" });

            l.Add(new Student { Age = 22, StudentId = 1, StudentName = "Mark Twain", Specialization = "Sience", University = "Some University1" });
            return l;
        }

        private static Student GetStudentById(int id)
        {
            List<Student> l = GetAllStudents();

            var s = l.FirstOrDefault(p => p.StudentId == id);
            return s;
        }

        [ActionName ("Details")]
        public ActionResult GetById (int id)
        {

            Student s = GetStudentById(id);

            return View(s);
        }
    }
}