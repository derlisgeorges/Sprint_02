﻿using System;
using System.Collections.Generic;

#nullable disable

namespace senai.spmedgroup.wepApi.Domains
{
    public partial class Especialidade
    {
        public Especialidade()
        {
            Medicos = new HashSet<Medico>();
        }

        public int IdEspecialidade { get; set; }
        public string NomeEspecialide { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
