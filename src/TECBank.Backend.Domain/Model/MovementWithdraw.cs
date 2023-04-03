using System.ComponentModel.DataAnnotations.Schema;
using TECBank.Backend.Domain.Enum;
using TECBank.Backend.Domain.Interface;

namespace TECBank.Backend.Domain.Model;

public class MovementWithdraw : BaseEntity, IMovevement
{
    public decimal Value { get; set; }
    public OperationType OperationType { get; } = OperationType.Out;

    [ForeignKey(nameof(SourceAccountId))]
    public AccountModel SourceAccount { get; set; } = null!;
    public Guid SourceAccountId { get; set; }
}