using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
namespace DemoHerokuApp.Models
{
     public class ContentNetwork
    {
        public async static Task<Root> GetContentNetwork()
        {

            var http = new HttpClient();
            var url = string.Format("http://api-demo-anhth.herokuapp.com/data.json");

            var response = await http.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();

            var serializer = new DataContractJsonSerializer(typeof(Root));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (Root)serializer.ReadObject(ms);
            return data;
        }
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Content
        {
           
            public string description { get; set; }
            
            public string url { get; set; }
        }

        public class Root
        {
            
            public int id { get; set; }
            
            public string date { get; set; }
            
            public string title { get; set; }
            
            public string image { get; set; }
            
            public Content content { get; set; }
        }
    }
}
