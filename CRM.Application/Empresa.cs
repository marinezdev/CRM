using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class Empresa
    {
        Data.Empresa _Empresa = new Data.Empresa();

        public Models.Empresa Empresa_Agregar(Models.Empresa empresa)
        {
            return _Empresa.Empresa_Agregar(empresa);
        }
        public Models.Empresa Empresa_Actualizar(Models.Empresa empresa)
        {
            return _Empresa.Empresa_Actualizar(empresa);
        }
        public Models.Empresa Empresa_Actualizar_Estatus(Models.Empresa empresa)
        {
            return _Empresa.Empresa_Actualizar_Estatus(empresa);
        }
        public Models.Empresa Empresa_ActualizarImagen(Models.Empresa empresa)
        {
            return _Empresa.Empresa_ActualizarImagen(empresa);
        }
        public List<Models.Empresa> Empresa_Selecionar_Nombre(Models.Empresa empresa)
        {
            return _Empresa.Empresa_Selecionar_Nombre(empresa);
        }
        public List<Models.Empresa> Empresa_Seleccionar_UnidadNegocio(Models.CatUnidadNegocio catUnidadNegocio)
        {
            return _Empresa.Empresa_Seleccionar_UnidadNegocio(catUnidadNegocio);
        }
        public List<Models.Empresa> Empresa_Seleccionar_FechaRegistro(Models.Consulta.Actividades actividades)
        {
            return _Empresa.Empresa_Seleccionar_FechaRegistro(actividades);
        }
        public List<Models.Empresa> Empresa_Seleccionar_FechaRegistro_IdUsuario(Models.Consulta.Actividades actividades)
        {
            return _Empresa.Empresa_Seleccionar_FechaRegistro_IdUsuario(actividades);
        }
        public List<Models.Empresa> Empresa_Seleccionar()
        {
            return _Empresa.Empresa_Seleccionar();
        }
        public List<Models.Empresa> Empresa_Seleccionar_IdUsuario(Models.Usuario usuario)
        {
            return _Empresa.Empresa_Seleccionar_IdUsuario(usuario);
        }
        public List<Models.Empresa> Empresa_Seleccionar_IdUsuario_Bajas(Models.Usuario usuario)
        {
            return _Empresa.Empresa_Seleccionar_IdUsuario_Bajas(usuario);
        }
        public List<Models.Empresa> Empresa_Seleccionar_Oportunidad()
        {
            return _Empresa.Empresa_Seleccionar_Oportunidad();
        }
        public Models.Empresa Empresa_Seleccionar_Id(Models.Empresa empresa)
        {
            return _Empresa.Empresa_Seleccionar_Id(empresa);
        }
        public List<Models.Consulta.UnidadNegocio> Empresa_Contar_UnidadNegocio()
        {
            return _Empresa.Empresa_Contar_UnidadNegocio();
        }
    }
}