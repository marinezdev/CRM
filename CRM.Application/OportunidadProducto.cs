using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class OportunidadProducto
    {
        Data.OportunidadProducto _OportunidadProducto = new Data.OportunidadProducto();

        public Models.OportunidadProducto OportunidadProducto_Agregar(Models.OportunidadProducto oportunidadProducto)
        {
            return _OportunidadProducto.OportunidadProducto_Agregar(oportunidadProducto);
        }

        public List<Models.OportunidadProducto> OportunidadProducto_Seleccionar_IdOportunidad(Models.Oportunidad oportunidad)
        {
            return _OportunidadProducto.OportunidadProducto_Seleccionar_IdOportunidad(oportunidad);
        }

        public Models.OportunidadProducto OportunidadProducto_Eliminar(Models.OportunidadProducto oportunidadProducto)
        {
            return _OportunidadProducto.OportunidadProducto_Eliminar(oportunidadProducto);
        }

        public Models.OportunidadProducto OportunidadProducto_Selecionar_OportunidadProducto(Models.OportunidadProducto oportunidadProducto)
        {
            return _OportunidadProducto.OportunidadProducto_Selecionar_OportunidadProducto(oportunidadProducto);
        }

    }
}
