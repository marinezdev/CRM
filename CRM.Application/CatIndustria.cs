using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatIndustria
    {
        Data.CatIndustria _CatIndustria = new Data.CatIndustria();

        public List<Models.CatIndustria> CatIndustria_Seleccionar()
        {
            return _CatIndustria.CatIndustria_Seleccionar();
        }

        public Models.CatIndustria CatIndustria_Agregar(Models.CatIndustria catIndustria)
        {
            return _CatIndustria.CatIndustria_Agregar(catIndustria);
        }
    }
}
