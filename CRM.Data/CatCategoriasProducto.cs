using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatCategoriasProducto
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatCategoriasProducto> CatCategoriasProducto_Seleccionar()
        {
            const string consulta = "CatCategoriasProducto_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatCategoriasProducto> resultado = new List<Models.CatCategoriasProducto>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatCategoriasProducto>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.CatCategoriasProducto CatCategoriasProducto_Agregar(Models.CatCategoriasProducto catCategoriasProducto)
        {
            const string consulta = "CatCategoriasProducto_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Nombre", catCategoriasProducto.Nombre, SqlDbType.VarChar);

            Models.CatCategoriasProducto resultado = new Models.CatCategoriasProducto();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CatCategoriasProducto>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
