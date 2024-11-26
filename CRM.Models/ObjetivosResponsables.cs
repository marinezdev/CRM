using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class ObjetivosResponsables
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public CatUnidadNegocio CatUnidadNegocio { get; set; }
        public string Descripcion { get; set; }
        public float FacturacionRecurrente { get; set; }
        public float ProyectosNuevos { get; set; }
        public float Acumulado { get; set; }
        public float EnProceso { get; set; }
        public float MontoAcumuladoMes { get; set; }
        public float MontoAcumuladoMesOld { get; set; }
        public float MontoAcumulado { get; set; }
        public float year { get; set; }
    }
}
