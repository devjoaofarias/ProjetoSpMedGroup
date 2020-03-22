using System;
using System.Collections.Generic;

namespace Senai.SpMedGroupWebApi.DataBase.first.Domains
{
    public partial class Administrador
    {
        public int IdAdministrador { get; set; }
        public int? IdClinica { get; set; }
        public int? IdUsuario { get; set; }

        public Clinica IdClinicaNavigation { get; set; }
        public Usuario IdUsuarioNavigation { get; set; }
    }
}
