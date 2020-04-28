using System;
using System.Collections.Generic;

namespace SenaiSpMedGroup.WebApi.Domains
{
    public partial class Clinica
    {
        public Clinica()
        {
            Administrador = new HashSet<Administrador>();
            Consulta = new HashSet<Consulta>();
            Medico = new HashSet<Medico>();
            Prontuario = new HashSet<Prontuario>();
        }

        public int IdClinica { get; set; }
        public int IdCidade { get; set; }
        public string NomeClinica { get; set; }
        public string Cnpj { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string HorarioInicial { get; set; }
        public string HorarioFinal { get; set; }

        public Cidade IdCidadeNavigation { get; set; }
        public ICollection<Administrador> Administrador { get; set; }
        public ICollection<Consulta> Consulta { get; set; }
        public ICollection<Medico> Medico { get; set; }
        public ICollection<Prontuario> Prontuario { get; set; }
    }
}
