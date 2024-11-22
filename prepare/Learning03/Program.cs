using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        //Console.WriteLine($"{fraction1._top}/{fraction1._bottom}");
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(6);
        //Console.WriteLine($"{fraction2._top}/{fraction2._bottom}");
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(6, 7);
        //Console.WriteLine($"{fraction3._top}/{fraction3._bottom}");
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
    }
}