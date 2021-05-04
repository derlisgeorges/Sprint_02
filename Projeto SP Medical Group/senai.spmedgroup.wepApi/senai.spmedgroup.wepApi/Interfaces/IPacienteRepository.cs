﻿using senai.spmedgroup.wepApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.wepApi.Interfaces
{
    interface IPacienteRepository
    {
        
        List<Paciente> Listar();

  
        Paciente BuscarPorId(int id);


        void Cadastrar(Paciente novoPaciente);

        void Atualizar(int id, Paciente pacienteAtualizado);


        void Deletar(int id);
    }
}
