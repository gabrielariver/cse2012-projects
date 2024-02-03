//As part of creativity, a log was created that was added to the "Breathing" class 
//and allows you to automatically document each time a user starts and completes that activity,
// the start and end timestamps, and the duration of the activity.
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            Activity activity = null;
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the mindfulness application.");
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    continue;
            }

            try
            {
                activity?.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.WriteLine("Would you like to perform another activity? (yes/no)");
            if (Console.ReadLine().Trim().ToLower() != "yes")
            {
                Console.WriteLine("Thank you for using the mindfulness application. See you next time!");
                break;
            }
        }
    }
}
