using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatFechaVencimiento
    {
        Data.CatFechaVencimiento _CatFechaVencimiento = new Data.CatFechaVencimiento();
        public List<Models.CatFechaVencimiento> CatFechaVencimiento_Seleccionar()
        {
            return _CatFechaVencimiento.CatFechaVencimiento_Seleccionar();
        }
    }
}
