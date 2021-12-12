using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_методы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон ПЕРВОГО треугольника");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длины сторон ВТОРОГО треугольника");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());
            comptriangsqr(a1, b1, c1, a2, b2, c2);
            Console.ReadKey();
        }
        static void comptriangsqr(int a1, int b1, int c1, int a2, int b2, int c2)
        {
            double P1 = a1 + b1 + c1;
            double P2 = a2 + b2 + c2;
            double S1 = Math.Sqrt(P1 * (P1-a1) * (P1-b1) * (P1-c1));
            double S2 = Math.Sqrt(P1 * (P2 - a2) * (P2 - b2) * (P2 - c2));
            if (S1 > S2)
            {
                Console.WriteLine("Площадь ПЕРВОГО треугольника БОЛЬШЕ чем ВТОРОГО");
            }
            else
                        if (S1 < S2)
            {
                Console.WriteLine("Площадь ВТОРОГО треугольника БОЛЬШЕ чем ПЕРВОГО");
            }
            else
            { 
                Console.WriteLine("Площади ПЕРВОГО и ВТОРОГО треугольников равны");
            }
        }
    }
}
