using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class CorreoEntidad
    {
        public Correo Correo { get; set; }
        public CatEntidad CatEntidad { get; set; }
        public int IdValorEntidad { get; set; }
    }
}
