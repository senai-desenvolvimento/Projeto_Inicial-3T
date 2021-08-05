using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.salaDeAula.webApi.Domains;
using senai.salaDeAula.webApi.Interfaces;
using senai.salaDeAula.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.salaDeAula.webApi.Controllers
{
    //Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    //Define que a rota da requisição será no formato dominió/api/nomeController
    //ex: http://localhost:5000/api/controleequipamento
    [Route("api/[controller]")]

    //Define que é um controlador de API
    [ApiController]

    /*[Authorize(Roles = "1")]*/
    public class ControleEquipamentoController : ControllerBase
    {
        private IControleEquipamentoRepository _controleEquipamentoRepository { get; set; }

        public ControleEquipamentoController()
        {
            _controleEquipamentoRepository = new ControleEquipamentoRepository();
        }

        [HttpGet]
        public IActionResult GetConsultas()
        {
            try
            {
                return Ok(_controleEquipamentoRepository.Listar());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_controleEquipamentoRepository.BuscarPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Post(ControleEquipamento novoEquipamento)
        {
            try
            {
                _controleEquipamentoRepository.Cadastrar(novoEquipamento);

                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, ControleEquipamento controleEquipamentoAtualizado)
        {
            try
            {
                _controleEquipamentoRepository.AtualizarPorId(id, controleEquipamentoAtualizado);

                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _controleEquipamentoRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
