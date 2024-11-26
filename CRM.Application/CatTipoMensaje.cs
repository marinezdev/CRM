using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatTipoMensaje
    {
        Data.CatTipoMensaje _CatTipoMensaje = new Data.CatTipoMensaje();
        public List<Models.CatTipoMensaje> CatTipoMensaje_Seleccionar()
        {
            return _CatTipoMensaje.CatTipoMensaje_Seleccionar();
        }
    }
}
