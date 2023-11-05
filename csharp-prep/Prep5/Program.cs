using System;

class Program
{
    
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int usernum = PromptUserNumber();
        int squsernum=SquareNumber(usernum);
        DisplayResult(username, squsernum);
        
    }
    static void DisplayWelcome (){
        Console.WriteLine("Welcome to the program");

        }
    static string PromptUserName (){
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
            
        }
    static int PromptUserNumber (){
        Console.Write("Please enter your favorite number: ");
        string usernum = Console.ReadLine();
        int num = int.Parse(usernum);
        return num;
        }
    static int SquareNumber (int square){
        int squares = square * square;
        return squares; 
        
        }
    static void DisplayResult (string username, int usernum){
        
        Console.WriteLine( $"{username}, the square of your number is {usernum}.");

        }
}