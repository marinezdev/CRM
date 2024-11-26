using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class TareaPersona
    {
        //public Tarea Tarea { get; set; }
        public CatTipoTarea CatTipoTarea { get; set; }
        public CatPrioridad CatPrioridad { get; set; }
        public Persona Persona { get; set; }
        public CatEstatusNotificacion CatEstatusNotificacion { get; set; }
    }
}
