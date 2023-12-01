class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        int seconds = GetDuration();
        int countdown = seconds;

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowCountDown(5);

        List<string> items = GetListFromUser();
        Console.WriteLine($"Number of items entered: {items.Count}");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        Console.WriteLine("List as many items as you can. Press enter after each item. Press enter twice to finish.");

        while (true)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(item))
            {
                break;
            }

            items.Add(item);
        }

        return items;
    }
}