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
    public class MedicoController : ControllerBase
    {
        private IMedicoRepository _medicoRepository;

        public MedicoController()
        {
            _medicoRepository = new MedicoRepository();
        }

        /// <summary>
        /// Lista todas os Medicos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_medicoRepository.Listar());
        }

        /// <summary>
        /// Busca um Medico através do seu ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_medicoRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Cadastra um novo Medico
        /// </summary>
        /// <param name="novoMedico"></param>
        /// <returns></returns>

        [HttpPost]
        public IActionResult Post(Medico novoMedico)
        {
            _medicoRepository.Cadastrar(novoMedico);
            return StatusCode(200);
        }

        /// <summary>
        /// Deleta um Medico
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _medicoRepository.Deletar(id);
            return StatusCode(200);
        }

        /// <summary>
        /// Atualiza um medico existente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="medico"></param>
        /// <returns></returns>

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Medico medico)
        {
            _medicoRepository.Atualizar(id, medico);
            return StatusCode(200);
        }
    }
}
