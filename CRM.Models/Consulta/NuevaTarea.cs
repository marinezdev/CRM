using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models.Consulta
{
    public class NuevaTarea
    {
        public Tarea Tarea { get; set; }
        public TareaEntidad TareaEntidad { get; set; }
        public TareaPersona TareaPersona { get; set; }
        public string Clave { get; set; }
    }
}
