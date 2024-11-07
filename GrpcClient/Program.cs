// See https://aka.ms/new-console-template for more information

using Grpc.Net.Client;
using GrpcDemo;

var input = new HelloRequest { Name = "Andres" };

var channel = GrpcChannel.ForAddress("http://localhost:5151");
var client = new Greeter.GreeterClient(channel);

var reply = await client.SayHelloAsync(input);
Console.WriteLine(reply.Message);
Console.ReadLine();
