using System;

namespace Lesson3ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Первое ДЗ
            double a = double.Parse(Console.ReadLine());
            
            if (a >= 500 && a <= 1000)
            {
                double result1 = a - a * 3 / 100;
                Console.WriteLine($"{result1}");
            } 
            else if (a >= 1000) 
            {
                double result2 = a - a * 5 / 100;
                Console.WriteLine($"{result2}"); 
            }
            else 
            {
                Console.WriteLine($"{a}");
            }
            
            // Второе ДЗ
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            if (a == b && b == c && c ==d){
                Console.WriteLine($"{a * b * c * d}");
            }
            else if (a < b && b < c && c < d) {
                Console.WriteLine($"Числа расположены по возрастанию"); 
            } else {
                int x = Math.Min(a, b);
                int y = Math.Min(c, d);
                int min = Math.Min(x,y);
                Console.WriteLine($"{min}");
            }
            
            // Третье ДЗ
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = Math.Max(a, Math.Max(b, c));
            int min = Math.Min(a, Math.Min(b, c));
            int mid = a + b + c - max - min;
            Console.WriteLine($"{max} {mid} {min}");
            
        }
    }
}
