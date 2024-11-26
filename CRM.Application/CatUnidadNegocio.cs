using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatUnidadNegocio
    {
        Data.CatUnidadNegocio _CatUnidadNegocio = new Data.CatUnidadNegocio();

        public List<Models.CatUnidadNegocio> CatUnidadNegocio_Seleccionar()
        {
            return _CatUnidadNegocio.CatUnidadNegocio_Seleccionar();
        }

        public Models.CatUnidadNegocio CatUnidadNegocio_Agregar(Models.CatUnidadNegocio catUnidadNegocio)
        {
            return _CatUnidadNegocio.CatUnidadNegocio_Agregar(catUnidadNegocio);
        }
    }
}
