using System;
using System.Collections.Generic;

#nullable disable

namespace senai.inlock.webApi.Domains
{
    public partial class Jogo
    {
        public int IdJogo { get; set; }
        public int? IdEstudio { get; set; }
        public string NomeJogo { get; set; }
        public string Descricao { get; set; }
        public string DataLancamento { get; set; }
        public string Valor { get; set; }

        public virtual Estudio IdEstudioNavigation { get; set; }
    }
}
