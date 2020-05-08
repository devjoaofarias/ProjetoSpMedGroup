using SenaiSpMedGroup.WebApi.Domains;
using SenaiSpMedGroup.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace SenaiSpMedGroup.WebApi.Repositories
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
            return ctx.Clinica.FirstOrDefault(e => e.IdCidade == id);
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
