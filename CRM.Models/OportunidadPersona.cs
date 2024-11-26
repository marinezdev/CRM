using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class OportunidadPersona
    { 
        public int Id { get; set; }
        public Oportunidad Oportunidad { get; set; }
        public Persona Persona { get; set; }
        public CatPersonaOportunidad CatPersonaOportunidad { get; set;}
        public Usuario Usuario { get; set; }
    }
}
