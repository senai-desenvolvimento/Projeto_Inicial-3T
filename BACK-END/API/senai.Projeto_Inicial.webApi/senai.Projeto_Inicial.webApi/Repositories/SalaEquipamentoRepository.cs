﻿using Microsoft.EntityFrameworkCore;
using senai.Projeto_Inicial.webApi.Context;
using senai.Projeto_Inicial.webApi.Domains;
using senai.Projeto_Inicial.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Projeto_Inicial.webApi.Repositories
{
    public class SalaEquipamentoRepository : ISalaEquipamentoRepository
    {
        ProjetoInicialContext ctx = new ProjetoInicialContext();

        public void Atualizar(SalasEquipamento salasEquipamentoAtualizado)
        {
            SalasEquipamento equipamentoBuscado = ctx.SalasEquipamentos.FirstOrDefault(c => c.IdEquipamento == salasEquipamentoAtualizado.IdEquipamento && c.DataSaida == null);

            equipamentoBuscado.DataSaida = DateTime.Now;

            ctx.SalasEquipamentos.Update(equipamentoBuscado);

            ctx.SaveChanges();
        }

        public void Cadastrar(SalasEquipamento novaTransferencia)
        {
            novaTransferencia.DataEntrada = DateTime.Now;

            ctx.SalasEquipamentos.Add(novaTransferencia);

            ctx.SaveChanges();
        }

        public List<SalasEquipamento> Listar()
        {
            return ctx.SalasEquipamentos.ToList();
        }

        public IEnumerable<SalasEquipamento> ListarEquipamentosNaSala(int idSala)
        {
            return ctx.SalasEquipamentos
                .Where(e => e.IdSala == idSala && e.DataSaida == null)
                .Select(e => new SalasEquipamento() 
                { 
                    DataEntrada = e.DataEntrada,

                    IdEquipamentoNavigation = new Equipamento()
                    {
                        IdEquipamento = e.IdEquipamentoNavigation.IdEquipamento,
                        NomeEquipamento = e.IdEquipamentoNavigation.NomeEquipamento,
                        NomeMarca = e.IdEquipamentoNavigation.NomeMarca,
                        Descricao = e.IdEquipamentoNavigation.Descricao,
                        NumeroPatrimonio = e.IdEquipamentoNavigation.NumeroPatrimonio,
                        NumeroSerie = e.IdEquipamentoNavigation.NumeroSerie,
                        Situacao = e.IdEquipamentoNavigation.Situacao,

                        IdTipoEquipamentoNavigation = new TiposEquipamento()
                        {
                            Titulo = e.IdEquipamentoNavigation.IdTipoEquipamentoNavigation.Titulo
                        }
                    }
                });
        }

        public List<SalasEquipamento> ListarEquipamentos()
        {
            return ctx.SalasEquipamentos
                .Where(e => e.DataSaida == null)
                .Select(e => new SalasEquipamento()
                {
                    DataEntrada = e.DataEntrada,

                    IdEquipamentoNavigation = new Equipamento()
                    {
                        IdEquipamento = e.IdEquipamentoNavigation.IdEquipamento,
                        NomeEquipamento = e.IdEquipamentoNavigation.NomeEquipamento,
                        NomeMarca = e.IdEquipamentoNavigation.NomeMarca,
                        Descricao= e.IdEquipamentoNavigation.Descricao,
                        NumeroPatrimonio = e.IdEquipamentoNavigation.NumeroPatrimonio,
                        NumeroSerie = e.IdEquipamentoNavigation.NumeroSerie,
                        Situacao = e.IdEquipamentoNavigation.Situacao,

                        IdTipoEquipamentoNavigation = new TiposEquipamento()
                        {
                            Titulo = e.IdEquipamentoNavigation.IdTipoEquipamentoNavigation.Titulo
                        }
                    },

                    IdSalaNavigation = new Sala()
                    {
                        NomeSala = e.IdSalaNavigation.NomeSala
                    }
                })
                .ToList();
        }
    }
}
