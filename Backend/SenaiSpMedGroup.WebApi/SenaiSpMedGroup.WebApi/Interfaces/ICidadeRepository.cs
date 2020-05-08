using SenaiSpMedGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiSpMedGroup.WebApi.Interfaces
{
    interface ICidadeRepository
    {
        List<Cidade> Listar();

        void Cadastrar(Cidade novaCidade);

        Cidade BuscarPorId(int id);

        void Deletar(int id);

        void Atualizar(int id, Cidade cidade);
    }
}
