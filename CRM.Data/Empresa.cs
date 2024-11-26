using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class Empresa
    {
        ManejoDatos b = new ManejoDatos();
        public Models.Empresa Empresa_Agregar(Models.Empresa empresa)
        {
            const string consulta = "Empresa_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdIndustria", empresa.CatIndustria.Id, SqlDbType.Int);
            b.AddParameter("@IdTipo", empresa.CatTipoEmpresa.Id, SqlDbType.Int);
            b.AddParameter("@IdFuenteOrigen", empresa.CatFuenteOrigen.Id, SqlDbType.Int);
            b.AddParameter("@IdNumEmpleados", empresa.CatNumeroEmpleados.Id, SqlDbType.Int);
            b.AddParameter("@IdIngresoAnual", empresa.CatIngresoAnual.Id, SqlDbType.Int);
            b.AddParameter("@IdUnidadNegocio", empresa.CatUnidadNegocio.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", empresa.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@Nombre", empresa.Nombre, SqlDbType.VarChar);
            b.AddParameter("@Alias", empresa.Alias, SqlDbType.VarChar);
            b.AddParameter("@RFC", empresa.RFC, SqlDbType.VarChar);
            b.AddParameter("@Descripcion", empresa.Descripcion, SqlDbType.VarChar);
            b.AddParameter("@PaginaWeb", empresa.PaginaWeb, SqlDbType.VarChar);

            Models.Empresa resultado = new Models.Empresa();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Empresa>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Empresa Empresa_Actualizar(Models.Empresa empresa)
        {
            const string consulta = "Empresa_Actualizar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEmpresa", empresa.Id, SqlDbType.Int);
            b.AddParameter("@IdIndustria", empresa.CatIndustria.Id, SqlDbType.Int);
            b.AddParameter("@IdTipo", empresa.CatTipoEmpresa.Id, SqlDbType.Int);
            b.AddParameter("@IdFuenteOrigen", empresa.CatFuenteOrigen.Id, SqlDbType.Int);
            b.AddParameter("@IdNumEmpleados", empresa.CatNumeroEmpleados.Id, SqlDbType.Int);
            b.AddParameter("@IdIngresoAnual", empresa.CatIngresoAnual.Id, SqlDbType.Int);
            b.AddParameter("@IdUnidadNegocio", empresa.CatUnidadNegocio.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", empresa.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@Nombre", empresa.Nombre, SqlDbType.VarChar);
            b.AddParameter("@Alias", empresa.Alias, SqlDbType.VarChar);
            b.AddParameter("@RFC", empresa.RFC, SqlDbType.VarChar);
            b.AddParameter("@Descripcion", empresa.Descripcion, SqlDbType.VarChar);
            b.AddParameter("@PaginaWeb", empresa.PaginaWeb, SqlDbType.VarChar);

            Models.Empresa resultado = new Models.Empresa();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Empresa>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Empresa Empresa_Actualizar_Estatus(Models.Empresa empresa)
        {
            const string consulta = "Empresa_Actualizar_Estatus";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEmpresa", empresa.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", empresa.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@Activo", empresa.Activo, SqlDbType.Int);
            b.AddParameter("@Descripcion", empresa.Descripcion, SqlDbType.VarChar);
            b.AddParameter("@Clave", empresa.Clave, SqlDbType.VarChar);

            Models.Empresa resultado = new Models.Empresa();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Empresa>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Empresa Empresa_ActualizarImagen(Models.Empresa empresa)
        {
            const string consulta = "Empresa_ActualizarImagen";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEmpresa", empresa.Id, SqlDbType.Int);
            b.AddParameter("@Imagen", empresa.Imagen, SqlDbType.VarChar);
            b.AddParameter("@ImagenURL", empresa.ImagenURL, SqlDbType.VarChar);
            b.AddParameter("@IdUsuario", empresa.Usuario.Id, SqlDbType.Int);

            Models.Empresa resultado = new Models.Empresa();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Empresa>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Empresa> Empresa_Selecionar_Nombre(Models.Empresa empresa)
        {
            const string consulta = "Empresa_Selecionar_Nombre";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Nombre", empresa.Nombre, SqlDbType.VarChar);

            List<Models.Empresa> resultado = new List<Models.Empresa>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Empresa>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Empresa> Empresa_Seleccionar()
        {
            const string consulta = "Empresa_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.Empresa> resultado = new List<Models.Empresa>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Empresa>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Empresa> Empresa_Seleccionar_UnidadNegocio(Models.CatUnidadNegocio catUnidadNegocio)
        {
            const string consulta = "Empresa_Seleccionar_UnidadNegocio";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUnidadNegocio", catUnidadNegocio.Id, SqlDbType.VarChar);

            List<Models.Empresa> resultado = new List<Models.Empresa>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Empresa>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Empresa> Empresa_Seleccionar_FechaRegistro(Models.Consulta.Actividades actividades)
        {
            const string consulta = "Empresa_Seleccionar_FechaRegistro";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Fecha1", actividades.FechaInicio, SqlDbType.Date);
            b.AddParameter("@Fecha2", actividades.FechaTermino, SqlDbType.Date);
            b.AddParameter("@IdUnidadNegocio", actividades.CatUnidadNegocio.Id, SqlDbType.Int);

            List<Models.Empresa> resultado = new List<Models.Empresa>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Empresa>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Empresa> Empresa_Seleccionar_FechaRegistro_IdUsuario(Models.Consulta.Actividades actividades)
        {
            const string consulta = "Empresa_Seleccionar_FechaRegistro_IdUsuario";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Fecha1", actividades.FechaInicio, SqlDbType.Date);
            b.AddParameter("@Fecha2", actividades.FechaTermino, SqlDbType.Date);
            b.AddParameter("@IdUsuario", actividades.Usuario.Id, SqlDbType.Int);

            List<Models.Empresa> resultado = new List<Models.Empresa>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Empresa>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Empresa> Empresa_Seleccionar_IdUsuario(Models.Usuario usuario)
        {
            const string consulta = "Empresa_Seleccionar_IdUsuario";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", usuario.Id, SqlDbType.Int);

            List<Models.Empresa> resultado = new List<Models.Empresa>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Empresa>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Empresa> Empresa_Seleccionar_IdUsuario_Bajas(Models.Usuario usuario)
        {
            const string consulta = "Empresa_Seleccionar_IdUsuario_Bajas";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", usuario.Id, SqlDbType.Int);

            List<Models.Empresa> resultado = new List<Models.Empresa>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Empresa>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Empresa> Empresa_Seleccionar_Oportunidad()
        {
            const string consulta = "Empresa_Seleccionar_Oportunidad";
            b.ExecuteCommandSP(consulta);

            List<Models.Empresa> resultado = new List<Models.Empresa>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Empresa>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Empresa Empresa_Seleccionar_Id(Models.Empresa empresa)
        {
            const string consulta = "Empresa_Seleccionar_Id";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEmpresa", empresa.Id, SqlDbType.Int);

            Models.Empresa resultado = new Models.Empresa();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Empresa>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Consulta.UnidadNegocio> Empresa_Contar_UnidadNegocio()
        {
            const string consulta = "Empresa_Contar_UnidadNegocio";
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
