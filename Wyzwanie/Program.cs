using NETCore.Encrypt;
using System;
using System.Configuration;
using Console = Colorful.Console;

namespace Wyzwanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteAscii("kursdotnet.pl");
            Method();
        }

        private static void Method()
        {
            Console.WriteLine("Cześć. Witaj w wyzwaniu Kurs .NET. Aby wziąć udział w grze podaj swój adres email.");

            Console.Write("email:");
            var email = Console.ReadLine();

            var key = ConfigurationManager.AppSettings["key"];
            var encrypted = EncryptProvider.AESEncrypt(email, key);

            var group = EncryptProvider.AESDecrypt(ConfigurationManager.AppSettings["group"], key);

            Console.WriteLine($"Dołącz do grupy:");
            Console.WriteLine(group);
            Console.WriteLine($"Twoje hasło: { encrypted}");
            Console.ReadLine();
        }
    }
}
