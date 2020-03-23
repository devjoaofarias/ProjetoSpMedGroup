using Senai.SpMedGroupWebApi.DataBase.first.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedGroupWebApi.DataBase.first.Interfaces
{
    interface IConsultaRepository
    {
        List<Consulta> Listar();

        Consulta BuscarPorId(int id);

        void Cadastrar(Consulta novaConsulta);

        void Deletar(int id);

        void Atualizar(int id, Consulta consulta);
    }
}
