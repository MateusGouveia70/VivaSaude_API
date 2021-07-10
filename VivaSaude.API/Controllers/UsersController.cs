using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivaSaude.API.Models;

namespace VivaSaude.API.Controllers
{
    [Route("api/V1/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult FindAll(string query)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] CreateUserModel model)
        {
            return CreatedAtAction(nameof(FindById), new { id = model.Id }, model);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] UpdateUserModel model)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
