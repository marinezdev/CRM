using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class OportunidadImporte
    {
        Data.OportunidadImporte _OportunidadImporte = new Data.OportunidadImporte();
        public Models.OportunidadImporte OportunidadImporte_Agregar(Models.OportunidadImporte oportunidadImporte)
        {
            return _OportunidadImporte.OportunidadImporte_Agregar(oportunidadImporte);
        }
        public Models.OportunidadImporte OportunidadImporte_Eliminar(Models.OportunidadImporte oportunidadImporte)
        {
            return _OportunidadImporte.OportunidadImporte_Eliminar(oportunidadImporte);
        }
        public Models.OportunidadImporte OportunidadImporte_Editar(Models.OportunidadImporte oportunidadImporte)
        {
            return _OportunidadImporte.OportunidadImporte_Editar(oportunidadImporte);
        }
        public Models.OportunidadImporte OportunidadImporte_Seleccionar_Id(Models.OportunidadImporte oportunidadImporte)
        {
            return _OportunidadImporte.OportunidadImporte_Seleccionar_Id(oportunidadImporte);
        }
        public List<Models.OportunidadImporte> OportunidadImporte_Seleccionar_IdOportunidad(Models.Oportunidad oportunidad)
        {
            return _OportunidadImporte.OportunidadImporte_Seleccionar_IdOportunidad(oportunidad);
        }

    }
}
