using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Registrations;
using Registrations.Abstractions;

HostApplicationBuilder builder = Host.CreateApplicationBuilder();

builder.Services.AddScoped<IScopedService, ScopedService>();
builder.Services.AddTransient<ITransientService, TransientService>();
builder.Services.AddSingleton<ISingletonService, SingletonService>();

IHost host = builder.Build();

IScopedService scopedService = host.Services.GetRequiredService<IScopedService>();
ITransientService transientService = host.Services.GetRequiredService<ITransientService>();
ISingletonService singletonService = host.Services.GetRequiredService<ISingletonService>();

Console.ReadKey();
