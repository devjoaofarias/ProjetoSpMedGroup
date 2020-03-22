﻿using System;
using System.Collections.Generic;

namespace Senai.SpMedGroupWebApi.DataBase.first.Domains
{
    public partial class Medico
    {
        public Medico()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int IdMedico { get; set; }
        public int? IdEspecialidade { get; set; }
        public int? IdClinica { get; set; }
        public int? IdUsuario { get; set; }
        public string Crm { get; set; }

        public Clinica IdClinicaNavigation { get; set; }
        public Especialidade IdEspecialidadeNavigation { get; set; }
        public Usuario IdUsuarioNavigation { get; set; }
        public ICollection<Consulta> Consulta { get; set; }
    }
}
