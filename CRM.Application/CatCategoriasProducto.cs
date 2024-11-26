using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatCategoriasProducto
    {
        Data.CatCategoriasProducto _CatCategoriasProducto = new Data.CatCategoriasProducto();
        public List<Models.CatCategoriasProducto> CatCategoriasProducto_Seleccionar()
        {
            return _CatCategoriasProducto.CatCategoriasProducto_Seleccionar();
        }
        public Models.CatCategoriasProducto CatCategoriasProducto_Agregar(Models.CatCategoriasProducto catCategoriasProducto)
        {
            return _CatCategoriasProducto.CatCategoriasProducto_Agregar(catCategoriasProducto);
        }
    }
}
