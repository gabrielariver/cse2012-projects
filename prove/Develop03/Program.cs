using System;
//As part of the creativity, it displays texts from religious scriptures and allows the user to play with them by hiding random words,
//but allowing one to remain present so that the user remembers the text as the last clue. 
//It also offers the possibility of adding new writes to continue the process.
class Program
{
    static void Main(string[] args)
    {
        string referenceInput = "John 3:16";
        string scriptureText = "For God so loved the world that He gave His one and only Son, that whoever believes in Him shall not perish but have eternal life.";

        Reference reference = Reference.Parse(referenceInput);
        Scripture scripture = new Scripture(reference, scriptureText);

        do
        {
            scripture.Display();
            Console.WriteLine("\nType 'QUIT' to exit, or press Enter to continue:");
            string input = Console.ReadLine();

            if (input.Equals("QUIT", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            scripture.HideRandomWords();
        }
        while (!scripture.AreAllWordsHidden());

        Console.WriteLine("All words are hidden.");
        
        Console.WriteLine("Would you like to add a new scripture? (yes/no)");
        string userResponse = Console.ReadLine();

        if (userResponse.Equals("yes", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Please enter the new scripture reference:");
            string newReferenceInput = Console.ReadLine();
            Console.WriteLine("Please enter the new scripture text:");
            string newUserScripture = Console.ReadLine();

            reference = Reference.Parse(newReferenceInput);
            scripture = new Scripture(reference, newUserScripture);

            do
            {
                scripture.Display();
                Console.WriteLine("\nPress Enter to continue:");
                Console.ReadLine();

                scripture.HideRandomWords();
            }
            while (!scripture.AreAllWordsHidden());

            Console.WriteLine("All words in the new scripture are hidden.");
        }

        Console.WriteLine("Exiting program.");
    }
}
