using SenaiSpMedGroup.WebApi.Domains;
using SenaiSpMedGroup.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiSpMedGroup.WebApi.Repositories
{
    public class EstadoRepository : IEstadoRepository
    {
        SpMedGroupContext ctx = new SpMedGroupContext();
        public void Atualizar(int id, Estado estado)
        {
            throw new NotImplementedException();
        }

        public Estado BuscarPorId(int id)
        {
            return ctx.Estado.FirstOrDefault(e => e.IdEstado == id);
        }

        public void Cadastrar(Estado novoEstado)
        {
            ctx.Estado.Add(novoEstado);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Estado estadoApagado = new Estado();
            estadoApagado = BuscarPorId(id);
            ctx.Estado.Remove(estadoApagado);
            ctx.SaveChanges();

        }

        public List<Estado> Listar()
        {
            return ctx.Estado.ToList();
        }
    }
}
