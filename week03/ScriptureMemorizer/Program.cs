using System;

class Program
{
    static void Main(string[] args)
    {
        Word word = new Word("TRUST");
        Console.WriteLine(word.GetDisplayText());
        Console.WriteLine(word.IsHidden());

        word.Shown();
        Console.WriteLine(word.GetDisplayText());

        word.Hide();
        Console.WriteLine(word.GetDisplayText());

    }
}