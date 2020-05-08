using SenaiSpMedGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiSpMedGroup.WebApi.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> Listar();

        void Cadastrar(Usuario novoUsuario);

        Usuario BuscarPorId(int id);

        void Deletar(int id);

        void Atualizar(int id, Usuario usuario);
    }
}
