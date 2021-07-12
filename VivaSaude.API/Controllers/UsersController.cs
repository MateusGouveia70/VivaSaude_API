using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivaSaude.API.Models;
using VivaSaude.Application.InputModels;
using VivaSaude.Application.Repositories;

namespace VivaSaude.API.Controllers
{
    [Route("api/V1/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _useService;

        public UsersController(IUserService useService)
        {
            _useService = useService;
        }

        [HttpGet]
        public IActionResult FindAll(string query)
        {
            var users = _useService.FindAll(query);

            if (users == null) return NotFound();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            var user = _useService.FindById(id);

            if (user == null) return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] UserInputModel model)
        {
            if(model.Nome.Length > 100) // Depois aplicar o fluent validation
            {
                return BadRequest();
            }

            var user = _useService.CreateUser(model); // Retorna o Id para ser usado no CreatedAtAction 

            return CreatedAtAction(nameof(FindById), new { id = user }, model);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromBody] UpdateUserInputModel model)
        {
            _useService.UpdateUser(model);
            
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _useService.Delete(id);

            return NoContent();
        }
    }
}
