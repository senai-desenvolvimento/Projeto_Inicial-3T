using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class TipoEquipamentoController : ControllerBase
    {

        private ITipoEquipamentoRepository _tipoEquipamentoRepository { get; set; }
        public TipoEquipamentoController()
        {
            _tipoEquipamentoRepository = new TipoEquipamentoRepository();
        }

        //[Authorize(Roles= "1")]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_tipoEquipamentoRepository.Listar().OrderBy(c => c.IdTipoEquipamento));
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
    }
}
