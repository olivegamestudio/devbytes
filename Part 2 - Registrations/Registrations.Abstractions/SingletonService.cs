using Registrations.Abstractions;

namespace Registrations;

public class SingletonService : ISingletonService
{
    public Guid Id { get; } = Guid.NewGuid();
}
