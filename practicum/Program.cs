using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Surname, string Login, int LogCount, bool Pet, int Age, string[] Colors) User;

            for (int k = 0; k < 3; k++) { }
            Console.Write("Ваше имя: ");
            User.Name = Console.ReadLine();
            Console.Write("Ваша фамилия: ");
            User.Surname = Console.ReadLine();
            Console.Write("Ваш логин: ");
            User.Login = Console.ReadLine();
            User.LogCount = User.Login.Length;
            Console.Write("Если у вас есть животное, напишите \"Да\": ");
            string a = Console.ReadLine();
            User.Pet = a == "Да";
            User.Colors = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Ваш {i + 1}-й любимый цвет: ");
                User.Colors[i] = Console.ReadLine();

            }
        }


        }
    }
}
