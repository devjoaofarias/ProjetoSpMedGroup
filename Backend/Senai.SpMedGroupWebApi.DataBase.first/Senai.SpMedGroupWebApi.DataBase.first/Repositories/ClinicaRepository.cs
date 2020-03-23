using Senai.SpMedGroupWebApi.DataBase.first.Domains;
using Senai.SpMedGroupWebApi.DataBase.first.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedGroupWebApi.DataBase.first.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        SpMedGroupContext ctx = new SpMedGroupContext();

        public void Atualizar(int id, Clinica clinica)
        {
            throw new NotImplementedException();
        }

        public Clinica BuscarPorId(int id)
        {
            return ctx.Clinica.FirstOrDefault(e => e.IdClinica == id);
        }

        public void Cadastrar(Clinica novaClinica)
        {
            ctx.Clinica.Add(novaClinica);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Clinica clinicaApagada = new Clinica();
            clinicaApagada = BuscarPorId(id);
            ctx.Clinica.Remove(clinicaApagada);
            ctx.SaveChanges();
        }

        public List<Clinica> Listar()
        {
            return ctx.Clinica.ToList();
        }
    }
}
