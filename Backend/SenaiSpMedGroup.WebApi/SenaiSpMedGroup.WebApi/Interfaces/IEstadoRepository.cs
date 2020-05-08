using SenaiSpMedGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiSpMedGroup.WebApi.Interfaces
{
    interface IEstadoRepository
    {
        List<Estado> Listar();

        void Cadastrar(Estado novoEstado);

        Estado BuscarPorId(int id);

        void Deletar(int id);

        void Atualizar(int id, Estado estado);
    }
}
