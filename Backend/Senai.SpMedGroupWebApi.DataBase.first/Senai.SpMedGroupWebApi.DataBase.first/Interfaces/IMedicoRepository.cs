using Senai.SpMedGroupWebApi.DataBase.first.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedGroupWebApi.DataBase.first.Interfaces
{
    interface IMedicoRepository
    {
        List<Medico> Listar();

        Medico BuscarPorId(int id);

        void Cadastrar(Medico novoMedico);

        void Deletar(int id);

        void Atualizar(int id, Medico medico);
    }
}
