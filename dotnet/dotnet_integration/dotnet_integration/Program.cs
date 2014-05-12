using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;


namespace dotnet_integration
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://app.monkeylearn.com/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", "<YOUR TOKEN GOES HERE>");
                
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("text", "This is a text to try language detection.") 
                });
                
                var response = client.PostAsync("api/v1/categorizer/hDDngsX8/classify_text/", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseBody = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine(responseBody);
                    Console.ReadLine();
                }                
            }
        }
    }
}
