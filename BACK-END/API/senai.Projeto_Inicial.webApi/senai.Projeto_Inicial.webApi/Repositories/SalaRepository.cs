using senai.Projeto_Inicial.webApi.Context;
using senai.Projeto_Inicial.webApi.Domains;
using senai.Projeto_Inicial.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Projeto_Inicial.webApi.Repositories
{
    public class SalaRepository : ISalaRepository
    {
        ProjetoInicialContext ctx = new ProjetoInicialContext();

        /// <summary>
        /// Atualiza sala
        /// </summary>
        /// <param name="sala">sala a ser atualizada</param>
        public void Atualizar(Sala sala)
        {
            Sala salaAntiga = ctx.Salas.Find(sala.IdSala);

            salaAntiga = sala;

            ctx.Salas.Update(salaAntiga);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Cria sala
        /// </summary>
        /// <param name="sala">Sala a ser criada</param>
        public void Criar(Sala sala)
        {
            ctx.Salas.Add(sala);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Exclui sala
        /// </summary>
        /// <param name="id">id do sala a ser excluida</param>
        public void Excluir(int id)
        {
            Sala sala = ctx.Salas.Find(id);

            ctx.Salas.Remove(sala);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Lista salas
        /// </summary>
        /// <returns>Lista de Salas</returns>
        public List<Sala> Listar()
        {
            return ctx.Salas.ToList();
        }
    }
}
