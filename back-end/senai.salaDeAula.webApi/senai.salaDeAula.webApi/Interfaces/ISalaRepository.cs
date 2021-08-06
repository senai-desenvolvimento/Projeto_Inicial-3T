using senai.salaDeAula.webApi.Domains;
using System.Collections.Generic;

namespace senai.salaDeAula.webApi.Interfaces
{
    interface ISalaRepository
    {
        List<Sala> Listar();

        Sala BuscarPorId(int id);

        void Cadastrar(Sala novaSala);

        void AtualizarPorId(int id, Sala salaAtualizada);

        void Deletar(int id);
    }
}
