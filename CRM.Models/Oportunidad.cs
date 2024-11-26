using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Oportunidad
    {
        public int Id { get; set; }
        public CatPrioridad CatPrioridad { get; set; }
        public CatTipoOportunidad CatTipoOportunidad { get; set; }
        public Usuario Usuario { get; set; }
        public CatEstatusOpurtunidad CatEstatusOpurtunidad { get; set; }
        public CatUnidadNegocio CatUnidadNegocio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Clave { get; set; }
        public string Propietario { get; set; }
        public string Empresa { get; set; }
        public string Importe { get; set; }
        public float Monto { get; set; }
        public float Progreso { get; set; }
        public DateTime FechaCierre { get; set; }
        public DateTime FechaRegistro { get; set; }

        public int Year { get; set; }
    }
}
