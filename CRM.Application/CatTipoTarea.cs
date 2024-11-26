using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatTipoTarea
    {
        Data.CatTipoTarea _CatTipoTarea = new Data.CatTipoTarea();
        public List<Models.CatTipoTarea> CatTipoTarea_Seleccionar()
        {
            return _CatTipoTarea.CatTipoTarea_Seleccionar();
        }
    }
}
