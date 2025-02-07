namespace FitnessApplication;

internal class Cycling : Activity
{
    private int Calories = 8;
    public int Duration { get; set; }
    public string ActivityName { get; set; }
    public string CurrentActivity;


    internal override void CalculateCalories(string activityName , int duration)
    {
        int answer = Calories * duration;
        Console.WriteLine($"Cycling {activityName}  burned {answer} calories in {duration} minutes.");
        CurrentActivity = $"Cycling {activityName}";
    }
    internal override void SetCurrentActivity()
    {
        Console.WriteLine($"Now is {CurrentActivity}");
    }
}
