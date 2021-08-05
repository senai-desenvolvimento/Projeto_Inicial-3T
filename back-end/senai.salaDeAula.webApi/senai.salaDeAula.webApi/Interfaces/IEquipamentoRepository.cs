using senai.salaDeAula.webApi.Domains;
using System.Collections.Generic;

namespace senai.salaDeAula.webApi.Interfaces
{
    interface IEquipamentoRepository
    {
        List<Equipamento> Listar();

        Equipamento BuscarPorId(int id);

        void Cadastrar(Equipamento novoEquipamento);

        void AtualizarPorId(int id, Equipamento equipamentoAtualizado);

        void Deletar(int id);

        void AprovarRecusar(int id, string status);
    }
}
