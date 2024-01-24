using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction test1 = new Fraction();
        Fraction test2 = new Fraction(5);
        Fraction test3 = new Fraction(3, 4);
        Fraction test4 = new Fraction();
        test4.SetTop(1); test4.SetBottom(3);

        Console.WriteLine($"{test1.GetFractionString()}"
                        + $"\n{test1.GetDecimalValue()}");
        Console.WriteLine($"{test2.GetFractionString()}"
                        + $"\n{test2.GetDecimalValue()}");
        Console.WriteLine($"{test3.GetFractionString()}"
                        + $"\n{test3.GetDecimalValue()}");
        Console.WriteLine($"{test4.GetFractionString()}"
                        + $"\n{test4.GetDecimalValue()}");
    }
}