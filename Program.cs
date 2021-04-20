using System;
using static System.Math;
namespace Lab1
{
    public class Program
    {
        public static void Main()
        {
            double a, b, sa, sg;
            Console.WriteLine("Введіть:");
            do
            {
                Console.Write("a = ");
            } while (double.TryParse(Console.ReadLine(), out a) == false);

            do
            {
                Console.Write("b = ");
            } while (double.TryParse(Console.ReadLine(), out b) == false);

            sa = ArithmeticMean(a, b);
            sg = GeometricMean(a, b);

            Console.WriteLine("\nsa = {0:N2}", sa);
            Console.WriteLine("sg = {0:N2}", sg);

        }

        public static double ArithmeticMean(params double[] num)
        {
            double summ = 0;
            foreach (double elem in num)
            {
                summ += elem;
            }
            return summ / num.Length;
        }

        public static double GeometricMean(params double[] num)
        {
            double dob = 1;
            foreach (double elem in num)
            {
                dob *= elem;
            }
            return Pow(dob, 1.0 / num.Length);
        }
    }
}
