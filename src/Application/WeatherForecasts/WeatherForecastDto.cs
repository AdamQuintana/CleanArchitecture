using AutoMapper;
using CleanArchitecture.Application.Common.Mappings;
using CleanArchitecture.Application.WeatherForecasts.Queries.GetWeatherForecasts;

namespace CleanArchitecture.Application.WeatherForecasts
{
    public partial class WeatherForecastDto :IMapFrom<WeatherForecast>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<WeatherForecast, WeatherForecastDto>()
                .ForMember(d => d.Date, opt => opt.MapFrom(s => s.Date.ToShortDateString()));
        }
    }
}