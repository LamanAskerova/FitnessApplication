namespace FitnessApplication;

internal class Running : Activity
{
    private int Calories = 10;
    public int minutes { get; set; }

    internal override void CalculateCalories(int minutes)
    {
        int answer = Calories * minutes;
        Console.WriteLine($"Running burned {answer} calories in {minutes} minutes.");
    }
}
