using CarAPI.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakeController : ControllerBase
    {
        private EmployeeDBContext _db;
        public MakeController(EmployeeDBContext db)
        {
            _db = db;
        }
        [Route("Get")]
        [HttpGet]
        public IActionResult Get()
        {

            var makes = _db.Employees.ToList();
            return Ok(makes);
        }

        [Route("Get/{id}")]
        [HttpGet]

        public IActionResult Get(int id)
        {
            var make = _db.Employees.Find(id);
            return Ok(make);
        }

        [Route("Create")]
        [HttpPost]
        public IActionResult Create(EmployeeModel model)
        {
            Employee emp = new Employee();
            emp.FirstName = model.FirstName;
            emp.LastName = model.LastName;
            emp.Gender = model.Gender;
            emp.Salary = model.Salary;

            _db.Add(emp);
            _db.SaveChanges();
            return Ok(emp);
        }

        [Route("Update")]
        [HttpPut]
        public IActionResult Update(EmployeeModel model)
        {
            var emp= _db.Employees.Find(model.Id);
            
           
            emp.FirstName = model.FirstName;
            emp.LastName = model.LastName;
            emp.Gender = model.Gender;
            emp.Salary = model.Salary;
            _db.Attach(emp);
            _db.SaveChanges();
            return Ok(emp);





        }
        [Route("Delete/{id}")]
        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var make = _db.Employees.Find(id);
            _db.Remove(make);
            _db.SaveChanges();
            return Ok(make);
        }
    }
}
