using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4._4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Type, double Age, int NameCount) Pet;

            Console.Write("Имя: ");
            Pet.Name = Console.ReadLine();
            Console.Write("Тип: ");
            Pet.Type = Console.ReadLine();
            Console.Write("Возраст: ");
            Pet.Age = double.Parse(Console.ReadLine());
            Pet.NameCount = Pet.Name.Length;


        }
    }
}
