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
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        UsuariosController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// Lista usuarios
        /// </summary>
        /// <returns>Lista de usuarios</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_usuarioRepository.Listar());
        }

        /// <summary>
        /// Cria usuario
        /// </summary>
        /// <param name="usuario">usuario a ser criado</param>
        /// <returns>Statuscode 201 - Created</returns>
        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            _usuarioRepository.Criar(usuario);

            return StatusCode(201);
        }

        /// <summary>
        /// Atualiza senha do usuario
        /// </summary>
        /// <param name="usuario">usuario com dados a serem atualizados</param>
        /// <returns>StatusCode 204 - NoContent</returns>
        [HttpPatch]
        public IActionResult Patch(Usuario usuario)
        {
            _usuarioRepository.Atualizar(usuario);

            return StatusCode(204);
        }

        /// <summary>
        /// Exclui usuario
        /// </summary>
        /// <param name="usuario">id do usuario a ser excluído</param>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult Delete(Usuario usuario)
        {
            _usuarioRepository.Excluir(usuario.IdUsuario);

            return StatusCode(204);
        }
    }
}
