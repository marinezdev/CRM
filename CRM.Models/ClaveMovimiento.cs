using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class ClaveMovimiento
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public string Clave { get; set; }
        public string Movimiento { get; set; }
        public string Observaciones { get; set; }
    }
}
