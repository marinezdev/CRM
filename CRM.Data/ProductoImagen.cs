using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class ProductoImagen
    {
        ManejoDatos b = new ManejoDatos();
        public Models.ProductoImagen ProductoImagen_Agregar(Models.ProductoImagen productoImagen)
        {
            const string consulta = "ProductoImagen_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdProducto", productoImagen.CatProducto.Id, SqlDbType.Int);
            b.AddParameter("@NmArchivo", productoImagen.NmArchivo, SqlDbType.NVarChar);
            b.AddParameter("@NmOriginal", productoImagen.NmOriginal, SqlDbType.NVarChar);
            b.AddParameter("@ImagenURL", productoImagen.ImagenURL, SqlDbType.NVarChar);

            Models.ProductoImagen resultado = new Models.ProductoImagen();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.ProductoImagen>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
