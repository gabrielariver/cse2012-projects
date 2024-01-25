using System;
//As part of the creativity, the program can be repeated for new writings as desired by the user and also leaves a single word as a clue.
//Additionally, if the user misspells their references, it allows them to enter the text but not continue with 
//the process of hiding the words. Reference, Scripture, and Words classes work together to handle and display
//biblical information in a structured and organized way.
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter the reference of the scripture (e.g., 'John 3:16'):");
            string referenceInput = Console.ReadLine();
            Console.WriteLine("Enter the text of the scripture:");
            string scriptureText = Console.ReadLine();

            Reference reference;
            try
            {
                reference = Reference.Parse(referenceInput);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                continue;
            }

            Scripture scripture = new Scripture(reference, scriptureText);

            do
            {
                scripture.Display();
                Console.WriteLine("\nType 'QUIT' to exit, or press Enter to continue:");
                string input = Console.ReadLine();

                if (input.Equals("QUIT", StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }

                scripture.HideRandomWords();
            }
            while (!scripture.AreAllWordsHidden());

            Console.WriteLine("All words are hidden. Exiting program.");

            Console.WriteLine("Would you like to learn another scripture? (yes/no):");
            string answer = Console.ReadLine();
            if (!answer.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
        }
    }
}
