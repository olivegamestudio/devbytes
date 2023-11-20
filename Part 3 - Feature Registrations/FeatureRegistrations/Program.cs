using FeatureRegistrations.Abstractions;
using FeatureRegistrations.Feature;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

HostApplicationBuilder builder = Host.CreateApplicationBuilder();

builder.Services.AddFeature();

IHost host = builder.Build();

IFeatureService service = host.Services.GetRequiredService<IFeatureService>();

Console.ReadKey();
