using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Registrations;
using Registrations.Abstractions;

HostApplicationBuilder builder = Host.CreateApplicationBuilder();

builder.Services.AddScoped<IScopedService, ScopedService>();
builder.Services.AddTransient<ITransientService, TransientService>();
builder.Services.AddSingleton<ISingletonService, SingletonService>();

IHost host = builder.Build();

IScopedService scopedService1 = host.Services.GetRequiredService<IScopedService>();
IScopedService scopedService2 = host.Services.GetRequiredService<IScopedService>();
Console.WriteLine($"ScopedService1: {scopedService1.Id}");
Console.WriteLine($"ScopedService2: {scopedService2.Id}");

ITransientService transientService1 = host.Services.GetRequiredService<ITransientService>();
ITransientService transientService2 = host.Services.GetRequiredService<ITransientService>();
Console.WriteLine($"TransientService1: {transientService1.Id}");
Console.WriteLine($"TransientService2: {transientService2.Id}");

ISingletonService singletonService1 = host.Services.GetRequiredService<ISingletonService>();
ISingletonService singletonService2 = host.Services.GetRequiredService<ISingletonService>();
Console.WriteLine($"SingletonService1: {singletonService1.Id}");
Console.WriteLine($"SingletonService2: {singletonService2.Id}");

Console.ReadKey();
