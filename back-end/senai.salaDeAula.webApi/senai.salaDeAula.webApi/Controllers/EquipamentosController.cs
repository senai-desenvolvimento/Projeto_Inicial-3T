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
    //ex: http://localhost:5000/api/equipamentos
    [Route("api/[controller]")]

    //Define que é um controlador de API
    [ApiController]
    public class EquipamentosController : ControllerBase
    {
        private IEquipamentoRepository _equipamentoRepository { get; set; }

        public EquipamentosController()
        {
            _equipamentoRepository = new EquipamentoRepository();
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Equipamento status)
        {
            try 
            {
                if (status.Estado == "0" || status.Estado == "1")
                {
                    _equipamentoRepository.AprovarRecusar(id, status.Estado);
                    
                    return StatusCode(204);
                }
                
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
