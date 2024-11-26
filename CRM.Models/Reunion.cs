using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Reunion
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public CatResultadoReunion CatResultadoReunion { get; set; }
        public CatDuracionReunion CatDuracionReunion { get; set; }
        public CatTipoReunion CatTipoReunion { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
