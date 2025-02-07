using System.ComponentModel.Design;

namespace FitnessApplication;

internal class FitnessTracker
{
    public string DeviceName { get; set; }
    public int BatteryLife = 24;
    public int TotalSteps { get; set; }
    public int Name { get; set; }
    public string[] Users = new string[3];
    private int CurrentUser = 0;
    private int MaxUserCount = 3;
    private int steps;

    public FitnessTracker(string deviceName)
    {
        DeviceName = deviceName;
    }

    internal virtual void TrackSteps(int totalSteps)
    {
        int MaxSteps = 50000;
        if (totalSteps > 0 && totalSteps < MaxSteps)
        {
            steps = totalSteps;
        }
        else
        {
            Console.WriteLine("Invalid number of steps. Please enter a value between 1 and 50,000.");
        }
    }

    internal virtual void AddUsers(string name)
    {
        if (CurrentUser < Users.Length && CurrentUser < MaxUserCount)
        {
            Users[CurrentUser] = name;
            Console.WriteLine($"User {name} has been added.");
            CurrentUser++;
        }
        else
        {
            Console.WriteLine($"User {name} has not been added. The limit of 3 users has been reached.");
        }
    }


    internal virtual void PrintInfo()
    {
        Console.WriteLine($"FitTrack is called '{Users[Name]}'s Tracker', it has {BatteryLife} hours of battery\r\nlife, {steps} total steps, and {CurrentUser} users.\"`");
    }

    internal virtual void DeleteAccount(string Name)
    {
        int indexToRemove = -1;
        for (int i = 0; i < MaxUserCount; i++)
        {
            if (Users[i] == Name)
            {
                indexToRemove = i;
                break;
            }
        }

        if (indexToRemove != -1)
        {
            for (int i = indexToRemove; i < CurrentUser - 1; i++)
            {
                Users[i] = Users[i + 1];
            }

            Users[CurrentUser - 1] = null;

            CurrentUser--;
            Console.WriteLine($"Account '{Name}' was deleted");
        }
        else
        {
            Console.WriteLine($"Account '{Name}' not found");
        }
    }
}
