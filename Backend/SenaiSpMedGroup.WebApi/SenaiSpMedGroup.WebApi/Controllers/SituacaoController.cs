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
    public class SituacaoController : ControllerBase
    {
        private ISituacaoRepository _situacaoRepository;

        public SituacaoController()
        {
            _situacaoRepository = new SituacaoRepository();
        }

        /// <summary>
        /// Lista todas as Situações
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_situacaoRepository.Listar());
        }

        /// <summary>
        /// Busca uma Situação através do seu ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_situacaoRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Cadastra uma nova Situação
        /// </summary>
        /// <param name="novaSituacao"></param>
        /// <returns></returns>

        [HttpPost]
        public IActionResult Post(Situacao novaSituacao)
        {
            _situacaoRepository.Cadastrar(novaSituacao);
            return StatusCode(200);
        }

        /// <summary>
        /// Deleta uma situação
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _situacaoRepository.Deletar(id);
            return StatusCode(200);
        }

        /// <summary>
        /// Atualiza uma situação existente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="situacao"></param>
        /// <returns></returns>

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Situacao situacao)
        {
            _situacaoRepository.Atualizar(id, situacao);
            return StatusCode(200);
        }
    }
}
