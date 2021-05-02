using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Peoples.WebApi.Domains;
using Senai.Peoples.WebApi.Interfaces;
using Senai.Peoples.WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Controlles
{
    [Produces ("aplication/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {

        private IFuncionarioRepository _funcionarioRepository { get; set; }

        public FuncionariosController()
        {
            _funcionarioRepository = new FuncionarioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<FuncionarioDomain> funcionarios = _funcionarioRepository.ListarTodos();

            return Ok(funcionarios);
        }
    }
}
