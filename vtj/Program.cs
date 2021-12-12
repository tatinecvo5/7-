using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны куба");
            int a = Convert.ToInt32(Console.ReadLine());
            sqrandvol(a);
            Console.ReadKey();
        }
        static void sqrandvol(int a)
        {
            int S = 6*a*a;
            int V = a * a * a;
                Console.Write("Площадь куба = {0}",S);
            Console.WriteLine("м2");
            Console.Write("Объем куба = {0}", V);
            Console.WriteLine("м3");
        }
            
    }
}
