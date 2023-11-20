using Registrations.Abstractions;

namespace Registrations;

public class TransientService : ITransientService
{
    public Guid Id { get; } = Guid.NewGuid();
}
