using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class Tarea
    {
        ManejoDatos b = new ManejoDatos();
        public Models.Tarea Tarea_Agregar(Models.Consulta.NuevaTarea nuevaTarea)
        {
            const string consulta = "Tarea_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdTarea", nuevaTarea.Tarea.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", nuevaTarea.Tarea.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@IdPersona", nuevaTarea.TareaPersona.Persona.Id, SqlDbType.Int);
            b.AddParameter("@IdEntidad", nuevaTarea.TareaEntidad.CatEntidad.Id, SqlDbType.Int);
            b.AddParameter("@IdValorEntidad", nuevaTarea.TareaEntidad.IdValorEntidad, SqlDbType.Int);
            b.AddParameter("@Titulo", nuevaTarea.Tarea.Titulo, SqlDbType.NVarChar);
            b.AddParameter("@IdFechaVencimiento", nuevaTarea.Tarea.CatFechaVencimiento.Id, SqlDbType.Int);
            b.AddParameter("@FechaVencimiento", nuevaTarea.Tarea.FechaVencimiento, SqlDbType.Date);
            b.AddParameter("@IdRecordatorio", nuevaTarea.Tarea.CatRecordatorio.Id, SqlDbType.Int);
            b.AddParameter("@FechaRecordatorio", nuevaTarea.Tarea.FechaRecordatorio, SqlDbType.Date);
            b.AddParameter("@IdTipoTarea", nuevaTarea.TareaPersona.CatTipoTarea.Id, SqlDbType.Int);
            b.AddParameter("@IdPrioridad", nuevaTarea.TareaPersona.CatPrioridad.Id, SqlDbType.Int);
            b.AddParameter("@Nota", nuevaTarea.Tarea.Notas, SqlDbType.NVarChar);

            Models.Tarea resultado = new Models.Tarea();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Tarea>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.Tarea Tarea_Actulizar_Terminar(Models.Consulta.NuevaTarea nuevaTarea)
        {
            const string consulta = "Tarea_Actulizar_Terminar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUsuario", nuevaTarea.Tarea.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@Idtarea", nuevaTarea.Tarea.Id, SqlDbType.Int);
            b.AddParameter("@IdEntidad", nuevaTarea.TareaEntidad.CatEntidad.Id, SqlDbType.Int);
            b.AddParameter("@IdValorEntidad", nuevaTarea.TareaEntidad.IdValorEntidad, SqlDbType.Int);
            b.AddParameter("@Notas", nuevaTarea.Tarea.Notas, SqlDbType.NVarChar);
            b.AddParameter("@Clave", nuevaTarea.Clave, SqlDbType.NVarChar);

            Models.Tarea resultado = new Models.Tarea();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Tarea>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.Tarea Tarea_Actulizar_Cancelar(Models.Consulta.NuevaTarea nuevaTarea)
        {
            const string consulta = "Tarea_Actulizar_Cancelar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUsuario", nuevaTarea.Tarea.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@Idtarea", nuevaTarea.Tarea.Id, SqlDbType.Int);
            b.AddParameter("@IdEntidad", nuevaTarea.TareaEntidad.CatEntidad.Id, SqlDbType.Int);
            b.AddParameter("@IdValorEntidad", nuevaTarea.TareaEntidad.IdValorEntidad, SqlDbType.Int);
            b.AddParameter("@Notas", nuevaTarea.Tarea.Notas, SqlDbType.NVarChar);
            b.AddParameter("@Clave", nuevaTarea.Clave, SqlDbType.NVarChar);

            Models.Tarea resultado = new Models.Tarea();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Tarea>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.Consulta.NuevaTarea> Tarea_Seleccionar_Entidad_Valor(Models.TareaEntidad tareaEntidad)
        {
            const string consulta = "Tarea_Seleccionar_Entidad_Valor";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEntidad", tareaEntidad.CatEntidad.Id, SqlDbType.Int);
            b.AddParameter("@IdValorEntidad", tareaEntidad.IdValorEntidad, SqlDbType.Int);

            List<Models.Consulta.NuevaTarea> resultado = new List<Models.Consulta.NuevaTarea>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.NuevaTarea>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.Consulta.NuevaTarea> Tarea_Seleccionar_IdUsuario(Models.Usuario usuario)
        {
            const string consulta = "Tarea_Seleccionar_IdUsuario";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUsuario", usuario.Id, SqlDbType.Int);

            List<Models.Consulta.NuevaTarea> resultado = new List<Models.Consulta.NuevaTarea>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.NuevaTarea>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Consulta.NuevaTarea> Tarea_Seleccionar_IdUsuario_AsignadasPendientes(Models.Usuario usuario)
        {
            const string consulta = "Tarea_Seleccionar_IdUsuario_AsignadasPendientes";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUsuario", usuario.Id, SqlDbType.Int);

            List<Models.Consulta.NuevaTarea> resultado = new List<Models.Consulta.NuevaTarea>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.NuevaTarea>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Consulta.NuevaTarea> Tarea_Seleccionar_IdUsuario_Asignadas(Models.Usuario usuario)
        {
            const string consulta = "Tarea_Seleccionar_IdUsuario_Asignadas";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUsuario", usuario.Id, SqlDbType.Int);

            List<Models.Consulta.NuevaTarea> resultado = new List<Models.Consulta.NuevaTarea>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.NuevaTarea>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Consulta.NuevaTarea> Tarea_Seleccionar_Usuairo_Entidad(Models.Consulta.NuevaTarea nuevaTarea)
        {
            const string consulta = "Tarea_Seleccionar_Usuairo_Entidad";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUsuario", nuevaTarea.Tarea.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@IdEntidad", nuevaTarea.TareaEntidad.CatEntidad.Id, SqlDbType.Int);
            b.AddParameter("@IdValorEntidad", nuevaTarea.TareaEntidad.IdValorEntidad, SqlDbType.Int);

            List<Models.Consulta.NuevaTarea> resultado = new List<Models.Consulta.NuevaTarea>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.NuevaTarea>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.Tarea> Tarea_Seleccionar_Usuairo_Entidad_IdTipoTarea(Models.Consulta.NuevaTarea nuevaTarea)
        {
            const string consulta = "Tarea_Seleccionar_Usuairo_Entidad_IdTipoTarea";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUsuario", nuevaTarea.Tarea.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@IdEntidad", nuevaTarea.TareaEntidad.CatEntidad.Id, SqlDbType.Int);
            b.AddParameter("@IdValorEntidad", nuevaTarea.TareaEntidad.IdValorEntidad, SqlDbType.Int);
            b.AddParameter("@IdTipoTarea", nuevaTarea.TareaPersona.CatTipoTarea.Id, SqlDbType.Int);

            List<Models.Tarea> resultado = new List<Models.Tarea>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Tarea>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.Tarea> Tarea_Selecionar_IdUsuario_Estatus(Models.Consulta.NuevaTarea nuevaTarea)
        {
            const string consulta = "Tarea_Selecionar_IdUsuario_Estatus";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUsuario", nuevaTarea.Tarea.Usuario.Id, SqlDbType.Int);

            List<Models.Tarea> resultado = new List<Models.Tarea>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Tarea>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
