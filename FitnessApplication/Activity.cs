using System.Globalization;

namespace FitnessApplication;

internal abstract class Activity
{
    public string ActivityName { get; set; }
    public int Duration { get; set; }
    public int CaloriesBurned { get; set; }
    public int Minutes;

    internal abstract void CalculateCalories(string ActivityName , int duration);

    internal abstract void SetCurrentActivity();
}
