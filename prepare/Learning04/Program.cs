using System;

class Program
{
    static void Main(string[] args)
    {
        Math math = new Math("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Write write = new Write("Mary Waters", "European History", "The causes of World War II");
        Console.WriteLine(write.GetSummary());
        Console.WriteLine(write.GetWritingInformation());
    }
}