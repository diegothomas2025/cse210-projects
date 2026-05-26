public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(" ");

        foreach (string element in words)
        {
            Word word = new Word(element);
            _words.Add(word);

        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        int visibleWords = 0;

        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                visibleWords++;
            }
        }

        if (numberToHide > visibleWords)
        {
            numberToHide = visibleWords;
        }

        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int randomIndex = random.Next(0, _words.Count);
            Word selectedWord = _words[randomIndex];

            if (selectedWord.IsHidden() == false)
            {
                selectedWord.Hide();
                hiddenCount++;
            }
        }


    }
    public string GetDisplayText()
    {
        string verseText = "";
        foreach (Word element in _words)
        {
            verseText += element.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {verseText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word element in _words)
        {
            bool response = element.IsHidden();

            if (response == false)
            {
                return false;
            }
        }
        return true;
    }
}