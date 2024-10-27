using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Lr9.Net.Services;
using Lr9.Net.Models;

namespace Lr9.Net.Components
{
    public class WeatherViewComponent : ViewComponent
    {
        private readonly WeatherService _weatherService;

        public WeatherViewComponent(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string region)
        {
            var weatherData = await _weatherService.GetWeatherAsync(region);
            return View(weatherData);
        }
    }
}
