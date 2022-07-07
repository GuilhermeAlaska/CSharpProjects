using App.Shared.NotifiableEntities;
using Flunt.Validations;

namespace App.Domain.ValueObjects.UserVOS
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Address, 6, Address, "Address must have more than 6 characters"));
        }

        public string Address { get; private set; }
    }
}