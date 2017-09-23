using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    public interface IWeatherForecast
    {
        decimal GetTemperature();
        decimal GetHumidity();
        decimal GetPowerOfWind();
    }
}
