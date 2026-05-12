using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        
        //EXCERSIZE 2 IF STATEMENTS
        Console.Write("What is your grade porcentage? ");
        string answer = Console.ReadLine();
        int answerNumber = int.Parse(answer);
        string letter;

        if (answerNumber >= 90)
        {
            letter = "A";
        }
        else if (answerNumber >= 80)
        {
            letter = "B";
        }
        else if (answerNumber >= 70)
        {
            letter = "C";
        }
        else if (answerNumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
       

        Console.Write($"Your grade is: {letter} , ");

        if (answerNumber >= 70)
        {
            Console.Write("you approved.");
        }
        else
        {
            Console.Write("you disapproved, better luck next time.");
        }
    }
}