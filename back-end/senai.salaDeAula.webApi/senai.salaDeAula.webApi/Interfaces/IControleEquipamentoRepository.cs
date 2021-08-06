using senai.salaDeAula.webApi.Domains;
using System.Collections.Generic;

namespace senai.salaDeAula.webApi.Interfaces
{
    interface IControleEquipamentoRepository
    {
        List<ControleEquipamento> Listar();

        ControleEquipamento BuscarPorId(int id);

        void Cadastrar(ControleEquipamento novoControleEquipamento);

        void AtualizarPorId(int id, ControleEquipamento controleEquipamentoAtualizado);

        void Deletar(int id);
    }
}
