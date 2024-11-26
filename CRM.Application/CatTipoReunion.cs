using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatTipoReunion
    {
        Data.CatTipoReunion _CatTipoReunion = new Data.CatTipoReunion();
        public List<Models.CatTipoReunion> CatTipoReunion_Seleccionar()
        {
            return _CatTipoReunion.CatTipoReunion_Seleccionar();
        }
    }
}
