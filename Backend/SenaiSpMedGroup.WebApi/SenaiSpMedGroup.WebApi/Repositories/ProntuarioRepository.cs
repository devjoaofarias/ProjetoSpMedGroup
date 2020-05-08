using SenaiSpMedGroup.WebApi.Domains;
using SenaiSpMedGroup.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiSpMedGroup.WebApi.Repositories
{
    public class ProntuarioRepository : IProntuarioRepository
    {
        SpMedGroupContext ctx = new SpMedGroupContext();
        public void Atualizar(int id, Prontuario prontuario)
        {
            throw new NotImplementedException();
        }

        public Prontuario BuscarPorId(int id)
        {
            return ctx.Prontuario.FirstOrDefault(e => e.IdProntuario == id);
        }

        public void Cadastrar(Prontuario novoProntuario)
        {
            ctx.Prontuario.Add(novoProntuario);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Prontuario prontuarioApagado = new Prontuario();
            prontuarioApagado = BuscarPorId(id);
            ctx.Prontuario.Remove(prontuarioApagado);
            ctx.SaveChanges();
        }

        public List<Prontuario> Listar()
        {
            return ctx.Prontuario.ToList();
        }
    }
}
