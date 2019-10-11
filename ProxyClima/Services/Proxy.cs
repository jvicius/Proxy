using RestSharp;
using System;
using ProxyClima.Models;

namespace ProxyClima.Services
{
    public class Proxy : IProxy
    {
        private RestClient _client;
        private string appid = "b1e34d4d55487b41db609a28e5854900";
        private string metrics = "metric";

        public Proxy()
        {
            _client = new RestClient("http://api.openweathermap.org/data/2.5/");
        }

        public WeatherObject weather(string ciudad)
        {
            var request = new RestRequest($"weather?q={ciudad}&APPID={appid}&units={metrics}");
            var response = _client.Get<WeatherObject>(request);
            return response.Data;
        }

        public ForecastRoot forecast(string ciudad)
        {
            var request = new RestRequest($"forecast?q={ciudad}&APPID={appid}&units={metrics}");
            var response = _client.Get<ForecastRoot>(request);
            return response.Data;
        }
    }
}
