using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.Projeto_Inicial.webApi.Domains;
using senai.Projeto_Inicial.webApi.Interfaces;
using senai.Projeto_Inicial.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
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

        public UsuariosController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// Lista usuarios
        /// </summary>
        /// <returns>Lista de usuarios</returns>
        //[Authorize(Roles = "1")]
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
        //[Authorize(Roles = "1")]
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
        //[Authorize(Roles = "1")]
        [HttpPut]
        public IActionResult Put(Usuario usuario)
        {
            usuario.IdUsuario = Convert.ToInt32(HttpContext.User.Claims.First(x => x.Type == JwtRegisteredClaimNames.Jti).Value);

            _usuarioRepository.Atualizar(usuario);

            return StatusCode(204);
        }

        /// <summary>
        /// Exclui usuario
        /// </summary>
        /// <param name="usuario">id do usuario a ser excluído</param>
        /// <returns>StatusCode 204 - NoContent</returns>
        //[Authorize(Roles = "1")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _usuarioRepository.Excluir(id);

            return StatusCode(204);
        }
    }
}
