namespace DesignPatterns.Facade.FakeThirdPartyLibraries
{
    public interface IWeatherForecastWithProperPowerOfWind
    {
        decimal GetTemperature();
        decimal GetHumidity();
        decimal GetPoW();
    }
}