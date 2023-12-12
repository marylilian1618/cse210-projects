/// <summary>
/// What is a benefit to having a separate class like
/// GoalManager instead of just using static functions in
/// Program.cs for all of the menu-related functionality?
/// </summary>
public class GoalManager{
    List <Goal> _goals;
    protected int _score;
    
    public GoalManager(){
        _goals = new List<Goal>();
        _score = 0;

        LoadGoals();

    }
    //El menu se crea aqui
    public void Start(){
        bool exit = false;
        while (!exit){
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");

            Console.WriteLine("Enter your choice: ");
            int results =int.Parse(Console.ReadLine());
            switch (results)
            {
                case 1:
                DisplayPlayerInfo();
                break;
                case 2:
                ListGoalNames();
                break;
                case 3:
                ListGoalDetails();
                break;
                case 4:
                CreateGoal();
                break;
                case 5:
                RecordEvent();
                break;
                case 6:
                SaveGoals();
                break;
                case 7:
                LoadGoals();
                break;
                case 8:
                exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

            }
        }


    }
    public void DisplayPlayerInfo(){
        Console.WriteLine($"Player Score: {_score}");

    }
    public void ListGoalNames(){
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetShortName());
        }

    }
    public void ListGoalDetails(){
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }

    }
    public void CreateGoal(){
         Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Enter the type of goal (1-3): ");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter goal points: ");
        string points = Console.ReadLine();

        switch (typeChoice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target for checklist goal: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus for checklist goal: ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice. Goal creation failed.");
                break;
        }

    }
    public void RecordEvent(){
        Console.WriteLine("Enter the index of the goal you want to record an event for:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }

        Console.Write("Enter the index: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            Console.WriteLine("Event recorded successfully!");
        }
        else
        {
            Console.WriteLine("Invalid index. Event recording failed.");
        }

    }
    public void SaveGoals(){
        try
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                foreach (var goal in _goals)
                {
                    writer.WriteLine($"{goal.GetType().Name},{goal.GetShortName()},{goal.GetDescription()},{goal.GetPoints()}");
        
                }
            }
            Console.WriteLine("Goals saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
 
    }
    public void LoadGoals(){
        try
        {
            if (File.Exists("goals.txt"))
            {
                _goals.Clear();
                using (StreamReader reader = new StreamReader("goals.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] parts = reader.ReadLine().Split(',');
    
                        if (parts.Length >= 4)
                        {
                            string goalType = parts[0];
                            string shortName = parts[1];
                            string description = parts[2];
                            string points = parts[3];

                            switch (goalType)
                            {
                                case "SimpleGoal":
                                    _goals.Add(new SimpleGoal(shortName, description, points));
                                    break;
                                case "EternalGoal":
                                    _goals.Add(new EternalGoal(shortName, description, points));
                                    break;
                                case "ChecklistGoal":
                                    if (parts.Length >= 6)
                                    {
                                        int target = int.Parse(parts[4]);
                                        int bonus = int.Parse(parts[5]);
                                        _goals.Add(new ChecklistGoal(shortName, description, points, target, bonus));
                                    }
                                    break;
                                
                            }
                        }
                    }
                }
                Console.WriteLine("Goals loaded successfully!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }

    }



}