using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddressBookDemo.DataAccess.Interfaces;
using AddressBookDemo.DataMapping.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AddressBookDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository rep;

        public DepartmentsController(IDepartmentRepository rep)
        {
            this.rep = rep;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var departments = rep.GetList();
                return Ok(departments);
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
                var department = rep.GetById(id);
                return Ok(department);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public IActionResult Add(Department department)
        {
            try
            {
                rep.Insert(department);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Edit(Department department)
        {
            try
            {
                rep.Update(department);
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