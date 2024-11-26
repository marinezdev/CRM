using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class EmpresaTelefono
    {
        public int Id { get; set; }
        public Empresa Empresa { get; set; }
        public Telefono Telefono { get; set; }
        public Usuario Usuario { get; set; }
    }
}
