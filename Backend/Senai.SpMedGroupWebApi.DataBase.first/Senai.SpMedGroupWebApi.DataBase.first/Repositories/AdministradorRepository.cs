using Senai.SpMedGroupWebApi.DataBase.first.Domains;
using Senai.SpMedGroupWebApi.DataBase.first.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedGroupWebApi.DataBase.first.Repositories
{
    public class AdministradorRepository : IAdministradorRepository
    {
        SpMedGroupContext ctx = new SpMedGroupContext();

        public void Atualizar(int id, Administrador administrador)
        {
            throw new NotImplementedException();
        }

        public Administrador BuscarPorId(int id)
        {
            return ctx.Administrador.FirstOrDefault(e => e.IdAdministrador == id);
        }

        public void Cadastrar(Administrador novoAdministrador)
        {
            ctx.Administrador.Add(novoAdministrador);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Administrador administradorApagado = new Administrador();
            administradorApagado = BuscarPorId(id);
            ctx.Administrador.Remove(administradorApagado);
            ctx.SaveChanges();
        }

        public List<Administrador> Listar()
        {
            return ctx.Administrador.ToList();
        }
    }
}
