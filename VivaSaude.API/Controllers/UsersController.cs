using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivaSaude.API.Models;
using VivaSaude.Application.InputModels;
using VivaSaude.Application.Repositories;
using VivaSaude.Application.Repositories.UserService;
using VivaSaude.Application.Services;

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
        public async Task<IActionResult> FindAll(string query)
        {
            var users = await _useService.FindAll(query);

            if (users == null) return NotFound();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> FindById(int id)
        {
            var user = await _useService.FindById(id);

            if (user == null) return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserInputModel model)
        {
            if(model.Nome.Length > 100) // Depois aplicar o fluent validation
            {
                return BadRequest();
            }

            var user = await _useService.CreateUser(model); // Retorna o Id para ser usado no CreatedAtAction 

            return CreatedAtAction(nameof(FindById), new { id = user }, model);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserInputModel model)
        {
            await _useService.UpdateUser(model);
            
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _useService.Delete(id);

            return NoContent();
        }
    }
}
