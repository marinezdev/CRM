using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models.Consulta
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
        public OportunidadPersona OportunidadPersona { get; set; }
        public OportunidadEmpresa OportunidadEmpresa { get; set; }
        public OportunidadProducto OportunidadProducto { get; set; }
        public OportunidadImporte OportunidadImporte { get; set; }
        public OportunidadFechaCierre OportunidadFechaCierre { get; set; }
        public int Total { get; set; }
    }
}
