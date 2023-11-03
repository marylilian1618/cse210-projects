using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you grade percentage? ");
        string userdata = Console.ReadLine();
        int grades = int.Parse(userdata);
        string letter = "";
        if (grades >= 90)
        {
            letter = "A";
        }
        else if (grades >= 80){
            letter = "B";
        }
        else if (grades >= 70){
            letter = "C";

        }
        else if (grades >= 60){
            letter = "D";
        }
        else{
            letter = "F";
        }

        // sign + or -
        int plus = grades%10;
        string sign = "";

        if (grades <= 93 && grades >= 70){
            if (plus >= 7){
            sign = "+";
            }
            else if (plus <3) {
            sign = "-";
            }
            else{
                sign = "";
            }
        }


        Console.WriteLine($"Your grade is {sign}{letter}.");

        if(grades >= 70){
            Console.WriteLine("You passed the course.");
        }
        else{
            Console.WriteLine("Don't give up!. You'll do next period :D");
        }



        

    }
}