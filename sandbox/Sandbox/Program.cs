using System;

class Program
{
    static void Main(string[] args)
    {
        string escritura = "Escritura";
        Console.WriteLine(escritura);
        Console.WriteLine("Type continue if you want to continue or end if you want to quit");
        string hola = Console.ReadLine();
        if (hola == " "){
        foreach (var item in escritura)
        {
            
        }
        Random rand = new Random();
        int index = rand.Next(escritura.Count);
        string hey = escritura[index];
        
        Console.Clear();
        Console.WriteLine("Hola soy lily");
        }
        else {
            Console.Clear();
            Console.WriteLine("Thanks for playing");

        }

        
        

    }
}