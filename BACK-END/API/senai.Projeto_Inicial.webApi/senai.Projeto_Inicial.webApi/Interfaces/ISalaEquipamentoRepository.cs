﻿using senai.Projeto_Inicial.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Projeto_Inicial.webApi.Interfaces
{
    interface ISalaEquipamentoRepository
    {
        List<SalasEquipamento> Listar();

        void Cadastrar(SalasEquipamento novoEquipamento);

        void Atualizar(SalasEquipamento salasEquipamentoAtualizado);

        IEnumerable<SalasEquipamento> ListarEquipamentosNaSala(int idSala);

        List<SalasEquipamento> ListarEquipamentos();
    }
}
