using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public CatIndustria CatIndustria { get; set; }
        public CatTipoEmpresa CatTipoEmpresa { get; set; }
        public CatFuenteOrigen CatFuenteOrigen { get; set; }
        public CatNumeroEmpleados CatNumeroEmpleados { get; set; }
        public CatIngresoAnual CatIngresoAnual { get; set; }
        public CatUnidadNegocio CatUnidadNegocio { get; set; }
        public Persona Persona { get; set; }
        public Usuario Usuario { get; set; }
        public string Nombre { get; set; }
        public string Alias { get; set; }
        public string RFC { get; set; }
        public string Descripcion { get; set; }
        public string Clave { get; set; }
        
        public string PaginaWeb { get; set; }
        public string Imagen { get; set; }
        public string ImagenURL { get; set; }
        public int Busqueda { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Activo { get; set; }
        public string Estatus { get; set; }
        public string Color { get; set; }

        public Lista Lista { get; set; }
    }
}
