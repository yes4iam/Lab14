using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите имя собаки");
            Dog dog = new Dog("Шарик");
            Console.WriteLine("Введите имя кота");
            Cat cat = new Cat(Console.ReadLine());
            Console.WriteLine(dog.ShowInfo());
            Console.WriteLine(cat.ShowInfo());
            Console.ReadKey();
            
        }
    }
}
