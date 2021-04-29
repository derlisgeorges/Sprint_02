using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi.Domains
{
    public partial class Habilidade
    {
        public int IdHabilidades { get; set; }
        public int? IdTipoHabilidades { get; set; }
        public string Descricao { get; set; }

        public virtual TiposDeHabilidade IdTipoHabilidadesNavigation { get; set; }
    }
}
