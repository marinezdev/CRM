using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class Tarea
    {
        Data.Tarea _Tarea = new Data.Tarea();
        public Models.Tarea Tarea_Agregar(Models.Consulta.NuevaTarea nuevaTarea)
        {
            return _Tarea.Tarea_Agregar(nuevaTarea);
        }
        public Models.Tarea Tarea_Actulizar_Terminar(Models.Consulta.NuevaTarea nuevaTarea)
        {
            return _Tarea.Tarea_Actulizar_Terminar(nuevaTarea);
        }
        public Models.Tarea Tarea_Actulizar_Cancelar(Models.Consulta.NuevaTarea nuevaTarea)
        {
            return _Tarea.Tarea_Actulizar_Cancelar(nuevaTarea);
        }
        public List<Models.Consulta.NuevaTarea> Tarea_Seleccionar_Entidad_Valor(Models.TareaEntidad tareaEntidad)
        {
            return _Tarea.Tarea_Seleccionar_Entidad_Valor(tareaEntidad);
        }
        public List<Models.Consulta.NuevaTarea> Tarea_Seleccionar_IdUsuario(Models.Usuario usuario)
        {
            return _Tarea.Tarea_Seleccionar_IdUsuario(usuario);
        }
        public List<Models.Consulta.NuevaTarea> Tarea_Seleccionar_IdUsuario_AsignadasPendientes(Models.Usuario usuario)
        {
            return _Tarea.Tarea_Seleccionar_IdUsuario_AsignadasPendientes(usuario);
        }
        public List<Models.Consulta.NuevaTarea> Tarea_Seleccionar_IdUsuario_Asignadas(Models.Usuario usuario)
        {
            return _Tarea.Tarea_Seleccionar_IdUsuario_Asignadas(usuario);
        }
        public List<Models.Consulta.NuevaTarea> Tarea_Seleccionar_Usuairo_Entidad(Models.Consulta.NuevaTarea nuevaTarea)
        {
            return _Tarea.Tarea_Seleccionar_Usuairo_Entidad(nuevaTarea);
        }

        public List<Models.Tarea> Tarea_Seleccionar_Usuairo_Entidad_IdTipoTarea(Models.Consulta.NuevaTarea nuevaTarea)
        {
            return _Tarea.Tarea_Seleccionar_Usuairo_Entidad_IdTipoTarea(nuevaTarea);
        }

        public List<Models.Tarea> Tarea_Selecionar_IdUsuario_Estatus(Models.Consulta.NuevaTarea nuevaTarea)
        {
            return _Tarea.Tarea_Selecionar_IdUsuario_Estatus(nuevaTarea);
        }
    }
}
