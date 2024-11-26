using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class TestWhatsapp
    {
        public async Task<string> EnviarImagenAsync()
        {
            string result = "";
            string instanceId = "instance950"; // your instanceId
            string token = "yourtoken";         //instance Token
            //string mobile = "14155552671";
            string mobile = "525545287874";

            var url = "https://api.ultramsg.com/" + instanceId + "/messages/image";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Post);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("token", token);
            request.AddParameter("to", mobile);
            request.AddParameter("image", "https://file-example.s3-accelerate.amazonaws.com/images/test.jpg");
            request.AddParameter("caption", "caption text");

            RestResponse response = await client.ExecuteAsync(request);
            var output = response.Content;
            Console.WriteLine(output);

            return result;
        }
    }
}
