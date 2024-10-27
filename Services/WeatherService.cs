using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Lr9.Net.Models;

namespace Lr9.Net.Services
{
    public class WeatherService
    {
        private readonly string _apiKey = "";
        private readonly HttpClient _httpClient;

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherData> GetWeatherAsync(string region)
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={region}&appid={_apiKey}&units=metric";
            var response = await _httpClient.GetStringAsync(url);
            return JsonConvert.DeserializeObject<WeatherData>(response);
        }
    }
}
