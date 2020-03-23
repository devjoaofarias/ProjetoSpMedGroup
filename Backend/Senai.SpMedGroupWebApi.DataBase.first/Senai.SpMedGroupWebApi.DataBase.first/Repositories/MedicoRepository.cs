using Senai.SpMedGroupWebApi.DataBase.first.Domains;
using Senai.SpMedGroupWebApi.DataBase.first.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedGroupWebApi.DataBase.first.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        SpMedGroupContext ctx = new SpMedGroupContext();

        public void Atualizar(int id, Medico medico)
        {
            throw new NotImplementedException();
        }

        public Medico BuscarPorId(int id)
        {
            return ctx.Medico.FirstOrDefault(e => e.IdMedico == id);
        }

        public void Cadastrar(Medico novoMedico)
        {
            ctx.Medico.Add(novoMedico);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Medico medicoApagado = new Medico();
            medicoApagado = BuscarPorId(id);
            ctx.Medico.Remove(medicoApagado);
            ctx.SaveChanges();
        }

        public List<Medico> Listar()
        {
            return ctx.Medico.ToList();
        }
    }
}
