using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models.Consulta
{
    public class NuevoCorreo
    {
        public Tarea Tarea { get; set; }
        public Correo Correo { get; set; }
        public CorreoEntidad CorreoEntidad { get; set; }
        public List<Models.CorreoPersona> CorreoPersona { get; set; }
    }
}
