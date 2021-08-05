using System;
using System.Collections.Generic;

#nullable disable

namespace senai.Projeto_Inicial.webApi.Domains
{
    public partial class Equipamento
    {
        public int IdEquipamento { get; set; }
        public int? IdTipoEquipamento { get; set; }
        public string NomeEquipamento { get; set; }
        public string NomeMarca { get; set; }
        public string Descricao { get; set; }
        public string NumeroPatrimonio { get; set; }
        public string NumeroSerie { get; set; }
        public bool Situacao { get; set; }

        public virtual TiposEquipamento IdTipoEquipamentoNavigation { get; set; }
    }
}
