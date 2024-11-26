using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models.Consulta
{
    public class Actividades
    {
        public int Id { get; set; }
        public string Entidad { get; set; }
        public int IdEntidad { get; set; }
        public string Actividad { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }

        public CatUnidadNegocio CatUnidadNegocio { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
    }
}
