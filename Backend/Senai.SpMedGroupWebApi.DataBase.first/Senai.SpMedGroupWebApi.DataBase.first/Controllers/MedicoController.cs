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
    public class MedicoController : ControllerBase
    { 
    private IMedicoRepository _medicoRepository;

    public MedicoController()
    {
        _medicoRepository = new MedicoRepository();
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_medicoRepository.Listar());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok(_medicoRepository.BuscarPorId(id));
    }

    [HttpPost]
    public IActionResult Post(Medico novoMedico)
    {
        _medicoRepository.Cadastrar(novoMedico);
        return StatusCode(200);
    }

    [HttpDelete("{id}")]
    public IActionResult Del(int id)
    {
        _medicoRepository.Deletar(id);
        return StatusCode(200);
    }
    }
}
