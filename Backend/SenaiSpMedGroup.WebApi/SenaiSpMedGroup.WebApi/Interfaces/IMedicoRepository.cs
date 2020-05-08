using SenaiSpMedGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiSpMedGroup.WebApi.Interfaces
{
    interface IMedicoRepository
    {
        List<Medico> Listar();

        void Cadastrar(Medico novoMedico);

        Medico BuscarPorId(int id);

        void Deletar(int id);

        void Atualizar(int id, Medico medico);  
    }
}
