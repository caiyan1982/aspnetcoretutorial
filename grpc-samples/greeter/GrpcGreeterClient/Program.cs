using Grpc.Net.Client;
using GrpcGreeter;
using System;
using System.Threading.Tasks;

namespace GrpcGreeterClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var replay = await client.SayHelloAsync(new HelloRequest { Name = "GrpcGreeterClient" });
            Console.WriteLine("Greeting:" + replay.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
