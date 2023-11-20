using FeatureRegistrations.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace FeatureRegistrations.Feature;

public static class Registrations
{
    public static IServiceCollection AddFeature(this IServiceCollection services)
    {
        services.AddSingleton<IFeatureService, FeatureService>();
        return services;
    }
}
