using App.Domain.ValueObjects.UserVOS;

namespace App.Domain.Extensions
{
    public static class ExtensionMethods
    {
        public static bool Equals(this Password password, string newPassword)
        {
            var newPasswordEncrypted = new Password(newPassword);

            if (password.EncryptedPassword == newPasswordEncrypted.EncryptedPassword)
                return true;

            return false;
        }
    }
}