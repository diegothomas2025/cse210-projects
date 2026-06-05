public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity(string name, string description) : base(name, description)
    {

    }
    public void Run()
    {
        _count = 0;
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");

    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int number = random.Next(0, _prompts.Count);
        Console.WriteLine($"---{_prompts[number]}---");
    }

    public List<string> GetListFromUser()
    {
        List<string> ListFromUser = new List<string>();
        return ListFromUser;

    }
}