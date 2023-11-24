using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        // First constructor which has the reference of the scripture
        Reference reference = new Reference("John", 3 , 16 );
        Scripture scripture = new Scripture(reference, "In god we believe");
        Console.WriteLine(scripture);
        while (true){
            Console.WriteLine("Press enter to continue or type quit to leave.");
            string user = Console.ReadLine();
            if (user == "quit"){
                break;
            }
            scripture.HideRandomWords(2);
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden()){
                Console.WriteLine("All words are hidden.");
                break;

            }

        }
    }

}
    