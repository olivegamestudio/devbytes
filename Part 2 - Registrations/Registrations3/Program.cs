using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Registrations.Abstractions;

HostApplicationBuilder builder = Host.CreateApplicationBuilder();

IHost host = builder.Build();

ISingletonService? singletonService1 = host.Services.GetService<ISingletonService>();
ISingletonService singletonService2 = host.Services.GetRequiredService<ISingletonService>();

Console.ReadKey();
