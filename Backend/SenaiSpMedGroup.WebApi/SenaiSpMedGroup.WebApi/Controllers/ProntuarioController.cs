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
    public class ProntuarioController :ControllerBase
    {
        private IProntuarioRepository _prontuarioRepository;

        public ProntuarioController()
        {
            _prontuarioRepository = new ProntuarioRepository();
        }

        /// <summary>
        /// Lista todas os Prontuarios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_prontuarioRepository.Listar());
        }

        /// <summary>
        /// Busca um Prontuario através do seu ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_prontuarioRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Cadastra um novo Prontuario
        /// </summary>
        /// <param name="novoProntuario"></param>
        /// <returns></returns>

        [HttpPost]
        public IActionResult Post(Prontuario novoProntuario)
        {
            _prontuarioRepository.Cadastrar(novoProntuario);
            return StatusCode(200);
        }

        /// <summary>
        /// Deleta um Prontuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _prontuarioRepository.Deletar(id);
            return StatusCode(200);
        }

        /// <summary>
        /// Atualiza um prontuario existente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="prontuario"></param>
        /// <returns></returns>

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Prontuario prontuario)
        {
            _prontuarioRepository.Atualizar(id, prontuario);
            return StatusCode(200);
        }
    }
}
