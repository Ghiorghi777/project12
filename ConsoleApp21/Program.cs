using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        // Статический метод для вычисления общего количества копеек
        public static int Kop(int r, int k)
        {
            return (r * 100) + k;  // Преобразуем рубли в копейки и добавляем копейки
        }

        static void Main(string[] args)
        {
            // Пример а) 5 руб. 24 коп.
            int result1 = Kop(5, 24);
            Console.WriteLine("Количество копеек для 5 руб. 24 коп.: " + result1);  // Ожидаемый результат: 524

            // Пример б) 15 руб. 7 коп.
            int result2 = Kop(15, 7);
            Console.WriteLine("Количество копеек для 15 руб. 7 коп.: " + result2);  // Ожидаемый результат: 1507
            Console.ReadKey();

        }
    }
}
