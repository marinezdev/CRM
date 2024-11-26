using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatPersonaOportunidad
    {
        Data.CatPersonaOportunidad _CatPersonaOportunidad = new Data.CatPersonaOportunidad();
        public List<Models.CatPersonaOportunidad> CatPersonaOportunidad_Seleccionar()
        {
            return _CatPersonaOportunidad.CatPersonaOportunidad_Seleccionar();
        }
        public Models.CatPersonaOportunidad CatPersonaOportunidad_Agregar(Models.CatPersonaOportunidad catPersonaOportunidad)
        {
            return _CatPersonaOportunidad.CatPersonaOportunidad_Agregar(catPersonaOportunidad);
        }
    }
}
