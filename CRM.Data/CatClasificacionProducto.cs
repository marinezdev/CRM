using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatClasificacionProducto
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatClasificacionProducto> CatClasificacionProducto_Seleccionar(Models.CatSubcategoriaProducto catSubcategoriaProducto)
        {
            const string consulta = "CatClasificacionProducto_Seleccionar_IdSubCategoria";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdSubCategoria", catSubcategoriaProducto.Id, SqlDbType.VarChar);

            List<Models.CatClasificacionProducto> resultado = new List<Models.CatClasificacionProducto>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatClasificacionProducto>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.CatClasificacionProducto CatClasificacionProducto_Agregar(Models.CatClasificacionProducto catClasificacionProducto)
        {
            const string consulta = "CatClasificacionProducto_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdSubCategoria", catClasificacionProducto.CatSubcategoriaProducto.Id, SqlDbType.VarChar);
            b.AddParameter("@Nombre", catClasificacionProducto.Nombre, SqlDbType.VarChar);

            Models.CatClasificacionProducto resultado = new Models.CatClasificacionProducto();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CatClasificacionProducto>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
