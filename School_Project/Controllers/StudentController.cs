using Microsoft.AspNetCore.Mvc;
using School_Project.Models;
namespace School_Project.Controllers
{
    public class StudentController : Controller
    {
        

        public ActionResult Index() 
        {
            Student[] studentList = {
                new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 }
                };
            return View(studentList);
        }

    }
}
