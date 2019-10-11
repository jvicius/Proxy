using ProxyClima.Models;

namespace ProxyClima.Services
{
    public interface IProxy
    {
        WeatherObject weather(string ciudad);
        ForecastRoot forecast(string ciudad);
    }
}
