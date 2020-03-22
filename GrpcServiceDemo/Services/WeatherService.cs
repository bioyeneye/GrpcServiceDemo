using Grpc.Core;
using GrpcServiceDemo.Protos;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace GrpcServiceDemo
{
    public class WeatherService : Weather.WeatherBase
    {
        private readonly ILogger<WeatherService> _logger;
        public WeatherService(ILogger<WeatherService> logger)
        {
            _logger = logger;
        }

        public override Task<GetWeatherResponse> GetWeather(GetWeatherRequest request, ServerCallContext context)
        {
            return Task.FromResult(new GetWeatherResponse
            {
                Message = "Hello " + request.Name,
                Languages = ""
            });
        }
    }
}
