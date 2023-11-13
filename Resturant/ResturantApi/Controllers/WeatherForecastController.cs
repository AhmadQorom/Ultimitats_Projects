using Contracts.Dtos.DrinksDtos;
using Contracts.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ResturantApi.Controllers
{
    [ApiController]   // data annotation
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly IDrinkService _drinkService;
        public WeatherForecastController(IDrinkService drinkService)
        {
            _drinkService = drinkService;
        }

        [HttpGet(Name = "GetDrink")]
        public List<DrinkDto> GetDrink()
        {
            var result = _drinkService.GetDrinks();
            return result;
        }

        [HttpPost]
        public List<DrinkDto> CreateDrink(CreateDrinkDto inputFromUser)
        {
            _drinkService.AddDrink(inputFromUser);
            return GetDrink();
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}