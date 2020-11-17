using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Application.WeatherForecasts;
using CleanArchitecture.Application.WeatherForecasts.Queries.GetWeatherForecasts;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using MediatR;
using System.Threading.Tasks;

namespace CleanArchitecture.BlazorWasmHostedUI.Server.Services
{
    public class WeatherForecastService : Service.ServiceBase, IWeatherForecastService
    {
        private readonly IMediator _mediator;

        public WeatherForecastService(IMediator mediatr)
        {
            _mediator = mediatr;
        }

        public override async Task<GetWeatherForecastsResponse> GetWeatherForecasts(Empty request, ServerCallContext context)
        {
            var weatherForecastDtos = await _mediator.Send(new GetWeatherForecastsQuery());
            var response = new GetWeatherForecastsResponse();
            response.WeatherForecastDtos.AddRange(weatherForecastDtos);
            return response;
        }
    }
}
