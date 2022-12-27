using Microsoft.AspNetCore.Mvc;
using MVC_CRUD.Services;
using MVC_CRUD.Models;

namespace MVC_CRUD.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentView()
        {
            return View(StudentService.GetNameEmail());
            
        }
        public IActionResult DeleteStd(string Name)
        {
            StudentService.DeleteUser(Name);
            return RedirectToAction("StudentView");

        }

        public IActionResult UpdateStd(StudentModel model)
        {
            StudentService.UpdateUser(model);
            return RedirectToAction("StudentView");

        }

        [HttpPost]
        
        public IActionResult StudentView(StudentModel model)
        {
            StudentService.SetNameEmail(model);
            return View(StudentService.GetNameEmail());
        }


        
    }
}
