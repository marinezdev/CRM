using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatTipoPersona
    {
        Data.CatTipoPersona _CatTipoPersona = new Data.CatTipoPersona();

        public List<Models.CatTipoPersona> CatTipoPersona_Seleccionar()
        {
            return _CatTipoPersona.CatTipoPersona_Seleccionar();
        }

        public Models.CatTipoPersona CatTipoPersona_Agregar(Models.CatTipoPersona catTipoPersona)
        {
            return _CatTipoPersona.CatTipoPersona_Agregar(catTipoPersona);
        }
    }
}
