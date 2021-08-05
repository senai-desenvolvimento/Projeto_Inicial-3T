using System;
using System.Collections.Generic;

#nullable disable

namespace senai.Projeto_Inicial.webApi.Domains
{
    public partial class Sala
    {
        public int IdSala { get; set; }
        public string NomeSala { get; set; }
        public decimal? Andar { get; set; }
        public double? Metragem { get; set; }
    }
}
