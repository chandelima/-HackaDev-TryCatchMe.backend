namespace TECBank.Backend.Domain.Model;

public class HolderModel : PersonModel
{
    public IEnumerable<AccountModel> Accounts { get; set; } = null!;
}
