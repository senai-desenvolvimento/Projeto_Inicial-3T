using senai.salaDeAula.webApi.Contexts;
using senai.salaDeAula.webApi.Domains;
using senai.salaDeAula.webApi.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace senai.salaDeAula.webApi.Repositories
{
    public class SalaRepository : ISalaRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os metódos do EF Core
        /// </summary>
        SalaDeAula ctx = new SalaDeAula();

        public void AtualizarPorId(int id, Sala salaAtualizada)
        {
            Sala salaBuscada = ctx.Salas.Find(id);

            if(salaAtualizada.NomeSala != null)
            {
                salaBuscada.NomeSala = salaAtualizada.NomeSala;
            }
            if (salaAtualizada.Metragem != null)
            {
                salaBuscada.Metragem = salaAtualizada.Metragem;
            }
            if (salaAtualizada.Andar != null)
            {
                salaBuscada.Andar = salaAtualizada.Andar;
            }

            ctx.Update(salaBuscada);

            ctx.SaveChanges();
        }

        public Sala BuscarPorId(int id)
        {
            return ctx.Salas.FirstOrDefault(s => s.IdSala == id);
        }

        public void Cadastrar(Sala novaSala)
        {
            ctx.Salas.Add(novaSala);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Sala salaBuscada = ctx.Salas.FirstOrDefault(s => s.IdSala == id);

            ctx.Salas.Remove(salaBuscada);

            ctx.SaveChanges();
        }

        public List<Sala> Listar()
        {
            var salaBuscada = ctx.Salas.Select(s => new Sala()
            { 
                      IdSala = s.IdSala,

                      NomeSala = s.NomeSala,
                      
                      Metragem = s.Metragem,

                      Andar = s.Andar
            });

            return salaBuscada.ToList();
        }
    }
}
