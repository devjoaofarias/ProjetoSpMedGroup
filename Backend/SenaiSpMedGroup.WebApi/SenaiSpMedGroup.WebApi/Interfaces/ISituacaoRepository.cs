using SenaiSpMedGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiSpMedGroup.WebApi.Interfaces
{
    interface ISituacaoRepository
    {
        List<Situacao> Listar();

        void Cadastrar(Situacao novaSituacao);

        Situacao BuscarPorId(int id);

        void Deletar(int id);

        void Atualizar(int id, Situacao situacao);
    }
}
