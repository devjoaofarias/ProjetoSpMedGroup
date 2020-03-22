using System;
using System.Collections.Generic;

namespace Senai.SpMedGroupWebApi.DataBase.first.Domains
{
    public partial class Prontuario
    {
        public Prontuario()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int IdProntuario { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdClinica { get; set; }
        public string Altura { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Peso { get; set; }

        public Clinica IdClinicaNavigation { get; set; }
        public Usuario IdUsuarioNavigation { get; set; }
        public ICollection<Consulta> Consulta { get; set; }
    }
}
