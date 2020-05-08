using SenaiSpMedGroup.WebApi.Domains;
using SenaiSpMedGroup.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiSpMedGroup.WebApi.Repositories
{
    public class CidadeRepository : ICidadeRepository
    {
        SpMedGroupContext ctx = new SpMedGroupContext();

        public void Atualizar(int id, Cidade cidade)
        {
            throw new NotImplementedException();
        }

        public Cidade BuscarPorId(int id)
        {
            return ctx.Cidade.FirstOrDefault(e => e.IdCidade == id);
        }

        public void Cadastrar(Cidade novaCidade)
        {
            ctx.Cidade.Add(novaCidade);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Cidade cidadeApagada = new Cidade();
            cidadeApagada = BuscarPorId(id);
            ctx.Cidade.Remove(cidadeApagada);
            ctx.SaveChanges();
        }

        public List<Cidade> Listar()
        {
            return ctx.Cidade.ToList();
        }
    }
}
