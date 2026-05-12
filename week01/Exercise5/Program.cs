using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int squareNumber = SquareNumber(favNumber);
        
        displayResult(userName, squareNumber);

        static void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName ()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber ()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int SquareNumber (int num)
        {
            int square = num * num;
            return square;
        }
        
        static void displayResult (string userName, int number)
        {
            Console.WriteLine($"{userName}, the square of your number is {number}");
        }
    }
}