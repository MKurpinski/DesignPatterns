namespace DesignPatterns.Facade.FakeThirdPartyLibraries
{
    public interface IWeatherForecastWithGoodHumidity
    {
        decimal GetTemp();
        decimal GetH();
        decimal GetPoW();
    }
}