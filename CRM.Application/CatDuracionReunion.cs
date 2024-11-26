using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatDuracionReunion
    {
        Data.CatDuracionReunion _CatDuracionReunion = new Data.CatDuracionReunion();

        public List<Models.CatDuracionReunion> CatDuracionReunion_Seleccionar()
        {
            return _CatDuracionReunion.CatDuracionReunion_Seleccionar();
        }
    }
}
