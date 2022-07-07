using App.Shared.NotifiableEntities;
using Flunt.Validations;

namespace App.Domain.ValueObjects.UserVOS
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract().
                Requires()
                .HasMinLen(FirstName, 4, FirstName, "First name must have more than 4 characters")
                .HasMaxLen(FirstName, 20, FirstName, "First name must have less than 20 characters")
                .HasMinLen(LastName, 4, LastName, "Last name must have more than 4 characters")
                .HasMaxLen(LastName, 20, LastName, "Last name must have less than 40 characters"));
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}