using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class Oportunidad
    {
        ManejoDatos b = new ManejoDatos();
        public Models.Oportunidad Oportunidad_Agregar(Models.Consulta.Oportunidad oportunidad)
        {
            const string consulta = "Oportunidad_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdPrioridad", oportunidad.CatPrioridad.Id, SqlDbType.Int);
            b.AddParameter("@IdTipo", oportunidad.CatTipoOportunidad.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", oportunidad.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@IdEstatus", oportunidad.CatEstatusOpurtunidad.Id, SqlDbType.Int);
            b.AddParameter("@IdUnidadNegocio", oportunidad.CatUnidadNegocio.Id, SqlDbType.Int);
            b.AddParameter("@Nombre", oportunidad.Nombre, SqlDbType.VarChar);
            b.AddParameter("@Descripcion", oportunidad.Descripcion, SqlDbType.VarChar);
            b.AddParameter("@FechaCierre", oportunidad.OportunidadFechaCierre.Fecha, SqlDbType.Date);
            if (oportunidad.OportunidadPersona == null)
            {
                b.AddParameter("@IdPersona", null, SqlDbType.Int);
                b.AddParameter("@IdRol", null, SqlDbType.Int);
            }
            else
            {
                b.AddParameter("@IdPersona", oportunidad.OportunidadPersona.Persona.Id, SqlDbType.Int);
                b.AddParameter("@IdRol", oportunidad.OportunidadPersona.CatPersonaOportunidad.Id, SqlDbType.Int);
            }

            if (oportunidad.OportunidadEmpresa == null)
            {
                b.AddParameter("@IdEmpresa", null, SqlDbType.Int);
            }
            else
            {
                b.AddParameter("@IdEmpresa", oportunidad.OportunidadEmpresa.Empresa.Id, SqlDbType.Int);
            }

            //if (oportunidad.OportunidadProducto == null)
            //{
            //    b.AddParameter("@IdProducto", null, SqlDbType.Int);
            //    b.AddParameter("@Item", null, SqlDbType.Int);
            //}
            //else
            //{
            //    b.AddParameter("@IdProducto", oportunidad.OportunidadProducto.CatProducto.Id, SqlDbType.Int);
            //    b.AddParameter("@Item", oportunidad.OportunidadProducto.Item, SqlDbType.Int);
            //}

            if (oportunidad.OportunidadImporte == null)
            {
                b.AddParameter("@IdMoneda", null, SqlDbType.Int);
                b.AddParameter("@Valor", null, SqlDbType.Float);
                b.AddParameter("@TipoCambio", null, SqlDbType.Float);
                b.AddParameter("@ObsercionImporte", null, SqlDbType.VarChar);
            }
            else
            {
                b.AddParameter("@IdMoneda", oportunidad.OportunidadImporte.CatMoneda.Id, SqlDbType.Int);
                b.AddParameter("@Valor", oportunidad.OportunidadImporte.Valor, SqlDbType.Float);
                b.AddParameter("@TipoCambio", oportunidad.OportunidadImporte.TipoCambio, SqlDbType.Float);
                b.AddParameter("@ObsercionImporte", oportunidad.OportunidadImporte.Observacion, SqlDbType.VarChar);
            }



            


            Models.Oportunidad resultado = new Models.Oportunidad();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Oportunidad>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar()
        {
            const string consulta = "Oportunidad_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.Oportunidad> resultado = new List<Models.Oportunidad>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Oportunidad>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar_IdEstatus(Models.CatEstatusOpurtunidad catEstatusOpurtunidad)
        {
            const string consulta = "Oportunidad_Seleccionar_IdEstatus";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEstatus", catEstatusOpurtunidad.Id, SqlDbType.Int);

            List<Models.Oportunidad> resultado = new List<Models.Oportunidad>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Oportunidad>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar_IdUnidadNegocio(Models.CatUnidadNegocio catUnidadNegocio)
        {
            const string consulta = "Oportunidad_Seleccionar_IdUnidadNegocio";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUnidadNegocio", catUnidadNegocio.Id, SqlDbType.Int);

            List<Models.Oportunidad> resultado = new List<Models.Oportunidad>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Oportunidad>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar_IdUnidadNegocio_Funnel(Models.CatUnidadNegocio catUnidadNegocio)
        {
            const string consulta = "Oportunidad_Seleccionar_IdUnidadNegocio_Funnel";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUnidadNegocio", catUnidadNegocio.Id, SqlDbType.Int);

            List<Models.Oportunidad> resultado = new List<Models.Oportunidad>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Oportunidad>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar_IdEtapa(Models.CatEtapaOportunidad catEtapaOportunidad)
        {
            const string consulta = "Oportunidad_Seleccionar_IdEtapa";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEtapa", catEtapaOportunidad.Id, SqlDbType.Int);

            List<Models.Oportunidad> resultado = new List<Models.Oportunidad>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Oportunidad>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar_IdEtapa_IdUnidadNegocio(Models.CatEtapaOportunidad catEtapaOportunidad, Models.CatUnidadNegocio catUnidadNegocio)
        {
            const string consulta = "Oportunidad_Seleccionar_IdEtapa_IdUnidadNegocio";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEtapa", catEtapaOportunidad.Id, SqlDbType.Int);
            b.AddParameter("@IdUnidadNegocio", catUnidadNegocio.Id, SqlDbType.Int);

            List<Models.Oportunidad> resultado = new List<Models.Oportunidad>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Oportunidad>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.Oportunidad> Oportunidad_Seleccionar_IdUsuario(Models.Usuario usuario)
        {
            const string consulta = "Oportunidad_Seleccionar_IdUsuario";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUsuario", usuario.Id, SqlDbType.Int);

            List<Models.Oportunidad> resultado = new List<Models.Oportunidad>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Oportunidad>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar_FechaRegistro(Models.Consulta.Actividades actividades)
        {
            const string consulta = "Oportunidad_Seleccionar_FechaRegistro";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Fecha1", actividades.FechaInicio, SqlDbType.Date);
            b.AddParameter("@Fecha2", actividades.FechaTermino, SqlDbType.Date);
            b.AddParameter("@IdUnidadNegocio", actividades.CatUnidadNegocio.Id, SqlDbType.Int);

            List<Models.Oportunidad> resultado = new List<Models.Oportunidad>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Oportunidad>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar_FechaRegistro_IdUsuario(Models.Consulta.Actividades actividades)
        {
            const string consulta = "Oportunidad_Seleccionar_FechaRegistro_IdUsuario";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Fecha1", actividades.FechaInicio, SqlDbType.Date);
            b.AddParameter("@Fecha2", actividades.FechaTermino, SqlDbType.Date);
            b.AddParameter("@IdUsuario", actividades.Usuario.Id, SqlDbType.Int);

            List<Models.Oportunidad> resultado = new List<Models.Oportunidad>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Oportunidad>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar_IdUsuario_Year(Models.Usuario usuario)
        {
            const string consulta = "Oportunidad_Seleccionar_IdUsuario_Year";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUsuario", usuario.Id, SqlDbType.Int);

            List<Models.Oportunidad> resultado = new List<Models.Oportunidad>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Oportunidad>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar_Year()
        {
            const string consulta = "Oportunidad_Seleccionar_Year";
            b.ExecuteCommandSP(consulta);

            List<Models.Oportunidad> resultado = new List<Models.Oportunidad>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Oportunidad>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar_Year_CerradoGanado(Models.Oportunidad oportunidad)
        {
            const string consulta = "Oportunidad_Seleccionar_Year_CerradoGanado";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Year", oportunidad.Year, SqlDbType.Int);

            List<Models.Oportunidad> resultado = new List<Models.Oportunidad>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Oportunidad>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Consulta.Oportunidad Oportunidad_Seleccionar_Id(Models.Oportunidad oportunidad)
        {
            const string consulta = "Oportunidad_Seleccionar_Id";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdOportunidad", oportunidad.Id, SqlDbType.Int);

            Models.Consulta.Oportunidad resultado = new Models.Consulta.Oportunidad();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Consulta.Oportunidad>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Oportunidad Oportunidad_Actualizar(Models.Oportunidad oportunidad)
        {
            const string consulta = "Oportunidad_Actualizar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", oportunidad.Id, SqlDbType.Int);
            b.AddParameter("@IdUnidadNegocio", oportunidad.CatUnidadNegocio.Id, SqlDbType.Int);
            b.AddParameter("@IdTipoOportunidad", oportunidad.CatTipoOportunidad.Id, SqlDbType.Int);
            b.AddParameter("@IdPrioridad", oportunidad.CatPrioridad.Id, SqlDbType.Int);
            b.AddParameter("@Nombre", oportunidad.Nombre, SqlDbType.NVarChar);
            b.AddParameter("@Descripcion", oportunidad.Descripcion, SqlDbType.NVarChar);
            b.AddParameter("@IdUsuario", oportunidad.Usuario.Id, SqlDbType.Int);

            Models.Oportunidad resultado = new Models.Oportunidad();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Oportunidad>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Oportunidad Oportunidad_Actualizar_IdEstatus(Models.Oportunidad oportunidad)
        {
            const string consulta = "Oportunidad_Actualizar_IdEstatus";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdOportunidad", oportunidad.Id, SqlDbType.Int);
            b.AddParameter("@IdEstatus", oportunidad.CatEstatusOpurtunidad.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", oportunidad.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@FechaCierre", oportunidad.FechaCierre, SqlDbType.Date);
            b.AddParameter("@Clave", oportunidad.Clave, SqlDbType.NVarChar);
            b.AddParameter("@Descripcion", oportunidad.Descripcion, SqlDbType.NVarChar);

            Models.Oportunidad resultado = new Models.Oportunidad();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Oportunidad>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Oportunidad Oportunidad_Actualizar_FechaCierre(Models.Oportunidad oportunidad)
        {
            const string consulta = "Oportunidad_Actualizar_FechaCierre";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdOportunidad", oportunidad.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", oportunidad.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@FechaCierre", oportunidad.FechaCierre, SqlDbType.Date);
            b.AddParameter("@Clave", oportunidad.Clave, SqlDbType.NVarChar);
            b.AddParameter("@Descripcion", oportunidad.Descripcion, SqlDbType.NVarChar);

            Models.Oportunidad resultado = new Models.Oportunidad();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Oportunidad>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Consulta.Oportunidad> Oportunidad_Dhasbord_Seleccionar_Importe()
        {
            const string consulta = "Oportunidad_Dhasbord_Seleccionar_Importe";
            b.ExecuteCommandSP(consulta);

            List<Models.Consulta.Oportunidad> resultado = new List<Models.Consulta.Oportunidad>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.Oportunidad>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Consulta.Oportunidad> Oportunidad_Dhasbord_Seleccionar_Importe_UnidadDeNegocio()
        {
            const string consulta = "Oportunidad_Dhasbord_Seleccionar_Importe_UnidadDeNegocio";
            b.ExecuteCommandSP(consulta);

            List<Models.Consulta.Oportunidad> resultado = new List<Models.Consulta.Oportunidad>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.Oportunidad>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public DataTable Oportunidad_Dhasbord_Seleccionar_Usuarios()
        {
            string consulta = "";
            consulta = "EXECUTE Oportunidad_Dhasbord_Seleccionar_Usuarios";

            b.ExecuteCommandQuery(consulta);
            return b.Select();
        }
        public List<Models.Consulta.UnidadNegocio> Oportunidad_Contar_UnidadNegocio()
        {
            const string consulta = "Oportunidad_Contar_UnidadNegocio";
            b.ExecuteCommandSP(consulta);

            List<Models.Consulta.UnidadNegocio> resultado = new List<Models.Consulta.UnidadNegocio>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.UnidadNegocio>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
