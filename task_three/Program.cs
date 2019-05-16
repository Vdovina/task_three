using System;

namespace task_three
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите х:   ");
            double x = EnterANumber();
            Console.Write("Введите у:   ");
            double y = EnterANumber();

            if (IsBelongTo(x, y)) Console.WriteLine($"Точка [{x}; {y}] принадлежит единичной окружности.");
            else Console.WriteLine($"Точка [{x}; {y}] не принадлежит единичной окружности.");

            Console.ReadLine();
        }

        static double EnterANumber()
        {
            bool ok = false;
            double number = 0;
            do
            {
                try
                {
                    number = Convert.ToDouble(Console.ReadLine());
                    ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите действительное число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Введите действительное число!");
                }
            } while (!ok);
            return number;
        }

        static bool IsBelongTo(double x, double y)
        {
            return Math.Pow(x, 2) + Math.Pow(y, 2) <= 1;
        }
    }
}
