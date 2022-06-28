using Microsoft.AspNetCore.Mvc;
using School_Project.Models;

namespace School_Project.Controllers
{
    public class StudentController : Controller
    {
            static List<Student> studentList = new List<Student>(){
                new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 }
            };

        public ActionResult Index() 
        {
            return View(studentList);
        }

        public ActionResult Edit(int? Id)
        {
            if (Id != null)
            {
                var std = studentList.Where(s => s.StudentId == Id).FirstOrDefault();
                return View(std);
            }
            else
            {
                return View();
            }  
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            if (std.StudentId == 0)
            {
                std.StudentId = MaxId();
                studentList.Add(std);                
            }
            else 
            {             
                var student = studentList.Where(s => s.StudentId == std.StudentId).FirstOrDefault();
                studentList.Remove(student);
                studentList.Add(std);
            }

            return RedirectToAction("Index");
        }

        public int MaxId() 
        {          
            int maxid = studentList.Max(x => x.StudentId);
            int studentID = maxid + 1;
            return studentID;
        }
    }
}