namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // We can use WeatherService class.
            WeatherService weatherService = new WeatherService();
            Console.WriteLine(weatherService.GetTemptature("Cairo", "Egypt"));

            // Or we can use adapter if we want pass the latitude and longitude values.
            WeatherServiceAdapter weatherServiceAdapter = new WeatherServiceAdapter(weatherService);
            Console.WriteLine(weatherServiceAdapter.GetTemperature(140, 150));


            // Adapter works as a wrapper.
            // It Makes 2 interfaces compatible with each other. 
        }
    }
}
