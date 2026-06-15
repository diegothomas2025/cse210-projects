using System.Security.Cryptography;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        int total = 0;
        if (_isComplete == false)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            total = _points;
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
        }
        return total;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }

}