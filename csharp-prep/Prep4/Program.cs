using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int numbers = -1;
        int sum = 0;
        List<int> list = new List<int>();
        while (numbers != 0){
            Console.Write("Enter number: ");
            string usersData = Console.ReadLine();
            numbers = int.Parse(usersData);
            list.Add (numbers);
        }
        int average =  0;
        int larguest = 0;
        foreach (int number in list)
        {
            sum += number;
            average = sum / list.Count;
            if (larguest<number){
                larguest = number;
            }            
        }
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The larguest number is {larguest}");
    }
}