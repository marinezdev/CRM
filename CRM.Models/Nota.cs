using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Nota
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public string nota { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
