using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Mensaje
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public CatTipoMensaje CatTipoMensaje { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
