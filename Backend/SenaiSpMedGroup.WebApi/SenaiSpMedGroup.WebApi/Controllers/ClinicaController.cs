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

    public class ClinicaController : ControllerBase
    {
        private IClinicaRepository _clinicaRepository;

        public ClinicaController()
        {
            _clinicaRepository = new ClinicaRepository();
        }

        /// <summary>
        /// Lista todas as Clinicas
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_clinicaRepository.Listar());
        }

        /// <summary>
        /// Busca uma Clinica através do seu ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_clinicaRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Cadastra uma nova Clinica
        /// </summary>
        /// <param name="novaClinica"></param>
        /// <returns></returns>

        [HttpPost]
        public IActionResult Post(Clinica novaClinica)
        {
            _clinicaRepository.Cadastrar(novaClinica);
            return StatusCode(200);
        }

        /// <summary>
        /// Deleta uma clinica
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _clinicaRepository.Deletar(id);
            return StatusCode(200);
        }

        /// <summary>
        /// Atualiza uma clinica existente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="clinica"></param>
        /// <returns></returns>

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Clinica clinica)
        {
            _clinicaRepository.Atualizar(id, clinica);
            return StatusCode(200);
        }
    }
}
