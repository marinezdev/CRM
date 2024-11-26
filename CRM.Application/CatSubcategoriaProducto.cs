using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatSubcategoriaProducto
    {
        Data.CatSubcategoriaProducto _CatSubcategoriaProducto = new Data.CatSubcategoriaProducto();
        public List<Models.CatSubcategoriaProducto> CatSubcategoriaProducto_Seleccionar(Models.CatCategoriasProducto catCategoriasProducto)
        {
            return _CatSubcategoriaProducto.CatSubcategoriaProducto_Seleccionar(catCategoriasProducto);
        }

        public Models.CatSubcategoriaProducto CatSubcategoriaProducto_Agregar(Models.CatSubcategoriaProducto catSubcategoriaProducto)
        {
            return _CatSubcategoriaProducto.CatSubcategoriaProducto_Agregar(catSubcategoriaProducto);
        }
    }
}
