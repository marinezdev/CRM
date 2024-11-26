using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class CorreoPersona
    {
        public int Id { get; set; }
        public Correo Correo { get; set; }
        public Persona Persona { get; set; }
    }
}
