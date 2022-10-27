using CoreBlogApi.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        Context c = new Context();

        [HttpGet]
        public IActionResult EmployeeList()
        {
            var values = c.Employees.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            c.Employees.Add(employee);
            c.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult FindEmployee(int id)
        {
            var employee = c.Employees.Find(id);

            if(employee == null)
            {
                return NotFound();
            }

            else
            {
                return Ok(employee);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var emp = c.Employees.Find(id);
            if(emp == null)
            {
                return NotFound();
            }
            else
            {
                c.Employees.Remove(emp);
                c.SaveChanges();
                return Ok();
            }
        }

        [HttpPut]
        public IActionResult UpdateEmployee(Employee employee)
        {
            var emp = c.Find<Employee>(employee.ID);
            if (emp == null)
            {
                return NotFound();
            }

            else
            {
                emp.Name = employee.Name;
                c.Update(emp);
                c.SaveChanges();
                return Ok();    
            }
        }

    }
}
