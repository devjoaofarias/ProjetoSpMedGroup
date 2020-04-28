using System;
using System.Collections.Generic;

namespace SenaiSpMedGroup.WebApi.Domains
{
    public partial class Cidade
    {
        public Cidade()
        {
            Clinica = new HashSet<Clinica>();
        }

        public int IdCidade { get; set; }
        public int? IdEstado { get; set; }
        public string NomeCidade { get; set; }

        public Estado IdEstadoNavigation { get; set; }
        public ICollection<Clinica> Clinica { get; set; }
    }
}
