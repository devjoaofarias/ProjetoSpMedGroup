using SenaiSpMedGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiSpMedGroup.WebApi.Interfaces
{
    interface IClinicaRepository
    {
        List<Clinica> Listar();

        void Cadastrar(Clinica novaClinica);

        Clinica BuscarPorId(int id);

        void Deletar(int id);

        void Atualizar(int id, Clinica clinica);
    }
}
