class Activity
{   //variables
    private string _name;
    private string _description;
    private int _duration;

    //constructo sin parametros 
    public Activity()
    {   // le damos valores a las variables
        _name = "Activity";
        _description = "Generic activity description.";
    }

    // metodo run que llama a los metodos que estan mas abajito :D
    public virtual void Run()
    {
        DisplayStartingMessage();
        DisplayEndingMessage();
    }

    public void DisplayStartingMessage()
    {   //Se escribe en la consola el nombre y la descripcion
        Console.WriteLine($"Starting {_name} - {_description}");
        // duration toma el valor de get duration que es un metodo que esta mas abajito :D
        _duration = GetDuration();
        Console.WriteLine($"Prepare to begin. Starting in {3} seconds.");
        //llama al metodo show countdown que mostrara una cuenta regresiva
        ShowCountDown(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Good job! You have completed {_name} in {_duration} seconds.");
        Console.WriteLine($"Pausing for a moment...");
        ShowCountDown(3);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public int GetDuration()
    {
        Console.WriteLine("Enter the duration of the activity in seconds: ");
        return int.Parse(Console.ReadLine());
    }
}