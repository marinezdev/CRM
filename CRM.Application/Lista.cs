using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class Lista
    {
        Data.Lista _Lista = new Data.Lista();
        public List<Models.Lista> Lista_Read(Models.Lista lista)
        {
            return _Lista.Lista_Read(lista);
        }
        public List<Models.Lista> Lista_Read_UserIdCampaing(Models.Lista lista)
        {
            return _Lista.Lista_Read_UserIdCampaing(lista);
        }
        public List<Models.Lista> Lista_Read_IdUser(Models.Lista lista)
        {
            return _Lista.Lista_Read_IdUser(lista);
        }

        public List<Models.Contacto> Lista_Read_User(Models.Lista lista)
        {
            return _Lista.Lista_Read_User(lista);
        }

        public Models.Contacto Lista_Insert(Models.Lista lista)
        {
            return _Lista.Lista_Insert(lista);
        }

        public List<Models.Contacto> Lista_Read_IdList(Models.Lista lista)
        {
            return _Lista.Lista_Read_IdList(lista);
        }

        public Models.Lista Lista_Insert_User(Models.Lista lista)
        {
            return _Lista.Lista_Insert_User(lista);
        }
        public Models.Contacto ListaContacto_Eliminar_IdContacto(Models.Lista lista)
        {
            return _Lista.ListaContacto_Eliminar_IdContacto(lista);
        }

        public List<Models.Contacto> Contacto_Seleccionar_IdEmpresa(Models.Empresa empresa)
        {
            return _Lista.Contacto_Seleccionar_IdEmpresa(empresa);
        }

        public List<Models.Contacto> Contacto_Seleccionar_IdUnidadNegocio(Models.CatUnidadNegocio UDN)
        {
            return _Lista.Contacto_Seleccionar_IdUnidadNegocio(UDN);
        }

        public Models.Contacto Lista_Import(Models.Lista lista)
        {
            return _Lista.Lista_Import(lista);
        }

        public Models.Contacto Lista_Delete(Models.Lista lista)
        {
            return _Lista.Lista_Delete(lista);
        }
        public Models.Contacto Lista_Update(Models.Lista lista)
        {
            return _Lista.Lista_Update(lista);
        }

        public Models.Lista Lista_Read_IdCampaing(Models.Lista lista)
        {
            return _Lista.Lista_Read_IdCampaing(lista);
        }
    }
}
