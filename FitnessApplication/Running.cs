namespace FitnessApplication;

internal class Running : Activity
{
    private int Calories = 10;
    public int Duration { get; set; }
    public string  ActivityName { get; set; }
    public string CurrentActivity;

    internal override void CalculateCalories(string activityName , int duration)
    {
        int answer = Calories * duration;
        Console.WriteLine($"Running {ActivityName} burned {answer} calories in {duration} minutes.");
        CurrentActivity = $"Running {activityName}";
    }

    internal override void SetCurrentActivity()
    {
        Console.WriteLine($"Now is {CurrentActivity}");
    }
}
