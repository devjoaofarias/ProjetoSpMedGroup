using SenaiSpMedGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiSpMedGroup.WebApi.Interfaces
{
    interface IConsultaRepository
    {
        List<Consulta> Listar();

        void Cadastrar(Consulta novaConsulta);

        Consulta BuscarPorId(int id);

        void Deletar(int id);

        void Atualizar(int id, Consulta consulta);
    }
}
