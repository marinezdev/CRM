using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public  class CatTipoEmpresa
    {
        Data.CatTipoEmpresa _CatTipoEmpresa = new Data.CatTipoEmpresa();

        public List<Models.CatTipoEmpresa> CatTipoEmpresa_Seleccionar()
        {
            return _CatTipoEmpresa.CatTipoEmpresa_Seleccionar();
        }

        public Models.CatTipoEmpresa CatTipoEmpresa_Agregar(Models.CatTipoEmpresa catTipoEmpresa)
        {
            return _CatTipoEmpresa.CatTipoEmpresa_Agregar(catTipoEmpresa);
        }
    }
}
