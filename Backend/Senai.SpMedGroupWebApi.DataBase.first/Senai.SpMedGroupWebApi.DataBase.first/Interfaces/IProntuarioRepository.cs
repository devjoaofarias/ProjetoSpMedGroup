using Senai.SpMedGroupWebApi.DataBase.first.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedGroupWebApi.DataBase.first.Interfaces
{
    interface IProntuarioRepository
    {
        List<Prontuario> Listar();

        Prontuario BuscarPorId(int id);

        void Cadastrar(Prontuario novoProntuario);

        void Deletar(int id);

        void Atualizar(int id, Prontuario prontuario);
    }
}
