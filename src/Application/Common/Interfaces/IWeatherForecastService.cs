using CleanArchitecture.Application.WeatherForecasts;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Common.Interfaces
{
    public interface IWeatherForecastService
    {
        Task<GetWeatherForecastsResponse> GetWeatherForecasts(Empty request, ServerCallContext context);
    }
}