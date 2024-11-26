using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class Archivo
    {
        Data.Archivo _archivo = new Data.Archivo();
        public Models.Archivo Archivo_Agregar(Models.ArchivoEntidad archivoEntidad)
        {
            return _archivo.Archivo_Agregar(archivoEntidad);
        }
        public Models.Archivo Archivo_Eliminar(Models.Archivo archivo)
        {
            return _archivo.Archivo_Eliminar(archivo);
        }
        public Models.Archivo Archivo_Seleccionar_Id(Models.Archivo archivo)
        {
            return _archivo.Archivo_Seleccionar_Id(archivo);
        }
        public List<Models.Archivo> Archivo_Seleccionar_Entidad_Valor(Models.ArchivoEntidad archivoEntidad)
        {
            return _archivo.Archivo_Seleccionar_Entidad_Valor(archivoEntidad);
        }
    }
}
