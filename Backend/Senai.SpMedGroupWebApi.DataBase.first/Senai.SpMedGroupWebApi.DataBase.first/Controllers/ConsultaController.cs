using Microsoft.AspNetCore.Mvc;
using Senai.SpMedGroupWebApi.DataBase.first.Domains;
using Senai.SpMedGroupWebApi.DataBase.first.Interfaces;
using Senai.SpMedGroupWebApi.DataBase.first.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedGroupWebApi.DataBase.first.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaController : ControllerBase
    {
        private IConsultaRepository _consultaRepository;

        public ConsultaController()
        {
            _consultaRepository = new ConsultaRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_consultaRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_consultaRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Post(Consulta novaConsulta)
        {
            _consultaRepository.Cadastrar(novaConsulta);
            return StatusCode(200);
        }

        [HttpDelete("{id}")]
        public IActionResult Del(int id)
        {
            _consultaRepository.Deletar(id);
            return StatusCode(200);
        }
    }
}