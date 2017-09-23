using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Facade.FakeThirdPartyLibraries;

namespace DesignPatterns.Facade
{
    public class WeatherForecast: IWeatherForecast
    {
        private readonly IWeatherForecastWithGoodHumidity _forecastWithGoodHumidity;
        private readonly IWeatherForecastWithGoodTemperature _forecastWithGoodTemperature;
        private readonly IWeatherForecastWithProperPowerOfWind _forecastWithProperPowerOfWind;

        public WeatherForecast(IWeatherForecastWithGoodHumidity forecastWithGoodHumidity,
                               IWeatherForecastWithGoodTemperature forecastWithGoodTemperature,
                               IWeatherForecastWithProperPowerOfWind forecastWithProperPowerOfWind)
        {
            _forecastWithGoodHumidity = forecastWithGoodHumidity;
            _forecastWithGoodTemperature = forecastWithGoodTemperature;
            _forecastWithProperPowerOfWind = forecastWithProperPowerOfWind;
        }

        public decimal GetTemperature()
        {
            return _forecastWithGoodTemperature.Temperature;
        }

        public decimal GetHumidity()
        {
            return _forecastWithGoodHumidity.GetH();
        }

        public decimal GetPowerOfWind()
        {
            return _forecastWithProperPowerOfWind.GetPoW();
        }
    }
}
