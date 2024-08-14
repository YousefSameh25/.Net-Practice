using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class DummyThirdPartyApiServiceProxy : IApiService
    {
        private DummyThirdPartyApiService dummyThirdPartyApiService;

        // Let's introduce a caching layer, we use Dic to store many requests URL with their responses.
        private Dictionary<string, string> Cache;

        public DummyThirdPartyApiServiceProxy()
        {
            dummyThirdPartyApiService = new DummyThirdPartyApiService();
            Cache = new Dictionary<string, string>();
        }

        public async Task<string> GetAllProducts()
        {
            // Enable caching.
            if (Cache.ContainsKey(DummyThirdPartyApiService.BaseProductsURL))
                return Cache[DummyThirdPartyApiService.BaseProductsURL];

            // Enable access logging.
            // Enable Lazy initialization.
            // Enable Access control.

            string responseString = await dummyThirdPartyApiService.GetAllProducts();
            Cache.Add(DummyThirdPartyApiService.BaseProductsURL, responseString);
            return responseString;
        }
    }
}
