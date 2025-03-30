using System;
using System.Security.Cryptography;
using System.Text;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Secure World!");
            Console.WriteLine("Generating a secure hash...");

            string sampleText = "This is a test for security checks.";
            string hashedText = GenerateSHA256Hash(sampleText);

            Console.WriteLine($"Original Text: {sampleText}");
            Console.WriteLine($"SHA-256 Hash: {hashedText}");
        }

        static string GenerateSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
