using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Projeto_Inicial.webApi.DTO
{
    public class EquipamentoSalaDTO
    {
        public int? IdTipoEquipamento { get; set; }
        public string NomeEquipamento { get; set; }
        public string NomeMarca { get; set; }
        public string Descricao { get; set; }
        public string NumeroPatrimonio { get; set; }
        public string NumeroSerie { get; set; }
        public bool Situacao { get; set; }

        public int? IdSala { get; set; }
        public int? IdEquipamento { get; set; }
        public DateTime DataEntrada { get; set; }
    }
}
