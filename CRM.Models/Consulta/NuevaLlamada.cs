using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models.Consulta
{
    public class NuevaLlamada
    {
        public Tarea Tarea { get; set; }
        public Llamada Llamada { get; set; }
        public LlamadaEntidad LlamadaEntidad { get; set; }
        public List<Models.LlamadaPersona> LlamadaPersona { get; set; }
    }
}
