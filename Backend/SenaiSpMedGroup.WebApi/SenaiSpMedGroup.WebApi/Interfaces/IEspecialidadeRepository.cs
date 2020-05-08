using SenaiSpMedGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiSpMedGroup.WebApi.Interfaces
{
    interface IEspecialidadeRepository
    {
        List<Especialidade> Listar();

        void Cadastrar(Especialidade novaEspecialidade);

        Especialidade BuscarPorId(int id);

        void Deletar(int id);

        void Atualizar(int id, Especialidade especialidade);
    }
}
