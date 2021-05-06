using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.spmedgroup.wepApi.Domains;
using senai.spmedgroup.wepApi.Interfaces;
using senai.spmedgroup.wepApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.wepApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaController : ControllerBase
    {
        private IConsultaRepository ConsultaRepository{get; set;}

        public ConsultaController()
        {
            ConsultaRepository = new ConsultaRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(ConsultaRepository.Listar());
            }
            catch (Exception erro)
            {

                return BadRequest(erro);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(ConsultaRepository.BuscarPorId(id));
            }
            catch (Exception erro)
            {

                return BadRequest(erro);
            }

        }

        [HttpPost]
        public IActionResult Post(Consulta novaConsulta)
        {
            try
            {
                ConsultaRepository.Cadastrar(novaConsulta);
                return StatusCode(201);
            }
            catch (Exception ex)
            {

                return BadRequest (ex);
            }

        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Consulta ConsultaAtualizada)
        {
            try
            {
                ConsultaRepository.Atualizar(id, ConsultaAtualizada);
                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }



    }
}
