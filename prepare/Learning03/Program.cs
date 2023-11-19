using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction number1 = new Fraction();
        Fraction number2 = new Fraction(5);
        Fraction number3 = new Fraction(3, 4);
        
        Console.WriteLine(number1.GetFractionString());
        Console.WriteLine(number1.GetDecimalValue());

        Console.WriteLine(number2.GetFractionString());
        Console.WriteLine(number2.GetDecimalValue());

        Console.WriteLine(number3.GetFractionString());
        Console.WriteLine(number3.GetDecimalValue());

        number3.SetTop(1);
        number3.SetBottom(3);

        Console.WriteLine(number3.GetFractionString());
        Console.WriteLine(number3.GetDecimalValue());
    


    }
}