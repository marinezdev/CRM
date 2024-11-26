using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatSubcategoriaProducto
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatSubcategoriaProducto> CatSubcategoriaProducto_Seleccionar(Models.CatCategoriasProducto catCategoriasProducto)
        {
            const string consulta = "CatSubcategoriaProducto_Seleccionar_IdCategoria";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdCategoria", catCategoriasProducto.Id, SqlDbType.VarChar);

            List<Models.CatSubcategoriaProducto> resultado = new List<Models.CatSubcategoriaProducto>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatSubcategoriaProducto>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.CatSubcategoriaProducto CatSubcategoriaProducto_Agregar(Models.CatSubcategoriaProducto catSubcategoriaProducto)
        {
            const string consulta = "CatSubcategoriaProducto_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdCategoria", catSubcategoriaProducto.CatCategoriasProducto.Id, SqlDbType.VarChar);
            b.AddParameter("@Nombre", catSubcategoriaProducto.Nombre, SqlDbType.VarChar);

            Models.CatSubcategoriaProducto resultado = new Models.CatSubcategoriaProducto();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CatSubcategoriaProducto>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
