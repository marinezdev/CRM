using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Contacto
    {
        public int Id { get; set; }
        public Persona Persona { get; set; }
        public Usuario Usuario { get; set; }
        public CatFuenteOrigen CatFuenteOrigen { get; set; }
        public CatCargo CatCargo { get; set; }
        public string Propietario { get; set; }
        public string Descripcion { get; set; }
        public string Clave { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Restringido { get; set; }
        public List<int> IdContacto { get; set; }

    }
}
