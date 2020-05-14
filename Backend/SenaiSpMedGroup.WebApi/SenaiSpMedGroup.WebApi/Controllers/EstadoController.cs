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
    public class EstadoController : ControllerBase
    {
        private IEstadoRepository _estadoRepository;

        public EstadoController()
        {
            _estadoRepository = new EstadoRepository();
        }

        /// <summary>
        /// Lista todas os Estados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_estadoRepository.Listar());
        }

        /// <summary>
        /// Busca um Estado através do seu ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_estadoRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Cadastra um novo Estado
        /// </summary>
        /// <param name="novoEstado"></param>
        /// <returns></returns>

        [HttpPost]
        public IActionResult Post(Estado novoEstado)
        {
            _estadoRepository.Cadastrar(novoEstado);
            return StatusCode(200);
        }

        /// <summary>
        /// Deleta um Estado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _estadoRepository.Deletar(id);
            return StatusCode(200);
        }

        /// <summary>
        /// Atualiza um estado existente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="estado"></param>
        /// <returns></returns>

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Estado estado)
        {
            _estadoRepository.Atualizar(id, estado);
            return StatusCode(200);
        }
    }
}
