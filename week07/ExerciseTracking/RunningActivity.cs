using System.Reflection.Emit;

public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, string nameActivity, double duration, double distance) : base(date,nameActivity, distance)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculateSpeed()
    {
        return (_distance / _duration) * 60;
    }
    public override double CalculatePace()
    {
        return _duration / _distance;
    }
}