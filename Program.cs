using System;

namespace PassGenVault
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Систему ініціалізовано ===");
            Console.WriteLine("Головний модуль завантажено успішно.");
            Console.WriteLine("Цей код було завантажено за допомогою Git.");

            // Демонстраційна функція
            Random rnd = new Random();
            int securityToken = rnd.Next(100000, 999999);

            Console.WriteLine($"Згенеровано тимчасовий токен доступу: {securityToken}");
            Console.WriteLine("==============================");
        }
    }
}