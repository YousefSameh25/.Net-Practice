using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Mime;
using Newtonsoft.Json;

namespace Proxy
{
    public class DummyThirdPartyApiService : IApiService
    {
        public static readonly string BaseProductsURL = "https://dummyjson.com/";
        public async Task<string> GetAllProducts()
        {
            //Thread.Sleep(2000); // Make call is slower to test caching.

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseProductsURL);

            var request = new HttpRequestMessage(HttpMethod.Get, "/products");

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsStringAsync();

            return string.Empty;
        }
    }
}
