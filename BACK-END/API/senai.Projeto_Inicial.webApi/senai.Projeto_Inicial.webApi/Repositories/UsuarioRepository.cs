using Microsoft.EntityFrameworkCore;
using senai.Projeto_Inicial.webApi.Context;
using senai.Projeto_Inicial.webApi.Domains;
using senai.Projeto_Inicial.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Projeto_Inicial.webApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        ProjetoInicialContext ctx = new ProjetoInicialContext();

        /// <summary>
        /// Atualiza usuario
        /// </summary>
        /// <param name="usuario">usuario a ser atualizado</param>
        public void Atualizar(Usuario usuario)
        {
            Usuario usuarioAntigo = ctx.Usuarios.Find(usuario.IdUsuario);

            usuarioAntigo.Senha = usuario.Senha;

            ctx.Usuarios.Update(usuarioAntigo);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Cria usuario
        /// </summary>
        /// <param name="usuario">Usuario a ser criado</param>
        public void Criar(Usuario usuario)
        {
            ctx.Usuarios.Add(usuario);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Exclui usuario
        /// </summary>
        /// <param name="id">id do usuario a ser excluido</param>
        public void Excluir(int id)
        {
            Usuario usuario = ctx.Usuarios.Find(id);

            ctx.Usuarios.Remove(usuario);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Lista usuarios
        /// </summary>
        /// <returns>Lista de Usuarios</returns>
        public List<Usuario> Listar()
        {
            return ctx.Usuarios.Include(x => x.IdTipoUsuarioNavigation).ToList();
        }

        /// <summary>
        /// Verifica se email e senha do usuario estao corretos
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public Usuario Login(string email, string senha)
        {
            Usuario usuario = ctx.Usuarios.FirstOrDefault(x => x.Email == email && x.Senha == senha);

            return usuario;
        }
    }
}
