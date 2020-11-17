using CleanArchitecture.Application.WeatherForecasts;
using CleanArchitecture.Application.WeatherForecasts.Queries.GetWeatherForecasts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorWasmHostedUI.Server.Controllers
{
    public class WeatherForecastController : ApiController
    {
        [HttpGet]
        public async Task<IEnumerable<WeatherForecastDto>> Get()
        {
            return await Mediator.Send(new GetWeatherForecastsQuery());
        }
    }
}
