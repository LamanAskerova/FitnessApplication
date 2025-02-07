namespace FitnessApplication;

internal class Program
{
    static void Main(string[] args)
    {
        FitnessTracker fitnessTracker = new FitnessTracker("NewFit");
        fitnessTracker.AddUsers("Lucy");
        fitnessTracker.TrackSteps(1000);
        fitnessTracker.AddUsers("Henry");
        fitnessTracker.DeleteAccount("Lucy");
        fitnessTracker.PrintInfo();

        Console.WriteLine();

        FitProTrack fitProTrack = new FitProTrack("ProFit");
        fitProTrack.AddUsers("Mike");
        fitProTrack.AddUsers("Faya");
        fitProTrack.AddUsers("Li");
        fitProTrack.DeleteAccount("Mike");
        fitProTrack.TrackSteps(15000);
        fitProTrack.PrintInfo();

        Console.WriteLine();

        Activity running = new Running();
        running.CalculateCalories("Morning ",15);
        running.SetCurrentActivity();

        Console.WriteLine();

        Activity cycling = new Cycling();
        cycling.CalculateCalories("Late Night" , 10);
        cycling.SetCurrentActivity();
    }
}