﻿using System;
using System.Collections.Generic;

#nullable disable

namespace senai.Projeto_Inicial.webApi.Domains
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public int? IdTipoUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual TiposUsuario IdTipoUsuarioNavigation { get; set; }
    }
}
