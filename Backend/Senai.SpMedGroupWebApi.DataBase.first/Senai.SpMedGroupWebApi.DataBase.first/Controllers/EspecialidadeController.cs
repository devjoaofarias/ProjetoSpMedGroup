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
    public class EspecialidadeController : ControllerBase
    {
        private IEspecialidadeRepository _especialidadeRepository;

        public EspecialidadeController()
        {
            _especialidadeRepository = new EspecialidadeRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_especialidadeRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_especialidadeRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Post(Especialidade novaEspecialidade)
        {
            _especialidadeRepository.Cadastrar(novaEspecialidade);
            return StatusCode(200);
        }

        [HttpDelete("{id}")]
        public IActionResult Del(int id)
        {
            _especialidadeRepository.Deletar(id);
            return StatusCode(200);
        }
    }
}