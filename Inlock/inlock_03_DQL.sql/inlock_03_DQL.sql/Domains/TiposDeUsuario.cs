using System;
using System.Collections.Generic;

#nullable disable

namespace inlock_03_DQL.sql.Domains
{
    public partial class TiposDeUsuario
    {
        public TiposDeUsuario()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdTipoUsuario { get; set; }
        public string Titulo { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
