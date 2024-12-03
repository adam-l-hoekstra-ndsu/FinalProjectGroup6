
namespace FinalProjectGroup6.Services
{
    using BCrypt.Net;
    public class PasswordService
    {
        // Method to hash the password
        public static string HashPassword(string password)
        {
            // Generate salt with a strength of 12 rounds
            var salt = BCrypt.GenerateSalt(12);  
            return BCrypt.HashPassword(password, salt);
        }

        // Method to check the password during login
        public static bool CheckPassword(string hashedPassword, string password)
        {
            return BCrypt.Verify(password, hashedPassword);
        }
    }
}
