﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class PersonaDireccion
    {
        public int Id { get; set; }
        public Persona Persona { get; set; }
        public CatColonias CatColonias { get; set; }
        public string Nombre { get; set; }
        public string NumExterior { get; set; }
        public string NumInterior { get; set; }
        public string Calle { get; set; }
        public Usuario Usuario { get; set; }
    }
}
