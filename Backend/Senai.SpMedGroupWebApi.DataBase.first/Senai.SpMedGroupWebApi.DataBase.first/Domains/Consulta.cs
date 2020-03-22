using System;
using System.Collections.Generic;

namespace Senai.SpMedGroupWebApi.DataBase.first.Domains
{
    public partial class Consulta
    {
        public int IdConsulta { get; set; }
        public int? IdProntuario { get; set; }
        public int? IdMedico { get; set; }
        public DateTime DataConsulta { get; set; }
        public string Descricao { get; set; }
        public string Situacao { get; set; }

        public Medico IdMedicoNavigation { get; set; }
        public Prontuario IdProntuarioNavigation { get; set; }
    }
}
