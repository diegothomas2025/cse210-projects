public abstract class Activity
{
    protected string _date;
    protected double _duration;
    private string _nameActivity;

    public Activity(string date, string nameActivity, double duration)
    {
        _date = date;
        _duration = duration;
        _nameActivity = nameActivity;
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    public virtual string GetSummary()
    {
        return $"{_date} {_nameActivity} - Distance: {Math.Round(CalculateDistance(), 1)} km, Speed: {Math.Round(CalculateSpeed(), 1)} kph, Pace: {Math.Round(CalculatePace(), 1)} min per km";
    }
    
}