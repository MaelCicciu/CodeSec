using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace GenericGet.Library
{
    public class Deserialization
    {
        public static string Call(string url)
        {
            string result = "";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            result = client.GetStringAsync(url).Result;
            return result;
        }

        public static T Get<T>(string url)
        {
            T result;
            result = JsonSerializer.Deserialize<T>(Call(url));
            return result;
        }
    }
}
