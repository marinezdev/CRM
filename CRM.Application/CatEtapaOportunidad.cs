using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatEtapaOportunidad
    {
        Data.CatEtapaOportunidad _CatEtapaOportunidad = new Data.CatEtapaOportunidad();
        public List<Models.CatEtapaOportunidad> CatEtapaOportunidad_Seleccionar()
        {
            return _CatEtapaOportunidad.CatEtapaOportunidad_Seleccionar();
        }
        public Models.CatEtapaOportunidad CatEtapaOportunidad_Seleccionar_Id(Models.CatEtapaOportunidad catEtapaOportunidad)
        {
            return _CatEtapaOportunidad.CatEtapaOportunidad_Seleccionar_Id(catEtapaOportunidad);
        }
    }
}
