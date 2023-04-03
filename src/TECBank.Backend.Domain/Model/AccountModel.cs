using System.ComponentModel.DataAnnotations.Schema;
using TECBank.Backend.Domain.Interface;

namespace TECBank.Backend.Domain.Model;

public class AccountModel : BaseEntity
{
    public long Number { get; set; }
    public decimal Balance { get; set; }
    public IEnumerable<IMovevement>? Movements { get; set; }
    
    [ForeignKey(nameof(HolderId))]
    public virtual HolderModel Holder { get; set; } = null!;
    public Guid HolderId { get; set; }
}