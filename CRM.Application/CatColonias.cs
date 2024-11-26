using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatColonias
    {
        Data.CatColonias _CatColonias = new Data.CatColonias();
        public List<Models.CatColonias> CatColonias_Seleccionar_IdPoblacion(Models.CatPoblaciones catPoblaciones)
        {
            return _CatColonias.CatColonias_Seleccionar_IdPoblacion(catPoblaciones);
        }
    }
}
