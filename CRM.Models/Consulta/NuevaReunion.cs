using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models.Consulta
{
    public class NuevaReunion
    {
        public Tarea Tarea { get; set; }
        public Reunion Reunion { get; set; }
        public ReunionEntidad ReunionEntidad { get; set; }
        public List<Models.ReunionPersona> ReunionPersona { get; set; }
    }
}
