using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public CatFechaVencimiento CatFechaVencimiento { get; set; }
        public CatRecordatorio CatRecordatorio { get; set; }
        public CatEstatusTarea CatEstatusTarea { get; set; }
        public string Titulo { get; set; }
        public string Notas { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaRecordatorio { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Total { get; set; }
    }
}
