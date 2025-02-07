namespace FitnessApplication;

internal class Cycling : Activity
{
    private int Calories = 8;
    public int minutes { get; set; }

    internal override void CalculateCalories(int minutes)
    {
        int answer = Calories * minutes;
        Console.WriteLine($"Cycling burned {answer} calories in {minutes} minutes.");
    }
}
