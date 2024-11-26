using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatEstatusPersona
    {
        Data.CatEstatusPersona _CatEstatusPersona = new Data.CatEstatusPersona();

        public List<Models.CatEstatusPersona> CatEstatusPersona_Seleccionar()
        {
            return _CatEstatusPersona.CatEstatusPersona_Seleccionar();
        }
        public Models.CatEstatusPersona CatEstatusPersona_Agregar(Models.CatEstatusPersona catEstatusPersona)
        {
            return _CatEstatusPersona.CatEstatusPersona_Agregar(catEstatusPersona);
        }
    }
}
