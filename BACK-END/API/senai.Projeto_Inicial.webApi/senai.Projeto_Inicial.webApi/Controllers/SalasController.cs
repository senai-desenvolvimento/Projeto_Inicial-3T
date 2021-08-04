using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.Projeto_Inicial.webApi.Domains;
using senai.Projeto_Inicial.webApi.Interfaces;
using senai.Projeto_Inicial.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Projeto_Inicial.webApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SalasController : ControllerBase
    {
        private ISalaRepository _salaRepository { get; set; }

        SalasController()
        {
            _salaRepository = new SalaRepository();
        }

        /// <summary>
        /// Lista salas
        /// </summary>
        /// <returns>Lista de salas</returns>
        //[Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_salaRepository.Listar());
        }

        /// <summary>
        /// Cria sala
        /// </summary>
        /// <param name="sala">sala a ser criada</param>
        /// <returns>Statuscode 201 - Created</returns>
        //[Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Sala sala)
        {
            _salaRepository.Criar(sala);

            return StatusCode(201);
        }

        /// <summary>
        /// Atualiza sala
        /// </summary>
        /// <param name="sala">sala com dados a serem atualizados</param>
        /// <returns>StatusCode 204 - NoContent</returns>
        //[Authorize(Roles = "1")]
        [HttpPatch]
        public IActionResult Patch(Sala sala)
        {
            _salaRepository.Atualizar(sala);

            return StatusCode(204);
        }

        /// <summary>
        /// Exclui sala
        /// </summary>
        /// <param name="sala">id do sala a ser excluída</param>
        /// <returns>StatusCode 204 - NoContent</returns>
        //[Authorize(Roles = "1")]
        [HttpDelete]
        public IActionResult Delete(Sala sala)
        {
            _salaRepository.Excluir(sala.IdSala);

            return StatusCode(204);
        }
    }
}
