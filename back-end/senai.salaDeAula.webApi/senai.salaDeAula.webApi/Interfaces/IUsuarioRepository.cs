using senai.salaDeAula.webApi.Domains;
using System.Collections.Generic;

namespace senai.salaDeAula.webApi.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> Listar();

        Usuario BuscarPorId(int id);

        void Cadastrar(Usuario novoUsuario);

        void AtualizarPorId(int id, Usuario usuarioAtualizado);

        Usuario BuscarPorEmailSenha(string email, string senha);

        void Deletar(int id);
    }
}
