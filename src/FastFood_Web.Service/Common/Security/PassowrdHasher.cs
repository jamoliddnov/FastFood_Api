namespace FastFood_Web.Service.Common.Security
{
    public class PassowrdHasher
    {
        public static (string PasswordHash, string Salt) Hash(string passowrd)
        {
            string salt = Guid.NewGuid().ToString();
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(salt + passowrd);
            return (passwordHash, salt);
        }

        public static bool Verify(string password, string salt, string passwordHash)
        {
            var result = BCrypt.Net.BCrypt.Verify(salt + password, passwordHash);
            return result;
        }
    }
}