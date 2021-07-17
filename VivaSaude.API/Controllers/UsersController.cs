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

        /// <summary>
        /// Buscar todos os usuários cadastrados, para cada usuário, será retornando Nome, Idade, Peso e Altura.
        /// </summary>
        /// <param name="query"></param>
        /// <response code="200"> Retorna lista de usuários</response>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> FindAll(string query)
        {
            var users = await _useService.FindAll(query);

            if (users == null) return NotFound();

            return Ok(users);
        }

        /// <summary>
        /// Buscar um usuário pelo seu id
        /// </summary>
        /// <param name="id">Id do usuário buscado</param>
        /// <reponse code="200">Retorna usuário filtrado com detalhes</reponse>
        /// <reponse code="404">Retorna NotFound caso não haja usuário com este id</reponse>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> FindById(int id)
        {
            try
            {
                var user = await _useService.FindById(id);

                if (user == null) return NotFound();

                return Ok(user);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        /// <summary>
        /// Cadastrar usuário informando o Nome, Idade, Peso(em Kilos), Altura(em Centimetros), Gênero e Nível de atividade física(0 a 4)
        /// </summary>
        /// <param name="model">Dados do usuário Nome, Idade, Peso(Kg), Altura(Cm), Gênero(Masculino = 0 / Feminino = 1) e Nivel Atividade:
        /// 0 = Sedentário; 1 = Leve; 2 = Moderado; 3 = Intenso e 4 = Muito Intenso</param>
        /// <reponse code="201">Caso usuário seja cadastrado com sucesso</reponse>
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserInputModel model)
        {

            var user = await _useService.CreateUser(model); // Retorna o Id para ser usado no CreatedAtAction 

            return CreatedAtAction(nameof(FindById), new { id = user }, model);
        }

        /// <summary>
        /// Atualizar dados do Usuário
        /// </summary>
        /// <param name="id">Id do usuário a ser atualizado</param>
        /// <param name="model">Dados do usuário a ser atualizado</param>
        /// <reponse code="204">caso o usuário seja atulizado com sucesso</reponse>
        [HttpPut]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] UpdateUserInputModel model)
        {
            try
            {
                await _useService.UpdateUser(id, model);

                return NoContent();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        /// <summary>
        /// Inativar usuário cadastrado
        /// </summary>
        /// <param name="id">Id do usuário que será inativado</param>
        /// <reponse code="204">Caso o status do usuário mude para inativel</reponse>
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _useService.Delete(id);

                return NoContent();

            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
