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
    public class AdministradorController : ControllerBase
    {
        private IAdministradorRepository _administradorRepository;

        public AdministradorController()
        {
            _administradorRepository = new AdministradorRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_administradorRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_administradorRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Post(Administrador novoAdministrador)
        {
            _administradorRepository.Cadastrar(novoAdministrador);
            return StatusCode(200);
        }

        [HttpDelete("{id}")]
        public IActionResult Del(int id)
        {
            _administradorRepository.Deletar(id);
            return StatusCode(200);
        }
    }
}
