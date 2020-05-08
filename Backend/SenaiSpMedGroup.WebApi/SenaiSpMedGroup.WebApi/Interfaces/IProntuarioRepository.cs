using SenaiSpMedGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiSpMedGroup.WebApi.Interfaces
{
    interface IProntuarioRepository
    {
        List<Prontuario> Listar();

        void Cadastrar(Prontuario novoProntuario);

        Prontuario BuscarPorId(int id);

        void Deletar(int id);

        void Atualizar(int id, Prontuario prontuario);
    }
}
