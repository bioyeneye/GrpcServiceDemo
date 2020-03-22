using Grpc.Net.Client;
using GrpcServiceDemo.Protos;
using System;
using System.Threading.Tasks;

namespace GrpcServiceDemo.Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                              new HelloRequest { Name = "GreeterClient", Languages = "Java, C#" });
            Console.WriteLine("Greeting: " + reply.Message);

            var clientWaeather = new Weather.WeatherClient(channel);
            var weatherResponse = await clientWaeather.GetWeatherAsync(new GetWeatherRequest { Name = "london" });


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            Console.WriteLine("Hello World!");
        }
    }
}
