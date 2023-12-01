
class BreathingActivity : Activity
{
    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        Console.WriteLine("Clear your mind and focus on your breathing.");

        int seconds = GetDuration();
        int countdown = seconds;

        while (countdown > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(2);

            Console.WriteLine("Breathe out...");
            ShowCountDown(2);

            countdown -= 4; // 2 seconds for each message
        }

        DisplayEndingMessage();
    }
}
