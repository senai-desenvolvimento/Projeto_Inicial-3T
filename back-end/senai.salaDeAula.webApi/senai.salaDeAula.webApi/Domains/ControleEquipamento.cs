using System;

#nullable disable

namespace senai.salaDeAula.webApi.Domains
{
    public partial class ControleEquipamento
    {
        public int IdControleEquipamento { get; set; }
        public int? IdSala { get; set; }
        public int? IdEquipamento { get; set; }
        public DateTime? DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }

        public virtual Equipamento IdEquipamentoNavigation { get; set; }
        public virtual Sala IdSalaNavigation { get; set; }
    }
}
