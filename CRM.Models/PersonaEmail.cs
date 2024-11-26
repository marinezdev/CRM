using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class PersonaEmail
    {
        public int Id { get; set; }
        public Email Email { get; set; }
        public Persona Persona { get; set; }
        public int Busqueda { get; set; }
        public Usuario Usuario { get; set; }
    }
}
