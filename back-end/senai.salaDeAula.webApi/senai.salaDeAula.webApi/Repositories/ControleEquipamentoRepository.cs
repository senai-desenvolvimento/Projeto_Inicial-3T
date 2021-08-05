using Microsoft.EntityFrameworkCore;
using senai.salaDeAula.webApi.Contexts;
using senai.salaDeAula.webApi.Domains;
using senai.salaDeAula.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.salaDeAula.webApi.Repositories
{
    public class ControleEquipamentoRepository : IControleEquipamentoRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os metódos do EF Core
        /// </summary>
        SalaDeAula ctx = new SalaDeAula();

        public void AtualizarPorId(int id, ControleEquipamento controleEquipamentoAtualizado)
        {
            ControleEquipamento controleEquipamentoBuscado = ctx.ControleEquipamentos.Find(id);

            if(controleEquipamentoAtualizado.IdSala != null)
            {
                controleEquipamentoBuscado.IdSala = controleEquipamentoAtualizado.IdSala;
            }
            if (controleEquipamentoAtualizado.IdEquipamento != null)
            {
                controleEquipamentoBuscado.IdEquipamento = controleEquipamentoAtualizado.IdEquipamento;
            }
            if (controleEquipamentoAtualizado.DataEntrada != null)           
            {
                controleEquipamentoBuscado.DataEntrada = controleEquipamentoAtualizado.DataEntrada;
            }
            if (controleEquipamentoAtualizado.DataSaida != null)
            {
                controleEquipamentoBuscado.DataSaida = controleEquipamentoAtualizado.DataSaida;
            }

            ctx.Update(controleEquipamentoBuscado);

            ctx.SaveChanges();
        }

        public ControleEquipamento BuscarPorId(int id)
        {
            return ctx.ControleEquipamentos.FirstOrDefault(u => u.IdControleEquipamento == id);
        }

        public void Cadastrar(ControleEquipamento novoControleEquipamento)
        {
            ctx.ControleEquipamentos.Add(novoControleEquipamento);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ControleEquipamento controleEquipamentoBuscado = ctx.ControleEquipamentos.FirstOrDefault(u => u.IdControleEquipamento == id);

            ctx.ControleEquipamentos.Remove(controleEquipamentoBuscado);

            ctx.SaveChanges();
        }

        public List<ControleEquipamento> Listar()
        {
            return ctx.ControleEquipamentos.Include(ce => ce.IdEquipamentoNavigation)
                                           .Include(ce => ce.IdSalaNavigation)
                                           .Select(ce => new ControleEquipamento() 
           {

           IdControleEquipamento = ce.IdControleEquipamento,

           IdSala = ce.IdSala,

           IdEquipamento = ce.IdEquipamento,

           DataEntrada = ce.DataEntrada,

           DataSaida = ce.DataSaida,

           IdEquipamentoNavigation = new Equipamento()
           {
               IdEquipamento = ce.IdEquipamentoNavigation.IdEquipamento,

               NomeEquipamento = ce.IdEquipamentoNavigation.NomeEquipamento,

               TipoEquipamento = ce.IdEquipamentoNavigation.TipoEquipamento,

               Marca = ce.IdEquipamentoNavigation.Marca,

               NumeroDeSerie = ce.IdEquipamentoNavigation.NumeroDeSerie,

               Descricao = ce.IdEquipamentoNavigation.Descricao,

               NumeroPatrimonio = ce.IdEquipamentoNavigation.NumeroPatrimonio,

               Estado = ce.IdEquipamentoNavigation.Estado
           },

           IdSalaNavigation = new Sala()
           {
               IdSala = ce.IdSalaNavigation.IdSala,

               NomeSala = ce.IdSalaNavigation.NomeSala,

               Metragem = ce.IdSalaNavigation.Metragem,

               Andar = ce.IdSalaNavigation.Andar
               
           }}).ToList();
        }
    }
}
