using System.ComponentModel;
using System.Formats.Tar;
using System.Net;

public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        int total = 0;
        if (_amountCompleted != _target)
        {
            _amountCompleted++;
            if (_amountCompleted < _target)
            {
                Console.WriteLine($"Congratulations! You have earned {_points} points!");
                total = _points;
            }
            else if (_amountCompleted == _target)
            {
                Console.WriteLine($"Congratulations! You have earned {_points + _bonus} points!");
                total = _points + _bonus;
            }
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
        }   
        return total;
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        string status;
        if (IsComplete())
        {
            status = "[X]";
        }
        else
        {
            status = "[ ]";
        }
        return $"{status} {_shortName} ({_description}) -- Currenly Completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}