﻿using senai.Projeto_Inicial.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Projeto_Inicial.webApi.Interfaces
{
    interface ITipoEquipamentoRepository
    {
        List<TiposEquipamento> Listar();
    }
}
