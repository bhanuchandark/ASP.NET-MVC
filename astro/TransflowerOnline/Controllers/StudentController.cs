using System.Collections.Generic;
using System.Web.Mvc;
using BOL;
using BLL;

namespace TransflowerOnline.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            //invokig business logic layer
            List<Student> students = TrainingManager.GetAllStudents();
            return View(students);
        }

        //GET method
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public  ActionResult Login(string email,string password)
        {
            if(TrainingManager.ValidateStudent(email,password))
            {
                // List<Student> students = TrainingManager.GetAllStudents();
                //// return View(students);
                // return View("Index",students);
                return RedirectToAction("Index");
      
            }
            else
            {
                ViewData["status"]= "please try again Invalid Email or Password";
                return View();
            }
        }
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            if (TrainingManager.DeleteStudent(id))
            {
                ViewData["DelStatus"] = "student data deleted sucessfully";
                return View();
            }
            else
            {
                ViewData["status"] = "Failed to Delete the Student info";
                return View();
            }
            
        }
        public ActionResult Update()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Update(int id,string name,string city,string email)
        {

            if (TrainingManager.Update(id, name, email, city))
            {
                ViewData["UpdateStatus"] = "Successfully Updated the Student info";
                return View();
            }
            else
            {
                ViewData["UpdateStatus"] = "Failed to Update the Student Info";
                return View();
            }
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(int id,string name,string email,string password,string city)
        {
            if (TrainingManager.Register(id, name, email, password, city))
            {
                ViewData["RegStatus"] = "Student Registered Successfully";
                return View();
            }
            else
            {
                ViewData["status"] = "Register UnSuccessfull, Please try again";
                return View();
            }
        }


    }
}