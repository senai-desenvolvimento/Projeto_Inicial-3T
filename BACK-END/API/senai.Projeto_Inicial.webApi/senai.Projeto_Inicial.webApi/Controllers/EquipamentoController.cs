using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.Projeto_Inicial.webApi.Domains;
using senai.Projeto_Inicial.webApi.DTO;
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
        private ISalaEquipamentoRepository _salaEquipamentoRepository { get; set; }
        
        public EquipamentoController()
        {
            _equipamentoRepository = new EquipamentoRepository();

            _salaEquipamentoRepository = new SalaEquipamentoRepository();
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
        public IActionResult Post(EquipamentoSalaDTO novoEquipamentoDTO)
        {
            try
            {
                var novoEquipamento = new Equipamento
                {
                    IdTipoEquipamento = novoEquipamentoDTO.IdTipoEquipamento,
                    NomeEquipamento = novoEquipamentoDTO.NomeEquipamento,
                    NomeMarca = novoEquipamentoDTO.NomeMarca,
                    Descricao = novoEquipamentoDTO.Descricao,
                    NumeroPatrimonio = novoEquipamentoDTO.NumeroPatrimonio,
                    NumeroSerie = novoEquipamentoDTO.NumeroSerie,
                    Situacao = novoEquipamentoDTO.Situacao
                };

                 novoEquipamento = _equipamentoRepository.Cadastrar(novoEquipamento);

                var novaSalaEquipamento = new SalasEquipamento
                {
                    IdSala = novoEquipamentoDTO.IdSala,
                    IdEquipamento = novoEquipamento.IdEquipamento,
                    DataEntrada = DateTime.Now
                };

                _salaEquipamentoRepository.Cadastrar(novaSalaEquipamento);
                 
                return StatusCode(201);
            }
            catch (Exception codErro)
            {
                return BadRequest(codErro);

            }

        }

        //[Authorize]
        [HttpPut("{id}")]
        public IActionResult Put(int id, Equipamento equipamentoAtualizado)
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
                _salaEquipamentoRepository.DeletarEquipamento(id);
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
