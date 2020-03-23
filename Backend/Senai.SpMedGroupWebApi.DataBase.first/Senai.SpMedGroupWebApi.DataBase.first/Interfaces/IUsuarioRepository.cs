using Senai.SpMedGroupWebApi.DataBase.first.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedGroupWebApi.DataBase.first.Interfaces
{
    interface IUsuarioRepository 
    {
        List<Usuario> Listar ();

        Usuario BuscarPorId(int id);

        void Cadastrar(Usuario novoUsuario);

        void Deletar(int id);

        void Atualizar(int id, Usuario usuario);
    }
}
