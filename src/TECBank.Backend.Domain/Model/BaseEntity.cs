using TECBank.Backend.Domain.Interface;

namespace TECBank.Backend.Domain.Model;

public abstract class BaseEntity : IBaseEntity
{
    public Guid Id { get; set; }
    public bool IsActive { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset DeletedAt { get; set; }
}