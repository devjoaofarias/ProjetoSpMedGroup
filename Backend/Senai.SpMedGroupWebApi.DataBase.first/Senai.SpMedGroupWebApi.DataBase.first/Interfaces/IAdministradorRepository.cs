using Senai.SpMedGroupWebApi.DataBase.first.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedGroupWebApi.DataBase.first.Interfaces
{
    interface IAdministradorRepository
    {
        List<Administrador> Listar();

        Administrador BuscarPorId(int id);

        void Cadastrar(Administrador novoAdministrador);

        void Deletar(int id);

        void Atualizar(int id, Administrador administrador);
    }
}
