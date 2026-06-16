public class SwimmingActivity : Activity
{
    private double _swimmingLaps;

    public SwimmingActivity(string date, string nameActivity, double duration, double swimmingLaps) : base(date, nameActivity, duration)
    {
        _swimmingLaps = swimmingLaps;
    }

    public override double CalculateDistance()
    {
        return _swimmingLaps * 50 / 1000;
    }
    public override double CalculateSpeed()
    {
        return (CalculateDistance() / _duration) * 60;
    }
    public override double CalculatePace()
    {
        return 60 / CalculateSpeed();
    }
}