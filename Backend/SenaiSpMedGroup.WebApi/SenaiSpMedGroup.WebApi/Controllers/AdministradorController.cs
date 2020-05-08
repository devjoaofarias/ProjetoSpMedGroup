using Microsoft.AspNetCore.Mvc;
using SenaiSpMedGroup.WebApi.Domains;
using SenaiSpMedGroup.WebApi.Interfaces;
using SenaiSpMedGroup.WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiSpMedGroup.WebApi.Controllers
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

             /// <summary>
             /// Lista todos os Administradores
             /// </summary>
             /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_administradorRepository.Listar());
        }

        /// <summary>
        /// Busca um Pacote através do seu ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_administradorRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Cadastra um novo Administrador
        /// </summary>
        /// <param name="novoPacote"></param>
        /// <returns></returns>
        
        [HttpPost]
        public IActionResult Post(Administrador novoAdministrador)
        {
            _administradorRepository.Cadastrar(novoAdministrador);
            return StatusCode(200);
        }

        /// <summary>
        /// Deleta um Pacote
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _administradorRepository.Deletar(id);
            return StatusCode(200);
        }

        /// <summary>
        /// Atualiza um Pacote existente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="administrador"></param>
        /// <returns></returns>
        
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Administrador administrador)
        {
            _administradorRepository.Atualizar(id, administrador);
            return StatusCode(200);
        }

    }
}

