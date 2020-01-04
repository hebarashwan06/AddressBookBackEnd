using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddressBookDemo.DataAccess.Interfaces;
using AddressBookDemo.DataMapping.Entities;
using AddressBookDemo.DataMapping.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AddressBookDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository rep;

        public EmployeesController(IEmployeeRepository rep)
        {
            this.rep = rep;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var employees = rep.GetList();
                return Ok(employees);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            try
            {
                var employee = rep.GetById(id);
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Add(EmployeeVM employee)
        {
            try
            {
                rep.Insert(employee);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Edit(EmployeeVM employee)
        {
            try
            {
                rep.Update(employee);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                rep.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        




    }
}