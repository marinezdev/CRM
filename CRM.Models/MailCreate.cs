using System;
namespace CRM.Models
{
	public class MailCreate
	{
        public  string Token { get; set; }

        public  int AplicacionUserId { get; set; }

        public  string Aplicacion { get; set; }

        public int grupoId { get; set; }
        public string grupoName { get; set; }

        public string Origen { get; set; }

        public  string Destinatario { get; set; }

        public  string DestinatarioCC { get; set; }

        public  string DestinatarioCCO { get; set; }

        public  string Asunto { get; set; }

        public  string Contenido { get; set; }
        public  string fechaEnvio { get; set; }
    }
}

