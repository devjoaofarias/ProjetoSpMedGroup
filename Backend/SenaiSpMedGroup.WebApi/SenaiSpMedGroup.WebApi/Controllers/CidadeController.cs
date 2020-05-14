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
    public class CidadeController : ControllerBase
    {

        private ICidadeRepository _cidadeRepository;

        public CidadeController()
        {
            _cidadeRepository = new CidadeRepository();
        }

        /// <summary>
        /// Lista todas as Cidades
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_cidadeRepository.Listar());
        }

        /// <summary>
        /// Busca uma Cidade através do seu ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_cidadeRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Cadastra um nova Cidade
        /// </summary>
        /// <param name="novaCidade"></param>
        /// <returns></returns>

        [HttpPost]
        public IActionResult Post(Cidade novaCidade)
        {
            _cidadeRepository.Cadastrar(novaCidade);
            return StatusCode(200);
        }

        /// <summary>
        /// Deleta uma cidade
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _cidadeRepository.Deletar(id);
            return StatusCode(200);
        }

        /// <summary>
        /// Atualiza uma cidade existente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cidade"></param>
        /// <returns></returns>

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Cidade cidade)
        {
            _cidadeRepository.Atualizar(id, cidade);
            return StatusCode(200);
        }
    }
}
