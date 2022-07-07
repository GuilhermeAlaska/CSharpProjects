using App.Domain.Enums;
using App.Shared.NotifiableEntities;
using Flunt.Validations;

namespace App.Domain.ValueObjects.UserVOS
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;

            AddNotifications(new Contract()
                .Requires()
                .IsTrue(IsValid(), "Document.Number", "Invalid Document"));
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }

        private bool IsValid()
        {
            if (Type == EDocumentType.CNPJ && Number.Length == 14)
                return true;

            if (Type == EDocumentType.CPF && Number.Length == 11)
                return true;

            return false;
        }
    }
}