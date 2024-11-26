using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatEstatusOpurtunidad
    {
        Data.CatEstatusOpurtunidad _CatEstatusOpurtunidad = new Data.CatEstatusOpurtunidad();
        public List<Models.CatEstatusOpurtunidad> CatEstatusOpurtunidad_Seleccionar()
        {
            return _CatEstatusOpurtunidad.CatEstatusOpurtunidad_Seleccionar();
        }

        public Models.CatEstatusOpurtunidad CatEstatusOpurtunidad_Agregar(Models.CatEstatusOpurtunidad catEstatusOpurtunidad)
        {
            return _CatEstatusOpurtunidad.CatEstatusOpurtunidad_Agregar(catEstatusOpurtunidad);
        }
    }
}
