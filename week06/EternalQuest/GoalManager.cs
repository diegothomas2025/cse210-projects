public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        string userChoice = "0";

        while (userChoice != "6")
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options: \n 1. Create New Goal \n 2. List Goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                CreateGoal();
            }
            else if (userChoice == "2")
            {
                ListGoalDetails();
            }
            else if (userChoice == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                SaveGoals(filename);
            }
            else if(userChoice == "4")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                LoadGoals(filename);  
            }
            else if (userChoice == "5")
            {
                RecordEvent();
            }
            else
            {
                Console.Clear();
            }
        }

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }
    public void ListGoalNames()
    {
        int i = 1;
        Console.WriteLine("The goals are: ");
        foreach (Goal goal in _goals)
        {
            Console.Write($"{i}. {goal.GetShortName()}\n");
            i++;
        }
        
    }
    public void ListGoalDetails()
    {
        int i = 1;
        Console.WriteLine("The goals are: ");
        foreach(Goal goal in _goals)
        {
            Console.Write($"{i}. {goal.GetDetailsString()}\n");
            i++;
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:\n 1. Simple Goal \n 2. Eternal Goal \n 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string userChoice = Console.ReadLine();
        if (userChoice == "1")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            _goals.Add(new SimpleGoal(name, description, points, false));
        }
        else if (userChoice == "2")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (userChoice == "3")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus, 0));
        }
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.WriteLine("Which goal did you accomplish? ");
        int userChoice = int.Parse(Console.ReadLine());
        int index = userChoice - 1;

        int pointsEarned = _goals[index].RecordEvent();
        _score += pointsEarned;
    }
    public void SaveGoals(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals(string file)
    {
        _goals.Clear();

        string[] lines = System.IO.File.ReadAllLines(file);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            char[] separators = new char[] { ':', ',' };
            string[] parts = line.Split(separators);

            string obj = parts[0];

            if (obj == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));

            }
            else if (obj == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));

            }
            else if (obj == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[4]), int.Parse(parts[6])));
            }

        }

    }
    


}