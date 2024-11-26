using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models.Consulta
{
    public class NuevoMensaje
    {
        public Tarea Tarea { get; set; }
        public Mensaje Mensaje { get; set; }
        public MensajeEntidad MensajeEntidad { get; set; }
        public List<Models.MensajePersona> MensajePersona { get; set; }
    }
}
