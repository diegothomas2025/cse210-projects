using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
        ReflectingActiviy reflectingActiviy = new ReflectingActiviy("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");


        while (option != 4)
        {
            Console.WriteLine("Menu Options: \n1. Start breathing activity \n2. Start reflecting activity  \n3.Start listing activity \n4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.Clear();
                breathingActivity.DisplayStartingMessage();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
            }
            else if (option == 2)
            {
                Console.Clear();
                reflectingActiviy.DisplayStartingMessage();
                reflectingActiviy.Run();
                reflectingActiviy.DisplayEndingMessage();
                
            }
            else if (option == 3)
            {
                Console.Clear();
                listingActivity.DisplayStartingMessage();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
            }
            else
            {
                Console.Clear();
            }
        }
    }
}