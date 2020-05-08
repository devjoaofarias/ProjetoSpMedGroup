using SenaiSpMedGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiSpMedGroup.WebApi.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TipoUsuario> Listar();

        void Cadastrar(TipoUsuario novoTipoUsuario);

        TipoUsuario BuscarPorId(int id);

        void Deletar(int id);

        void Atualizar(int id, TipoUsuario tipoUsuario);
    }
}
