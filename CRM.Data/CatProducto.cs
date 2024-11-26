using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatProducto
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatProducto> CatProducto_Seleccionar()
        {
            const string consulta = "CatProducto_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatProducto> resultado = new List<Models.CatProducto>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatProducto>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.CatProducto> CatProducto_Seleccionar_IdClasificacion(Models.CatClasificacionProducto catClasificacionProducto)
        {
            const string consulta = "CatProducto_Seleccionar_IdClasificacion";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdClasificacion", catClasificacionProducto.Id, SqlDbType.VarChar);

            List<Models.CatProducto> resultado = new List<Models.CatProducto>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatProducto>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.CatProducto CatProducto_Agregar(Models.CatProducto catProducto)
        {
            const string consulta = "CatProducto_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdClasificacion", catProducto.CatClasificacionProducto.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", catProducto.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@Nombre", catProducto.Nombre, SqlDbType.VarChar);
            b.AddParameter("@SKU", catProducto.SKU, SqlDbType.VarChar);
            b.AddParameter("@Descripcion", catProducto.Descripcion, SqlDbType.VarChar);

            Models.CatProducto resultado = new Models.CatProducto();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CatProducto>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.CatProducto CatProducto_Eliminar(Models.CatProducto catProducto)
        {
            const string consulta = "CatProducto_Eliminar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", catProducto.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", catProducto.Usuario.Id, SqlDbType.Int);
            
            Models.CatProducto resultado = new Models.CatProducto();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CatProducto>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.CatProducto CatProducto_Editar(Models.CatProducto catProducto)
        {
            const string consulta = "CatProducto_Editar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", catProducto.Id, SqlDbType.Int);
            b.AddParameter("@IdClasificacion", catProducto.CatClasificacionProducto.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", catProducto.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@Nombre", catProducto.Nombre, SqlDbType.VarChar);
            b.AddParameter("@SKU", catProducto.SKU, SqlDbType.VarChar);
            b.AddParameter("@Descripcion", catProducto.Descripcion, SqlDbType.VarChar);

            Models.CatProducto resultado = new Models.CatProducto();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CatProducto>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.CatProducto CatProducto_Seleccionar_IdProducto(Models.CatProducto catProducto)
        {
            const string consulta = "CatProducto_Seleccionar_IdProducto";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdProducto", catProducto.Id, SqlDbType.Int);

            Models.CatProducto resultado = new Models.CatProducto();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CatProducto>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.CatProducto> CatProducto_Seleccionar_Producto()
        {
            const string consulta = "CatProducto_Seleccionar_Producto";
            b.ExecuteCommandSP(consulta);

            List<Models.CatProducto> resultado = new List<Models.CatProducto>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatProducto>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.CatProducto> CatProducto_Seleccionar_Producto_IdUsaurio(Models.Usuario usuario)
        {
            const string consulta = "CatProducto_Seleccionar_Producto_IdUsaurio";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUsuario", usuario.Id, SqlDbType.Int);

            List<Models.CatProducto> resultado = new List<Models.CatProducto>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatProducto>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
