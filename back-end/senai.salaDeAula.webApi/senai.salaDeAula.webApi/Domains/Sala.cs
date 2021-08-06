using System.Collections.Generic;

#nullable disable

namespace senai.salaDeAula.webApi.Domains
{
    public partial class Sala
    {
        public Sala()
        {
            ControleEquipamentos = new HashSet<ControleEquipamento>();
        }

        public int IdSala { get; set; }
        public string NomeSala { get; set; }
        public string Metragem { get; set; }
        public string Andar { get; set; }

        public virtual ICollection<ControleEquipamento> ControleEquipamentos { get; set; }
    }
}
