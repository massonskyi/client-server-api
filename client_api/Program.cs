using System;
using System.Net.Http;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        using (HttpClient client = new HttpClient())
        {
            string url = "http://127.0.0.1:8001";

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Response received: " + responseBody);
            }
            else
            {
                Console.WriteLine("Request failed. Status code: " + response.StatusCode);
            }
        }
    }
}



