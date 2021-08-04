using System;
using System.Collections.Generic;

#nullable disable

namespace senai.Projeto_Inicial.webApi.Domains
{
    public partial class TiposUsuario
    {
        public TiposUsuario()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdTipoUsuario { get; set; }
        public string Permissao { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
