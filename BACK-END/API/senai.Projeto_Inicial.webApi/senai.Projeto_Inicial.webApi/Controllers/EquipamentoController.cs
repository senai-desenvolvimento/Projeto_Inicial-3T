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
    public class EquipamentoController : ControllerBase
    {
        private IEquipamentoRepository _equipamentoRepository { get; set; }
        
        public EquipamentoController()
        {
            _equipamentoRepository = new EquipamentoRepository();
        }

        //[Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_equipamentoRepository.Listar().OrderBy(c => c.IdEquipamento));
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        //[Authorize]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_equipamentoRepository.BuscarPorId(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        //[Authorize]
        [HttpPost]
        public IActionResult Post(Equipamento novoEquipamento)
        {
            try
            {
                _equipamentoRepository.Cadastrar(novoEquipamento);

                return StatusCode(201);
            }
            catch (Exception codErro)
            {
                return BadRequest(codErro);

            }

        }

        //[Authorize]
        [HttpPut("{id}")]
        public IActionResult Update(int id, Equipamento equipamentoAtualizado)
        {
            try
            {
                _equipamentoRepository.Atualizar(id, equipamentoAtualizado);

                return StatusCode(200);
            }
            catch (Exception codErro)
            {
                return BadRequest(codErro);
            }
        }

        //[Authorize]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _equipamentoRepository.Deletar(id);
                return StatusCode(200);
            }
            catch (Exception codErro)
            {
                return BadRequest(codErro);

            }
        }
    }
}
