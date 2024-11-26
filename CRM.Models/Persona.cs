using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Persona
    {
        public CatTipoPersona CatTipoPersona { get; set; }
        public CatEstatusPersona CatEstatusPersona { get; set; }
        public Email Email { get; set; }
        public Telefono Telefono { get; set; }
        public CatUnidadNegocio CatUnidadNegocio { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int Sexo { get; set; }
        public string RFC { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
