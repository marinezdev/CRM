using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatProducto
    {
        Data.CatProducto _CatProducto = new Data.CatProducto();
        public List<Models.CatProducto> CatProducto_Seleccionar()
        {
            return _CatProducto.CatProducto_Seleccionar();
        }
        public List<Models.CatProducto> CatProducto_Seleccionar_IdClasificacion(Models.CatClasificacionProducto catClasificacionProducto)
        {
            return _CatProducto.CatProducto_Seleccionar_IdClasificacion(catClasificacionProducto);
        }
        public Models.CatProducto CatProducto_Agregar(Models.CatProducto catProducto)
        {
            return _CatProducto.CatProducto_Agregar(catProducto);
        }
        public Models.CatProducto CatProducto_Eliminar(Models.CatProducto catProducto)
        {
            return _CatProducto.CatProducto_Eliminar(catProducto);
        }
        public Models.CatProducto CatProducto_Editar(Models.CatProducto catProducto)
        {
            return _CatProducto.CatProducto_Editar(catProducto);
        }
        public Models.CatProducto CatProducto_Seleccionar_IdProducto(Models.CatProducto catProducto)
        {
            return _CatProducto.CatProducto_Seleccionar_IdProducto(catProducto);
        }
        public List<Models.CatProducto> CatProducto_Seleccionar_Producto()
        {
            return _CatProducto.CatProducto_Seleccionar_Producto();
        }
        public List<Models.CatProducto> CatProducto_Seleccionar_Producto_IdUsaurio(Models.Usuario usuario)
        {
            return _CatProducto.CatProducto_Seleccionar_Producto_IdUsaurio(usuario);
        }
    }
}