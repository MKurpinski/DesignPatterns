namespace DesignPatterns.Facade.FakeThirdPartyLibraries
{
    public interface IWeatherForecastWithGoodTemperature
    {
        decimal Temperature { get; }
        decimal Humidity { get; }
        decimal PowerOfWind { get; }
    }
}