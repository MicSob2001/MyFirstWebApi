
namespace MyFirstWebApi
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get();
    }
}