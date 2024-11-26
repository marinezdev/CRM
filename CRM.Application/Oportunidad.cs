using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class Oportunidad
    {
        Data.Oportunidad _Oportunidad = new Data.Oportunidad();
        public Models.Oportunidad Oportunidad_Agregar(Models.Consulta.Oportunidad oportunidad)
        {
            return _Oportunidad.Oportunidad_Agregar(oportunidad);
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar()
        {
            return _Oportunidad.Oportunidad_Seleccionar();
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar_IdEstatus(Models.CatEstatusOpurtunidad catEstatusOpurtunidad)
        {
            return _Oportunidad.Oportunidad_Seleccionar_IdEstatus(catEstatusOpurtunidad);
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar_IdUnidadNegocio(Models.CatUnidadNegocio catUnidadNegocio)
        {
            return _Oportunidad.Oportunidad_Seleccionar_IdUnidadNegocio(catUnidadNegocio);
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar_IdUnidadNegocio_Funnel(Models.CatUnidadNegocio catUnidadNegocio)
        {
            return _Oportunidad.Oportunidad_Seleccionar_IdUnidadNegocio_Funnel(catUnidadNegocio);
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar_IdEtapa(Models.CatEtapaOportunidad catEtapaOportunidad)
        {
            return _Oportunidad.Oportunidad_Seleccionar_IdEtapa(catEtapaOportunidad);
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar_IdEtapa_IdUnidadNegocio(Models.CatEtapaOportunidad catEtapaOportunidad, Models.CatUnidadNegocio catUnidadNegocio)
        {
            return _Oportunidad.Oportunidad_Seleccionar_IdEtapa_IdUnidadNegocio(catEtapaOportunidad, catUnidadNegocio);
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar_IdUsuario(Models.Usuario usuario)
        {
            return _Oportunidad.Oportunidad_Seleccionar_IdUsuario(usuario);
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar_FechaRegistro(Models.Consulta.Actividades actividades)
        {
            return _Oportunidad.Oportunidad_Seleccionar_FechaRegistro(actividades);
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar_FechaRegistro_IdUsuario(Models.Consulta.Actividades actividades)
        {
            return _Oportunidad.Oportunidad_Seleccionar_FechaRegistro_IdUsuario(actividades);
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar_IdUsuario_Year(Models.Usuario usuario)
        {
            return _Oportunidad.Oportunidad_Seleccionar_IdUsuario_Year(usuario);
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar_Year()
        {
            return _Oportunidad.Oportunidad_Seleccionar_Year();
        }
        public List<Models.Oportunidad> Oportunidad_Seleccionar_Year_CerradoGanado(Models.Oportunidad oportunidad)
        {
            return _Oportunidad.Oportunidad_Seleccionar_Year_CerradoGanado(oportunidad);
        }
        public Models.Consulta.Oportunidad Oportunidad_Seleccionar_Id(Models.Oportunidad oportunidad)
        {
            return _Oportunidad.Oportunidad_Seleccionar_Id(oportunidad);
        }
        public Models.Oportunidad Oportunidad_Actualizar(Models.Oportunidad oportunidad)
        {
            return _Oportunidad.Oportunidad_Actualizar(oportunidad);
        }
        public Models.Oportunidad Oportunidad_Actualizar_IdEstatus(Models.Oportunidad oportunidad)
        {
            return _Oportunidad.Oportunidad_Actualizar_IdEstatus(oportunidad);
        }
        public Models.Oportunidad Oportunidad_Actualizar_FechaCierre(Models.Oportunidad oportunidad)
        {
            return _Oportunidad.Oportunidad_Actualizar_FechaCierre(oportunidad);
        }
        public List<Models.Consulta.Oportunidad> Oportunidad_Dhasbord_Seleccionar_Importe()
        {
            return _Oportunidad.Oportunidad_Dhasbord_Seleccionar_Importe();
        }
        public List<Models.Consulta.Oportunidad> Oportunidad_Dhasbord_Seleccionar_Importe_UnidadDeNegocio()
        {
            return _Oportunidad.Oportunidad_Dhasbord_Seleccionar_Importe_UnidadDeNegocio();
        }
        public DataTable Oportunidad_Dhasbord_Seleccionar_Usuarios()
        {
            return _Oportunidad.Oportunidad_Dhasbord_Seleccionar_Usuarios();
        }
        public List<Models.Consulta.UnidadNegocio> Oportunidad_Contar_UnidadNegocio()
        {
            return _Oportunidad.Oportunidad_Contar_UnidadNegocio();
        }
    }
}
