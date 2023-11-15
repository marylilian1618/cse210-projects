using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        //while is true that we started de constructor

        while (true){
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.WriteLine("What would you like to do?: ");
            //ahora el programa lee lo que el usuario escribe 
            // y ejecuta un switch que ejecutara cada programa 
            //dependiendo de lo que necesitaba hacerse
            string choice = Console.ReadLine();
            switch (choice){
                case "1":
                Entry newentry = new Entry();
                newentry._date = DateTime.Now.ToString();
                newentry._promptText = promptGenerator.GetRandomPrompt();
                //De promptgenerator (el cual ya fue declarado
                //como una instancia de Prompt Generator) y ahora
                // obtendremos get random prompt de la clase prompt generator
                Console.WriteLine(newentry._promptText);
                //imprimimos la pregunta random 
                Console.WriteLine("Your answer: ");
                newentry._entryText = Console.ReadLine();
                //Leemos lo que escribio el usuario y lo guardamos 
                // en _entrytext de la clase newentry
                journal.AddEntry(newentry);
                //llamamos a metodo addEntry de journal 
                // el cual es una instancia creada de la clase Journal
                // y le pasamos como parametro los datos que contiene newentry
                break;
                case "2":
                journal.DisplayAll();
                //llamamos a metodo displayall el cual mostrara los datos
                // guardados como la fecha, la pregunta y la respuesta imprimiendo
                // gracias a foreach cada uno de ellos ( revisar)
                break;
                case "3":
                Console.WriteLine("What is the filename?: ");
                string fileName = Console.ReadLine();
                journal.SavetoFile(fileName);
                Console.WriteLine("Journal saved");
            
                break;
                case "4":
                Console.WriteLine("What is the filename?: ");
                string newName = Console.ReadLine();
                journal.LoadFromFile(newName);
                Console.WriteLine("Journal loaded successfully!");
                break;
                case "5":
                Environment.Exit(0);
                break;
                default:
                Console.WriteLine("Invalid option. Try again.");
                break;

            };

        }

    }
}