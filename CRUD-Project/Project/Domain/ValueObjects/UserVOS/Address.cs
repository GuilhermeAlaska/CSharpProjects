using App.Shared.NotifiableEntities;
using Flunt.Validations;

namespace App.Domain.ValueObjects.UserVOS
{
    public class Address : ValueObject
    {
        public Address(string street, string number, string neighborhood, string city, string state, string country, string zipCode)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;

            AddNotifications(new Contract()
                .IsNotNullOrEmpty(Street, Street, "Street cannot be null")
                .IsNotNullOrEmpty(Number, Number, "Number cannot be null")
                .IsNotNullOrEmpty(Neighborhood, Neighborhood, "Neighborhood cannot be null")
                .IsNotNullOrEmpty(City, City, "City cannot be null")
                .IsNotNullOrEmpty(State, State, "State cannot be null")
                .IsNotNullOrEmpty(Country, Country, "Country cannot be null")
                .IsNotNullOrEmpty(ZipCode, ZipCode, "ZipCode cannot be null"));
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }

    }
}