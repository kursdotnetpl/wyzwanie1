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
            Console.WriteLine("Gratulacje!");
            Console.WriteLine("Poprawnie wykonałeś zadanie.");

            var key = ConfigurationManager.AppSettings["key"];
            var encrypted = EncryptProvider.AESEncrypt("DOTNET2020", key);

            var group = EncryptProvider.AESDecrypt(ConfigurationManager.AppSettings["group"], key);
            var password = EncryptProvider.AESDecrypt(ConfigurationManager.AppSettings["password"], key);
            Console.WriteLine();
            Console.WriteLine($"Teraz dołącz do grupy: {group}");
            Console.WriteLine($"podając hasło: {password}");

            Console.WriteLine();
            Console.WriteLine("Do zobaczenia na grupie!");

            Console.ReadLine();
        }
    }
}
