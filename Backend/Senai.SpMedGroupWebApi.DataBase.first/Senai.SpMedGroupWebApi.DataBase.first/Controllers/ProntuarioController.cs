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
    public class ProntuarioController : ControllerBase
    {
        private IProntuarioRepository _prontuarioRepository;

        public ProntuarioController()
        {
            _prontuarioRepository = new ProntuarioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_prontuarioRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_prontuarioRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Post(Prontuario novoProntuario)
        {
            _prontuarioRepository.Cadastrar(novoProntuario);
            return StatusCode(200);
        }

        [HttpDelete("{id}")]
        public IActionResult Del(int id)
        {
            _prontuarioRepository.Deletar(id);
            return StatusCode(200);
        }
    }
}