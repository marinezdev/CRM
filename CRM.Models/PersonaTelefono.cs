using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class PersonaTelefono
    {
        public int Id { get; set; }
        public Persona Persona { get; set; }
        public Telefono Telefono { get; set; }
        public Usuario Usuario { get; set; }
    }
}
