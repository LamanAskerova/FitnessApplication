namespace FitnessApplication;

internal class FitProTrack : FitnessTracker
{
    public string Name { get; set; }
    public string DeviceName { get; set; }
    public int BatteryLifePro = 48;
    public int TotalSteps { get; set; }
    public string[] Users = new string[5];
    private int CurrentUser = 0;
    private int MaxUserCount = 5;
    private int steps = 0;

    public FitProTrack(string deviceName) : base(deviceName)
    {
        DeviceName = deviceName;
    }

    internal override void TrackSteps(int totalSteps)
    {
        int MaxSteps = 100000;
        if (totalSteps > 0 && totalSteps < MaxSteps)
        {
            steps = totalSteps;
        }
        else
        {
            Console.WriteLine("Invalid number of steps. Please enter a value between 1 and 100,000.");
        }
    }
    internal override void AddUsers(string name)
    {
        if (CurrentUser < Users.Length && CurrentUser < MaxUserCount)
        {
            Users[CurrentUser] = name;
            Console.WriteLine($"User {name} has been added.");
            CurrentUser++;
        }
        else
        {
            Console.WriteLine($"User {name} has not been added. The limit of 5 users has been reached.");
        }
    }
    internal override void PrintInfo()
    {
        Console.WriteLine($"FitTrack is called '{Name}'s Tracker', it has {BatteryLife} hours of battery\r\nlife, {steps} total steps, and {CurrentUser} users.\"`");
    }

    internal override void DeleteAccount(string Name)
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
