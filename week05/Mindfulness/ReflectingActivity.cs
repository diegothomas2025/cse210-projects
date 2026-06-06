public class ReflectingActiviy : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActiviy(string name, string description) : base(name, description)
    {
    }

    public void Run()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they realted to this expirience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(10);
        }
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int number = random.Next(0, _prompts.Count);
        return $"--- {_prompts[number]} ---";
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int number = random.Next(0, _questions.Count);
        return $"> {_questions[number]}";
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}