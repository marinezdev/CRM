using CRM.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class Lista
    {
        ManejoDatos b = new ManejoDatos();

        public List<Models.Lista> Lista_Read(Models.Lista lista)
        {
            const string consulta = "Lista_Read";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", lista.Usuario.Id, SqlDbType.VarChar);

            List<Models.Lista> resultado = new List<Models.Lista>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Lista>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Lista> Lista_Read_UserIdCampaing(Models.Lista lista)
        {
            const string consulta = "Lista_Read_UserIdCampaing";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", lista.Campaign.Id, SqlDbType.VarChar);

            List<Models.Lista> resultado = new List<Models.Lista>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Lista>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Lista> Lista_Read_IdUser(Models.Lista lista)
        {
            const string consulta = "Lista_Read_IdUser";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", lista.Usuario.Id, SqlDbType.VarChar);


            List<Models.Lista> resultado = new List<Models.Lista>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Lista>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.Contacto> Lista_Read_User(Models.Lista lista)
        {
            const string consulta = "Lista_Read_User";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", lista.Id, SqlDbType.VarChar);

            List<Models.Contacto> resultado = new List<Models.Contacto>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Contacto>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.Contacto Lista_Insert(Models.Lista lista)
        {
            const string consulta = "Lista_Insert";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Nombre", lista.Nombre, SqlDbType.VarChar);
            b.AddParameter("@IdUnidadNegocio", lista.CatUnidadNegocio.Id, SqlDbType.VarChar);
            b.AddParameter("@IdUsuario", lista.Usuario.Id, SqlDbType.VarChar);


            Models.Contacto resultado = new Models.Contacto();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Contacto>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.Contacto> Lista_Read_IdList(Models.Lista lista)
        {
            const string consulta = "Lista_Read_IdList";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", lista.Id, SqlDbType.VarChar);

            List<Models.Contacto> resultado = new List<Models.Contacto>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Contacto>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }


        public Models.Lista Lista_Insert_User(Models.Lista lista)
        {
            const string consulta = "Lista_Insert_User";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", lista.Id, SqlDbType.VarChar);
            b.AddParameter("@IdContacto", lista.Contacto.Id, SqlDbType.VarChar);

            Models.Lista resultado = new Models.Lista();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Lista>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.Contacto ListaContacto_Eliminar_IdContacto(Models.Lista lista)
        {
            const string consulta = "ListaContacto_Eliminar_IdContacto";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdLista", lista.Id, SqlDbType.VarChar);
            b.AddParameter("@IdContacto", lista.Contacto.Id, SqlDbType.VarChar);


            Models.Contacto resultado = new Models.Contacto();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Contacto>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }


        public List<Models.Contacto> Contacto_Seleccionar_IdEmpresa(Models.Empresa empresa)
        {
            const string consulta = "Contacto_Seleccionar_IdEmpresa";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEmpresa", empresa.Id, SqlDbType.VarChar);
            b.AddParameter("@Id", empresa.Lista.Id, SqlDbType.VarChar);


            List<Models.Contacto> resultado = new List<Models.Contacto>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Contacto>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.Contacto> Contacto_Seleccionar_IdUnidadNegocio(Models.CatUnidadNegocio UDN)
        {
            const string consulta = "Contacto_Seleccionar_IdUnidadNegocio";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUDN", UDN.Id, SqlDbType.VarChar);
            b.AddParameter("@Id", UDN.Lista.Id, SqlDbType.VarChar);


            List<Models.Contacto> resultado = new List<Models.Contacto>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Contacto>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.Contacto Lista_Import(Models.Lista lista)
        {
            const string consulta = "Lista_Import";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", lista.Id, SqlDbType.VarChar);
            b.AddParameter("@IdUser", lista.Usuario.Id, SqlDbType.VarChar);

            Models.Contacto resultado = new Models.Contacto();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Contacto>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }


        public Models.Contacto Lista_Update(Models.Lista lista)
        {
            const string consulta = "Lista_Update";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdLista", lista.Id, SqlDbType.VarChar);
            b.AddParameter("@Nombre", lista.Nombre, SqlDbType.VarChar);


            Models.Contacto resultado = new Models.Contacto();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Contacto>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.Contacto Lista_Delete(Models.Lista lista)
        {
            const string consulta = "Lista_Delete";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdLista", lista.Id, SqlDbType.VarChar);


            Models.Contacto resultado = new Models.Contacto();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Contacto>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.Lista Lista_Read_IdCampaing(Models.Lista lista)
        {
            const string consulta = "Lista_Read_IdCampaing";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", lista.Campaign.Id, SqlDbType.VarChar);

            Models.Lista resultado = new Models.Lista();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Lista>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
