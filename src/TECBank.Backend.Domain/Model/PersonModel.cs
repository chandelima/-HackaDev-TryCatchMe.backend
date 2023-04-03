namespace TECBank.Backend.Domain.Model;

public class PersonModel : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Document { get; set; } = null!;
    public IEnumerable<AddressModel> Addresses { get; set; } = null!;
}
