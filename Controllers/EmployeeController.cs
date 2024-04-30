using LabPractice.Models;
using LabPractice.Service;
using Microsoft.AspNetCore.Mvc;

namespace LabPractice.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeRepository db;
        public EmployeeController(IEmployeeRepository data) { db = data; }
        public IActionResult Index()
        {
            ViewBag.Heading = "Employee Details";
            var b = db.GetAllEmployee();
            return View(b);
        }


        public IActionResult Details(int id)
        {
            return View(db.GetEmployee(id));

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var model = db.AddEmployee(employee);
                return RedirectToAction(nameof(Index));
            }
            return View();

        }

        public IActionResult Edit(int id)
        {
            var model = db.GetEmployee(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(Employee employee)
        {
            try
            {
                var model = db.UpdateEmployee(employee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }

        }

        public IActionResult Delete(int id)
        {
            var model = db.GetEmployee(id);
            return View(model);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public IActionResult Deletedata(int id)
        {
            if (ModelState.IsValid)
            {
                var model = db.DeleteEmployee(id);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }



    }

}



















