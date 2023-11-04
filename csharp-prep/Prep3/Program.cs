using System;

class Program
{
    static void Main(string[] args)
    {
        int guess;
        int guessCount = 0;
        string again = "yes";
    
        while (again == "yes"){
            guess = -1;
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            while (guess != number){
            Console.Write("What is your guess? ");
            guessCount += 1;
            string new2 = Console.ReadLine();
            guess = int.Parse(new2);
            if (number > guess){
            Console.WriteLine("Higher");
            }
            else { 
            Console.WriteLine("Lower");
            }
            
            }
            
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {guessCount} guesses!");
            guessCount = 0;

            Console.WriteLine("Do you want to play again?");
            again = Console.ReadLine();

        
        }
        Console.WriteLine("Thanks for playing");
       
    }
}