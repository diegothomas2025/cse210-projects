using System;

class Program
{
    static void Main(string[] args)
    {

        string verses = "And by the power of the Holy Spirit you will be able to know the truth of all things; And whatever is good, is just and true; therefore, nothing that is good denies the Christ, but rather recognizes that he exists.";

        Reference reference = new Reference("Moroni", 10, 5, 6);
        Scripture scripture = new Scripture(reference, verses);

        string user = "";

        while (user != "quit")
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            user = Console.ReadLine();

            if (user == "")
            {
                scripture.HideRandomWords(3);

                if (scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    break;
                }
            }
        } 
    }
}