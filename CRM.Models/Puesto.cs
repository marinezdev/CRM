using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Puesto
    {
        public int Id { get; set; }
        public Departamento Departamento { get; set; }
        public Usuario Usuario { get; set; }
        public string Nombre { get; set; }
    }
}
