using SenaiSpMedGroup.WebApi.Domains;
using SenaiSpMedGroup.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiSpMedGroup.WebApi.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        SpMedGroupContext ctx = new SpMedGroupContext();
        public void Atualizar(int id, Consulta consulta)
        {
            throw new NotImplementedException();
        }

        public Consulta BuscarPorId(int id)
        {
            return ctx.Consulta.FirstOrDefault(e => e.IdConsulta == id);
        }

        public void Cadastrar(Consulta novaConsulta)
        {
            ctx.Consulta.Add(novaConsulta);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Consulta consultaApagada = new Consulta();
            consultaApagada = BuscarPorId(id);
            ctx.Consulta.Remove(consultaApagada);
            ctx.SaveChanges();
        }

        public List<Consulta> Listar()
        {
            return ctx.Consulta.ToList();
        }
    }
}

