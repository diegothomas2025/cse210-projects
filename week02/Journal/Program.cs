using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();
        

        Console.WriteLine("Welcome to the Journal Program!");
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Entry entry = new Entry();

                entry._date = theCurrentTime.ToShortDateString();
                entry._promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine(entry._promptText);
                entry._entryText = Console.ReadLine();

                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);
                
            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);

            }
        }
    }
}