using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program35
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Рост (см): ");
            if (int.TryParse(Console.ReadLine(), out int height))
            {
                if (height > 200)
                    Console.WriteLine("Очень высокий");
                else
                    Console.WriteLine("Обычный рост.");
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }
    }
}