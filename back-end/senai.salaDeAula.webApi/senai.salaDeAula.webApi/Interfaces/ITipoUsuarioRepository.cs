using senai.salaDeAula.webApi.Domains;
using System.Collections.Generic;

namespace senai.salaDeAula.webApi.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TipoUsuario> Listar();

        TipoUsuario BuscarPorId(int id);

        void Cadastrar(TipoUsuario novoTipoUsuario);

        void AtualizarPorId(int id, TipoUsuario tipoUsuarioAtualizado);

        void Deletar(int id);
    }
}
