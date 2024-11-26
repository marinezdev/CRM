using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatIngresoAnual
    {
        Data.CatIngresoAnual _CatIngresoAnual = new Data.CatIngresoAnual();

        public List<Models.CatIngresoAnual> CatIngresoAnual_Seleccionar()
        {
            return _CatIngresoAnual.CatIngresoAnual_Seleccionar();
        }
    }
}
