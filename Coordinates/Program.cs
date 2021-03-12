using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, step;
            double distance;
            for (step = 0; step < 10; step++)
            {
                Console.WriteLine("Введите координату (С / Ю / З / В): ");
                char way = char.Parse(Console.ReadLine());
                if (way == 'С' || way == 'с')
                {
                    y = y + 1;
                }
                else if (way == 'Ю' || way == 'ю')
                {
                    y = y - 1;
                }
                else if (way == 'З' || way == 'з')
                {
                    x = x - 1;
                }
                else if (way == 'В' || way == 'в')
                {
                    x = x + 1;
                }
            }
            x = Math.Abs(x);
            y = Math.Abs(y);
            distance = Math.Sqrt(x * x + y * y);
            Console.WriteLine("Расстояние от начала координат до точки составляет " + distance + " метров.");
            Console.ReadKey();
        }
    }
}
