using SenaiSpMedGroup.WebApi.Domains;
using SenaiSpMedGroup.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiSpMedGroup.WebApi.Repositories
{
    public class SituacaoRepository : ISituacaoRepository
    {
        SpMedGroupContext ctx = new SpMedGroupContext();
        public void Atualizar(int id, Situacao situacao)
        {
            throw new NotImplementedException();
        }

        public Situacao BuscarPorId(int id)
        {
            return ctx.Situacao.FirstOrDefault(e => e.IdSituacao == id);
        }

        public void Cadastrar(Situacao novaSituacao)
        {
            ctx.Situacao.Add(novaSituacao);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Situacao situacaoApagada = new Situacao();
            situacaoApagada = BuscarPorId(id);
            ctx.Situacao.Remove(situacaoApagada);
            ctx.SaveChanges();

        }

        public List<Situacao> Listar()
        {
            return ctx.Situacao.ToList();
        }
    }
}
