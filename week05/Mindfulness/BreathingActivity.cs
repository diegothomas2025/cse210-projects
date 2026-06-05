public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }
    
    public void Run()
    {
        int i = 0;
        while (GetDuration() > i)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(4);
            i += 4;
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            i += 6;
            Console.WriteLine();
        }
    }
}