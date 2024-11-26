using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class EmpresaBitacora
    {
        public string Operacion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Nota { get; set; }
        public string Propietario { get; set; }
    }
}
