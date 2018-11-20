using System.Collections.Generic;
using mad3.Models;

namespace mad3.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
