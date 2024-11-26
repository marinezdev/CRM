using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class Archivo
    {
        ManejoDatos b = new ManejoDatos();
        public Models.Archivo Archivo_Agregar(Models.ArchivoEntidad archivoEntidad)
        {
            const string consulta = "Archivo_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUsuario", archivoEntidad.Archivo.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@IdEntidad", archivoEntidad.CatEntidad.Id, SqlDbType.Int);
            b.AddParameter("@IdValorEntidad", archivoEntidad.IdValorEntidad, SqlDbType.Int);
            b.AddParameter("@NombreOrigianl", archivoEntidad.Archivo.NombreOrigianl, SqlDbType.NVarChar);
            b.AddParameter("@NombreNuevo", archivoEntidad.Archivo.NombreNuevo, SqlDbType.NVarChar);
            b.AddParameter("@Extencion", archivoEntidad.Archivo.Extencion, SqlDbType.NVarChar);

            Models.Archivo resultado = new Models.Archivo();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Archivo>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Archivo Archivo_Eliminar(Models.Archivo archivo)
        {
            const string consulta = "Archivo_Eliminar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", archivo.Id, SqlDbType.Int);

            Models.Archivo resultado = new Models.Archivo();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Archivo>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Archivo Archivo_Seleccionar_Id(Models.Archivo archivo)
        {
            const string consulta = "Archivo_Seleccionar_Id";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", archivo.Id, SqlDbType.Int);

            Models.Archivo resultado = new Models.Archivo();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Archivo>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Archivo> Archivo_Seleccionar_Entidad_Valor(Models.ArchivoEntidad archivoEntidad)
        {
            const string consulta = "Archivo_Seleccionar_Entidad_Valor";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEntidad", archivoEntidad.CatEntidad.Id, SqlDbType.Int);
            b.AddParameter("@IdValorEntidad", archivoEntidad.IdValorEntidad, SqlDbType.Int);


            List<Models.Archivo> resultado = new List<Models.Archivo>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Archivo>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
