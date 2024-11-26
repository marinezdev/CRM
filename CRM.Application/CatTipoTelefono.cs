using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatTipoTelefono
    {
        Data.CatTipoTelefono _CatTipoTelefono = new Data.CatTipoTelefono();
        public List<Models.CatTipoTelefono> CatTipoTelefono_Seleccionar()
        {
            return _CatTipoTelefono.CatTipoTelefono_Seleccionar();
        }

        public Models.CatTipoTelefono CatTipoTelefono_Agregar(Models.CatTipoTelefono catTipoTelefono)
        {
            return _CatTipoTelefono.CatTipoTelefono_Agregar(catTipoTelefono);
        }
    }
}
