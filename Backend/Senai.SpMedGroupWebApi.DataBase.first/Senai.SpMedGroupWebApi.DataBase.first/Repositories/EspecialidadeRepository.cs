using Senai.SpMedGroupWebApi.DataBase.first.Domains;
using Senai.SpMedGroupWebApi.DataBase.first.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedGroupWebApi.DataBase.first.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        SpMedGroupContext ctx = new SpMedGroupContext();

        public void Atualizar(int id, Especialidade especialidade)
        {
            throw new NotImplementedException();
        }

        public Especialidade BuscarPorId(int id)
        {
            return ctx.Especialidade.FirstOrDefault(e => e.IdEspecialidade == id);
        }

        public void Cadastrar(Especialidade novaEspecialidade)
        {
            ctx.Especialidade.Add(novaEspecialidade);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Especialidade especialidadeApagada = new Especialidade();
            especialidadeApagada = BuscarPorId(id);
            ctx.Especialidade.Remove(especialidadeApagada);
            ctx.SaveChanges();
        }

        public List<Especialidade> Listar()
        {
            return ctx.Especialidade.ToList();
        }
    }
}
