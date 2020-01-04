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
    public class JobsController : ControllerBase
    {
        private readonly IJobRepository rep;

        public JobsController(IJobRepository rep)
        {
            this.rep = rep;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var jobs = rep.GetList();
                return Ok(jobs);
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
                var job = rep.GetById(id);
                return Ok(job);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public IActionResult Add(Job job)
        {
            try
            {
                rep.Insert(job);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Edit(Job job)
        {
            try
            {
                rep.Update(job);
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