using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatFuenteOrigen
    {
        Data.CatFuenteOrigen _CatFuenteOrigen = new Data.CatFuenteOrigen();

        public List<Models.CatFuenteOrigen> CatFuenteOrigen_Seleccionar()
        {
            return _CatFuenteOrigen.CatFuenteOrigen_Seleccionar();
        }

        public Models.CatFuenteOrigen CatFuenteOrigen_Agregar(Models.CatFuenteOrigen catFuenteOrigen)
        {
            return _CatFuenteOrigen.CatFuenteOrigen_Agregar(catFuenteOrigen);
        }
    }
}
