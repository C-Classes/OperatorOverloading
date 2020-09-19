using System;

namespace OperatorOverloading1
{
    class Fraction
    {
        public int a { get; set; } //numarator
        public int b { get; set; } //numitor

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();

            result.a = f1.a * f2.b + f2.a * f1.b;
            result.b = f1.b * f2.b;

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction = new Fraction();
            Fraction fraction1 = new Fraction();
            Fraction fraction2 = new Fraction();

            fraction1.a = 1;
            fraction1.b = 2;
            fraction2.a = 3;
            fraction2.b = 4;

            fraction = fraction1 + fraction2;

            Console.WriteLine("{0}/{1}", fraction.a, fraction.b);
        }
    }
}
