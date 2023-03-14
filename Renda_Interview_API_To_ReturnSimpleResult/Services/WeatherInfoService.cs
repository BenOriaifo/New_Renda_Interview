namespace Renda_Interview_API_To_ReturnSimpleResult.Services
{
    public class WeatherInfoService : IWeatherInfo
    {
        public List<string> GetWeatherInfo()
        {
            var result = new List<string> { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
            return result;
        }
    }
}
