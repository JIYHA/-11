using System;

namespace Задание_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("11-аааааа");
            Console.WriteLine("Ввод х");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ввод м");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Ввод а");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ввод в");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ввод с");
            int c = int.Parse(Console.ReadLine());

            double delitel = Math.Pow(m, 2) + Math.Pow(Math.Sin(x), 2);
            if (delitel == 0)
            {
                Console.WriteLine("Error");
            }
            else if (delitel<0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                double z = Math.Sin(x) / Math.Sqrt(delitel) - c * m * Math.Log(m) * x;
                Console.WriteLine("z=" + z);
            }

            double koren1 = Math.Sqrt(x + 1);
            double koren2 = Math.Sqrt(x + 1.5);
            if (koren1<0)
            {
                Console.WriteLine("Error");
            }
            else if (koren2<0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                double s = Math.Pow(Math.E, -a * x) * koren1 + Math.Pow(Math.E, -b * x) * koren2;
                Console.WriteLine("s=" + s);
            }
            
        }
    }
}
