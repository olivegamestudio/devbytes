using Registrations.Abstractions;

namespace Registrations;

public class ScopedService : IScopedService
{
    public Guid Id { get; } = Guid.NewGuid();
}
