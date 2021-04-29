using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi.Domains
{
    public partial class Personagem
    {
        public int IdPersonagem { get; set; }
        public string Nome { get; set; }
        public string Classe { get; set; }
        public string Vida { get; set; }
        public string Mana { get; set; }
        public string DataAtual { get; set; }
        public string DataDeCriacao { get; set; }
    }
}
