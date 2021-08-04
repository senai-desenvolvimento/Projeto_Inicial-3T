using senai.Projeto_Inicial.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Projeto_Inicial.webApi.Interfaces
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Cria usuario
        /// </summary>
        /// <param name="usuario">Usuario a ser criado</param>
        void Criar(Usuario usuario);

        /// <summary>
        /// Lista usuarios
        /// </summary>
        /// <returns>Lista de Usuarios</returns>
        List<Usuario> Listar();

        /// <summary>
        /// Atualiza usuario
        /// </summary>
        /// <param name="usuario">usuario a ser atualizado</param>
        void Atualizar(Usuario usuario);

        /// <summary>
        /// Exclui usuario
        /// </summary>
        /// <param name="id">id do usuario a ser excluido</param>
        void Excluir(int id);

        /// <summary>
        /// Verifica se email e senha do usuario estao corretos
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        Usuario Login(string email, string senha);
    }
}
