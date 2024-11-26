using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class ProductoImagen
    {
        Data.ProductoImagen _ProductoImagen = new Data.ProductoImagen();
        public Models.ProductoImagen ProductoImagen_Agregar(Models.ProductoImagen productoImagen)
        {
            return _ProductoImagen.ProductoImagen_Agregar(productoImagen);
        }
    }
}
