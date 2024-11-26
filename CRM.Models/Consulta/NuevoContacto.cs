using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models.Consulta
{
    public class NuevoContacto
    {
        public Contacto Contacto { get; set; }
        public Telefono Telefono { get; set; }
        public Puesto Puesto { get; set; }
    }
}
