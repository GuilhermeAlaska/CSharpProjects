using App.Shared.NotifiableEntities;
using Flunt.Validations;
using System.Security.Cryptography;
using System.Text;

namespace App.Domain.ValueObjects.UserVOS
{
    public class Password : ValueObject
    {
        public Password(string password)
        {
            EncryptedPassword = EncryptPassword(password);


            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(password, 5, password, "Password must have more than 5 characters")
                .HasMaxLen(password, 25, password, "Password must have less than 25 characters"));
        }

        public string EncryptedPassword { get; private set; }

        private static string EncryptPassword(string senha)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));

            StringBuilder sBuilder = new();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}