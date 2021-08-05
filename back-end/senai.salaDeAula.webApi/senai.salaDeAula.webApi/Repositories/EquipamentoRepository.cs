using Google.Rpc;
using senai.salaDeAula.webApi.Contexts;
using senai.salaDeAula.webApi.Domains;
using senai.salaDeAula.webApi.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace senai.salaDeAula.webApi.Repositories
{
    public class EquipamentoRepository : IEquipamentoRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os metódos do EF Core
        /// </summary>
        SalaDeAula ctx = new SalaDeAula();

        public void AprovarRecusar(int id, string status)
        {
            Equipamento equipamentoBuscado = ctx.Equipamentos.FirstOrDefault(c => c.IdEquipamento == id);

                if(status == "0")
                {
                    equipamentoBuscado.Estado = "0";
                }

                if (status == "1")
                {
                    equipamentoBuscado.Estado = "1";
                }

            ctx.Equipamentos.Update(equipamentoBuscado);

            ctx.SaveChanges();
        }

        public void AtualizarPorId(int id, Equipamento equipamentoAtualizado)
        {
            Equipamento equipamentoBuscado = ctx.Equipamentos.Find(id);

            if (equipamentoAtualizado.NomeEquipamento != null)
            {
                equipamentoBuscado.NomeEquipamento = equipamentoAtualizado.NomeEquipamento;
            }
            if (equipamentoAtualizado.TipoEquipamento != null)
            {
                equipamentoBuscado.TipoEquipamento = equipamentoAtualizado.TipoEquipamento;
            }
            if (equipamentoAtualizado.Marca != null)
            {
                equipamentoBuscado.Marca = equipamentoAtualizado.Marca;
            }
            if (equipamentoAtualizado.NumeroDeSerie != null)
            {
                equipamentoBuscado.NumeroDeSerie = equipamentoAtualizado.NumeroDeSerie;
            }
            if (equipamentoAtualizado.Descricao != null)
            {
                equipamentoBuscado.Descricao = equipamentoAtualizado.Descricao;
            }
            if (equipamentoAtualizado.NumeroPatrimonio != null)
            {
                equipamentoBuscado.NumeroPatrimonio = equipamentoAtualizado.NumeroPatrimonio;
            }
            if (equipamentoAtualizado.Estado != null)
            {
                equipamentoBuscado.Estado = equipamentoAtualizado.Estado;
            }

            ctx.Update(equipamentoBuscado);

            ctx.SaveChanges();
        }

        public Equipamento BuscarPorId(int id)
        {
            return ctx.Equipamentos.FirstOrDefault(u => u.IdEquipamento == id);
        }

        public void Cadastrar(Equipamento novoEquipamento)
        {
            ctx.Equipamentos.Add(novoEquipamento);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Equipamento equipamentoBuscado = ctx.Equipamentos.FirstOrDefault(e => e.IdEquipamento == id);

            ctx.Equipamentos.Remove(equipamentoBuscado);

            ctx.SaveChanges();
        }

        public List<Equipamento> Listar()
        {
            return ctx.Equipamentos.Select(e => new Equipamento() 
            { 
                IdEquipamento = e.IdEquipamento,

                NomeEquipamento = e.NomeEquipamento,

                TipoEquipamento = e.TipoEquipamento,

                Marca = e.Marca,

                NumeroDeSerie = e.NumeroDeSerie,

                Descricao = e.Descricao,

                NumeroPatrimonio = e.NumeroPatrimonio,

                Estado = e.Estado

            }).ToList();
        }

    }
}
