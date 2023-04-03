namespace TECBank.Backend.Domain.Interface;

public interface IBaseEntity
{
    public Guid Id { get; set; }
    public bool IsActive { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset DeletedAt { get; set; }
}
