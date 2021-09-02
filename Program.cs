using System;

namespace salamalekum
{
    class Program
    {
        static void Main(string[] args)
        {

        x:
            Console.WriteLine("Игра тепло-холодно");
            Console.Write("Введите число которое будут искать: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Угадай число");
            y:
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("Ура, ты угадал, давай еще");
                goto x;
            }

            if (((a - b) == 1) || ((b - a) == 1))

            {
                Console.WriteLine("Горячо");
            goto y;
        }
            if ((((a - b) >= 2) && ((a - b) <= 5)) || (((a - b) <= -2) && ((a - b) >= -5)))
            {
                Console.WriteLine("Очень тепло");
                goto y;
            }
            if ((((a - b) >= 6) && ((a - b) <= 10)) || (((a - b) <= -6) && ((a - b) >= -10)))
            {
                Console.WriteLine("Тепло");
                goto y;
            }
            if ((((a - b) >= 11) && ((a - b) <= 20)) || (((a - b) <= -11) && ((a - b) >= -20)))
            {
                Console.WriteLine("Теплее");
                goto y;
            }
            if (((a - b) >= 21) || (((a - b) <= -21)))
            {
                Console.WriteLine("Холодно");
                goto y;
            }
        }
    }
}
