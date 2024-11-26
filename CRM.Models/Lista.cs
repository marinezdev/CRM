using CRM.Models.Consulta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Lista
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Usuario Usuario { get; set; }
        public CatUnidadNegocio CatUnidadNegocio { get; set; }
        public Contacto Contacto { get; set; }
        public string NumContacto { get; set; }

        public Campaign Campaign { get; set; }

    }
}
