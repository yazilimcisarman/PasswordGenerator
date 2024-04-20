using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    internal class Program
    {
        public static string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789.-*";
        static void Main(string[] args)
        {
            Random random = new Random();
            int length = 12;
            string password = GeneratePassword(random,length);
            Console.WriteLine(password);
            Console.ReadLine();
           
        }

        public static string GeneratePassword(Random random, int length)
        {
            char[] password = new char[length];
            for (int i = 0; i < length; i++) 
            {
                password[i] = chars[random.Next(chars.Length)];
            }

            return new string(password);
        }
    }
}
