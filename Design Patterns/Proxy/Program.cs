using System.Diagnostics;

namespace Proxy
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            var dummyThirdPartyApiServiceProxy = new DummyThirdPartyApiServiceProxy();
            // Will fetch and cache.
            string  ret = await dummyThirdPartyApiServiceProxy.GetAllProducts();
            sw.Stop();
            Console.WriteLine($"Time without caching: {sw.ElapsedMilliseconds / 1000} seconds");

            Console.WriteLine("==============================================");

            sw.Restart();
            // will get the response from caching.
            string ret2 = await dummyThirdPartyApiServiceProxy.GetAllProducts();
            sw.Stop();

            Console.WriteLine($"Time with caching: {sw.ElapsedMilliseconds / 1000} seconds");


            /*
             By applying proxy we can substitute the original class with proxy class 
                as the proxy class implements same interfaces.

                Why we did not put caching logic inside original class?
                To fulfill Separation of concerns.
             */
        }
    }
}
