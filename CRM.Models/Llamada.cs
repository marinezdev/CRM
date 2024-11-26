using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Llamada
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public CatResultadoLlamada CatResultadoLlamada { get; set; }
        public CatDireccionLlamada CatDireccionLlamada { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
