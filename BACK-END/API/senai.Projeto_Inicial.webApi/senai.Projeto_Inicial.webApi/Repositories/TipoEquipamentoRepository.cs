using senai.Projeto_Inicial.webApi.Context;
using senai.Projeto_Inicial.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Projeto_Inicial.webApi.Repositories
{
    public class TipoEquipamentoRepository : ITipoEquipamentoRepository
    {
        ProjetoInicialContext ctx = new ProjetoInicialContext();
    }
}
