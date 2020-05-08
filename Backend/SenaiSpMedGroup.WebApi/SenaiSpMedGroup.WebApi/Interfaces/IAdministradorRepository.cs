using SenaiSpMedGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiSpMedGroup.WebApi.Interfaces
{
    interface IAdministradorRepository
    {
        List<Administrador> Listar();

        void Cadastrar(Administrador novoAdministrador);

        Administrador BuscarPorId(int id);

        void Deletar(int id);

        void Atualizar(int id, Administrador administrador);
    }
}
