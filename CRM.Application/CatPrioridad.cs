using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatPrioridad
    {
        Data.CatPrioridad _CatPrioridad = new Data.CatPrioridad();
        public List<Models.CatPrioridad> CatPrioridad_Seleccionar()
        {
            return _CatPrioridad.CatPrioridad_Seleccionar();
        }
    }
}
