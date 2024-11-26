using System;
using CRM.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.Services
{
	public class EmailService
	{
        public static async Task<Mail> SendAsync(MailCreate correoNuevo)

        {
            using (var cliente = new HttpClient())
            {
                string urlApi = "https://mailing.asae.com.mx/api/MailEnvio/"; //servicio productivo
                //string urlApi = "http://172.16.1.203:8080/api/MailEnvio/";
                Mail newEmail = null;
                cliente.DefaultRequestHeaders.Clear();

                var data = JsonConvert.SerializeObject(correoNuevo);
                HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var httpResponse = await cliente.PostAsync(urlApi, content);
                if (httpResponse.IsSuccessStatusCode)
                {
                    var result = await httpResponse.Content.ReadAsStringAsync();
                    newEmail = JsonConvert.DeserializeObject<Mail>(result);
                }
                else
                {
                    // Manejo de error si la solicitud falla
                    // Por ejemplo: throw new Exception($"Error: {httpResponse.StatusCode} - {httpResponse.ReasonPhrase}");
                }

                return newEmail;
            }
        }
    }
}

