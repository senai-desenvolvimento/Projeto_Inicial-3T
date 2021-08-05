using senai.Projeto_Inicial.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Projeto_Inicial.webApi.Interfaces
{
    interface IEquipamentoRepository
    {
        List<Equipamento> Listar();

        Equipamento BuscarPorId(int id);

        Equipamento Cadastrar(Equipamento novoEquipamento);

        void Atualizar(int id, Equipamento equipamentoAtualizado);

        void Deletar(int id);
    }
}
