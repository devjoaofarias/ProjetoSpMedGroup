using System;
using System.Collections.Generic;

namespace Senai.SpMedGroupWebApi.DataBase.first.Domains
{
    public partial class Clinica
    {
        public Clinica()
        {
            Administrador = new HashSet<Administrador>();
            Medico = new HashSet<Medico>();
            Prontuario = new HashSet<Prontuario>();
        }

        public int IdClinica { get; set; }
        public string Endereco { get; set; }
        public string Cnpj { get; set; }
        public string HorarioFuncionamento { get; set; }

        public ICollection<Administrador> Administrador { get; set; }
        public ICollection<Medico> Medico { get; set; }
        public ICollection<Prontuario> Prontuario { get; set; }
    }
}
