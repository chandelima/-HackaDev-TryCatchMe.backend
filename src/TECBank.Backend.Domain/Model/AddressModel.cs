using System.ComponentModel.DataAnnotations.Schema;

namespace TECBank.Backend.Domain.Model
{
    public class AddressModel : BaseEntity
    {
        public string StreetName { get; set; } = null!;
        public string Number { get; set; } = null!;
        public string? Complement { get; set; }
        public string Neigboorhood { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string PostalCode { get; set; } = null!;

        [ForeignKey(nameof(PersonId))]
        public virtual PersonModel Person { get; set; } = null!;
        public Guid PersonId { get; set; }
    }
}
