using App.Domain.ValueObjects.UserVOS;
using App.Shared.Entity;

namespace App.Domain.Entities
{
    public class User : Entity
    {
        public User(Name name, Document document, Email email, Address address, Password password)
        {
            Name = name;
            Document = document;
            Email = email;
            Address = address;
            Password = password;

            AddNotifications(Name, Document, Email, Address, Password);
        }

        public Name Name { get; set; }
        public Document Document { get; set; }
        public Email Email { get; set; }
        public Address Address { get; set; }
        public Password Password { get; set; }
    }
}