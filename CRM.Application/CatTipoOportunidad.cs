using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatTipoOportunidad
    {
        Data.CatTipoOportunidad _CatTipoOportunidad = new Data.CatTipoOportunidad();
        public List<Models.CatTipoOportunidad> CatTipoOportunidad_Seleccionar()
        {
            return _CatTipoOportunidad.CatTipoOportunidad_Seleccionar();
        }
        public Models.CatTipoOportunidad CatTipoOportunidad_Agregar(Models.CatTipoOportunidad catTipoOportunidad)
        {
            return _CatTipoOportunidad.CatTipoOportunidad_Agregar(catTipoOportunidad);
        }
    }
}
