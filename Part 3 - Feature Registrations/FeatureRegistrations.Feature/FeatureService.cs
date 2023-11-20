using FeatureRegistrations.Abstractions;

namespace FeatureRegistrations.Feature;

public class FeatureService : IFeatureService
{
    public Guid Id { get; } = Guid.NewGuid();
}
