using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatClasificacionProducto
    {
        Data.CatClasificacionProducto _CatClasificacionProducto = new Data.CatClasificacionProducto();
        public List<Models.CatClasificacionProducto> CatClasificacionProducto_Listar(Models.CatSubcategoriaProducto catSubcategoriaProducto)
        {
            
            return _CatClasificacionProducto.CatClasificacionProducto_Seleccionar(catSubcategoriaProducto);
        }

        public Models.CatClasificacionProducto CatClasificacionProducto_Agregar(Models.CatClasificacionProducto catClasificacionProducto)
        {
            return _CatClasificacionProducto.CatClasificacionProducto_Agregar(catClasificacionProducto);
        }
    }
}
