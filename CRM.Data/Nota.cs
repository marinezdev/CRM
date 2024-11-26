using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class Nota
    {
        ManejoDatos b = new ManejoDatos();
        public Models.Nota Nota_Agregar(Models.NotaEntidad notaEntidad)
        {
            const string consulta = "Nota_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUsuario", notaEntidad.Nota.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@IdEntidad", notaEntidad.CatEntidad.Id, SqlDbType.Int);
            b.AddParameter("@IdValorEntidad", notaEntidad.IdValorEntidad, SqlDbType.Int);
            b.AddParameter("@Nota", notaEntidad.Nota.nota, SqlDbType.VarChar);

            Models.Nota resultado = new Models.Nota();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Nota>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Nota> Nota_Seleccionar_Entidad_Valor(Models.NotaEntidad notaEntidad)
        {
            const string consulta = "Nota_Seleccionar_Entidad_Valor";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEntidad", notaEntidad.CatEntidad.Id, SqlDbType.Int);
            b.AddParameter("@IdValorEntidad", notaEntidad.IdValorEntidad, SqlDbType.Int);

            List<Models.Nota> resultado = new List<Models.Nota>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Nota>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
