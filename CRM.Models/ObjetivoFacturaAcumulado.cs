using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class ObjetivoFacturaAcumulado
    {
        public int Id { get; set; }
        public ObjetivosResponsables ObjetivosResponsables { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public int Mes { get; set; }
        public string NombreMes { get; set; }
        public string MontoMesText { get; set; }
        public float Monto { get; set; }
        public string MontoText { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Year { get; set; }
    }
}
