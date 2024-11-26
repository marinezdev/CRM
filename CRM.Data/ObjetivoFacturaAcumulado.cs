using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class ObjetivoFacturaAcumulado
    {
        ManejoDatos b = new ManejoDatos();
        public Models.ObjetivoFacturaAcumulado ObjetivoFacturaAcumulado_Mes_Agregar(Models.ObjetivoFacturaAcumulado objetivoFacturaAcumulado)
        {
            const string consulta = "ObjetivoFacturaAcumulado_Mes_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdObjetivo", objetivoFacturaAcumulado.ObjetivosResponsables.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", objetivoFacturaAcumulado.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@Monto", objetivoFacturaAcumulado.Monto, SqlDbType.Float);

            Models.ObjetivoFacturaAcumulado resultado = new Models.ObjetivoFacturaAcumulado();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.ObjetivoFacturaAcumulado>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.ObjetivoFacturaAcumulado> ObjetivoFacturaAcumulado_Seleccionar_IdObjetivo(Models.ObjetivosResponsables objetivosResponsables)
        {
            const string consulta = "ObjetivoFacturaAcumulado_Seleccionar_IdObjetivo";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdObjetivo", objetivosResponsables.Id, SqlDbType.Int);

            List<Models.ObjetivoFacturaAcumulado> resultado = new List<Models.ObjetivoFacturaAcumulado>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.ObjetivoFacturaAcumulado>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        
        public Models.ObjetivoFacturaAcumulado ObjetivoFacturaAcumulado_Agregar_Mes(Models.ObjetivoFacturaAcumulado objetivoFacturaAcumulado)
        {
            const string consulta = "ObjetivoFacturaAcumulado_Agregar_Mes";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdObjetivo", objetivoFacturaAcumulado.ObjetivosResponsables.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", objetivoFacturaAcumulado.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@Monto", objetivoFacturaAcumulado.Monto, SqlDbType.Float);
            b.AddParameter("@Mes", objetivoFacturaAcumulado.Mes, SqlDbType.Int);

            Models.ObjetivoFacturaAcumulado resultado = new Models.ObjetivoFacturaAcumulado();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.ObjetivoFacturaAcumulado>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.ObjetivoFacturaAcumulado ObjetivoFacturaAcumulado_Eliminar_Mes(Models.ObjetivoFacturaAcumulado objetivoFacturaAcumulado)
        {
            const string consulta = "ObjetivoFacturaAcumulado_Eliminar_Mes";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdObjetivo", objetivoFacturaAcumulado.ObjetivosResponsables.Id, SqlDbType.Int);
            b.AddParameter("@Mes", objetivoFacturaAcumulado.Mes, SqlDbType.Int);

            Models.ObjetivoFacturaAcumulado resultado = new Models.ObjetivoFacturaAcumulado();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.ObjetivoFacturaAcumulado>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.ObjetivoFacturaAcumulado> ObjetivoFacturaAcumulado_IdUnidadNegocio(Models.CatUnidadNegocio catUnidadNegocio)
        {
            const string consulta = "ObjetivoFacturaAcumulado_IdUnidadNegocio";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUnidadNegocio", catUnidadNegocio.Id, SqlDbType.Int);

            List<Models.ObjetivoFacturaAcumulado> resultado = new List<Models.ObjetivoFacturaAcumulado>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.ObjetivoFacturaAcumulado>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }


        //////////////////////////////////// ATULIZAR REPORTE DE VENTAS
        ////////////////////////////////////
        ////////////////////////////////////
        public List<Models.ObjetivoFacturaAcumulado> ObjetivoFacturaAcumulado_Seleccionar_IdObjetivoYear(Models.ObjetivosResponsables objetivosResponsables)
        {
            const string consulta = "ObjetivoFacturaAcumulado_Seleccionar_IdObjetivoYear";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdObjetivo", objetivosResponsables.Id, SqlDbType.Int);
            b.AddParameter("@Year", objetivosResponsables.year, SqlDbType.Int);

            List<Models.ObjetivoFacturaAcumulado> resultado = new List<Models.ObjetivoFacturaAcumulado>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.ObjetivoFacturaAcumulado>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.ObjetivoFacturaAcumulado ObjetivoFacturaAcumulado_Agregar_Mes_Year(Models.ObjetivoFacturaAcumulado objetivoFacturaAcumulado)
        {
            const string consulta = "ObjetivoFacturaAcumulado_Agregar_Mes_Year";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdObjetivo", objetivoFacturaAcumulado.ObjetivosResponsables.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", objetivoFacturaAcumulado.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@Monto", objetivoFacturaAcumulado.Monto, SqlDbType.Float);
            b.AddParameter("@Mes", objetivoFacturaAcumulado.Mes, SqlDbType.Int);
            b.AddParameter("@Year", objetivoFacturaAcumulado.Year, SqlDbType.Int);

            Models.ObjetivoFacturaAcumulado resultado = new Models.ObjetivoFacturaAcumulado();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.ObjetivoFacturaAcumulado>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.ObjetivoFacturaAcumulado ObjetivoFacturaAcumulado_Eliminar_Mes_Year(Models.ObjetivoFacturaAcumulado objetivoFacturaAcumulado)
        {
            const string consulta = "ObjetivoFacturaAcumulado_Eliminar_Mes_Year";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdObjetivo", objetivoFacturaAcumulado.ObjetivosResponsables.Id, SqlDbType.Int);
            b.AddParameter("@Mes", objetivoFacturaAcumulado.Mes, SqlDbType.Int);
            b.AddParameter("@Year", objetivoFacturaAcumulado.Year, SqlDbType.Int);

            Models.ObjetivoFacturaAcumulado resultado = new Models.ObjetivoFacturaAcumulado();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.ObjetivoFacturaAcumulado>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
