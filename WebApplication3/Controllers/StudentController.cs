using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WebApplication3.NewFolder;

namespace WebApplication3.Controllers
{
    public class StudentController :Controller
    {

        private static List<Registrants> studentList = new List<Registrants>();

        private static List<string> StateMaster = new List<string> { "UP", "UK", "TN", "MP", "HR" };
        private readonly Dictionary<string, List<string>> _stateCityData = new()
    {
        { "UP", new List<string> { "Lucknow", "Agra", "Varanasi", "Kanpur", "Meerut" } },
        { "UK", new List<string> { "Dehradun", "Nainital", "Haridwar", "Rishikesh", "Almora" } },
        { "TN", new List<string> { "Chennai", "Madurai", "Coimbatore", "Trichy", "Salem" } },
        { "MP", new List<string> { "Bhopal", "Indore", "Gwalior", "Jabalpur", "Ujjain" } },
        { "HR", new List<string> { "Chandigarh", "Faridabad", "Gurugram", "Ambala", "Hisar" } }
    };


        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            ViewBag.States = _stateCityData.Keys;
            ViewBag.Cities = new List<string>();

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Registrants model)
        {
            if (ModelState.IsValid)
            {
                Random rand = new Random();
                int randomInt = rand.Next();
                model.Id = randomInt;
                studentList.Add(model);

                TempData["SuccessMessage"] = "Registration successful!";
                return RedirectToAction("List");
            }

            ViewBag.States = _stateCityData.Keys;
            ViewBag.Cities = new List<string> { "No cities available" };

            return View(model);
        }


        public ActionResult List()
        {
            return View(studentList);
        }

        public JsonResult GetCitiesByState(string state)
        {
             var cities = _stateCityData[state];

            return Json(cities);
        }


        public IActionResult Edit(int id)
        {
            ViewBag.States = _stateCityData.Keys;
            var student = studentList.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }
            ViewBag.Cities = _stateCityData[student.State];
            return View(student); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Registrants model)
        {
            var student = studentList.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {

                return NotFound();
            }

            if (ModelState.IsValid)
            {
   
                    student.Name = model.Name;
                    student.Email = model.Email;
                    student.Mobile = model.Mobile;
                    student.State = model.State;
                    student.City = model.City;
                    student.AboutYourself = model.AboutYourself;
                    TempData["SuccessMessage"] = "Student updated successfully!";
                    return RedirectToAction("List");
            }
            ViewBag.States = _stateCityData.Keys;
            ViewBag.Cities = _stateCityData[student.State];

            return View(model); 
        }

        public ActionResult Delete(int id)
        {
            var student = studentList.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                studentList.Remove(student);
                return RedirectToAction("List");
            }
            return NotFound();
        }

    }
}
