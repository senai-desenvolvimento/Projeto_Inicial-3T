using System.Collections.Generic;

#nullable disable

namespace senai.salaDeAula.webApi.Domains
{
    public partial class Equipamento
    {
        public Equipamento()
        {
            ControleEquipamentos = new HashSet<ControleEquipamento>();
        }

        public int IdEquipamento { get; set; }
        public string NomeEquipamento { get; set; }
        public string TipoEquipamento { get; set; }
        public string Marca { get; set; }
        public string NumeroDeSerie { get; set; }
        public string Descricao { get; set; }
        public string NumeroPatrimonio { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<ControleEquipamento> ControleEquipamentos { get; set; }
    }
}
