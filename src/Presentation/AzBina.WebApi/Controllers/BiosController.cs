using AzBina.Domain.Entities;
using AzBina.Persistence.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AzBina.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BiosController : ControllerBase
    {

        public BiosController(AzBinaDbContext context)
        {
        }
        // GET: api/<BiosController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }

        // GET api/<BiosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BiosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<BiosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BiosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
