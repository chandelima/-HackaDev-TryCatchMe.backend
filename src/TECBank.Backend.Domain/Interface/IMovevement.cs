using TECBank.Backend.Domain.Enum;

namespace TECBank.Backend.Domain.Interface;

public interface IMovevement : IBaseEntity
{
    public decimal Value { get; set; }
    public OperationType OperationType { get; }
}
