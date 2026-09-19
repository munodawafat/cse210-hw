using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<string> _words;

    public List<string> Words { get => _words; set => _words = value; }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        Words = new List<string>(text.Split(' ', StringSplitOptions.RemoveEmptyEntries));

        foreach (string word in Words)
        {
            Words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < count && Words.Count > 0)
        {
            int randomIndex = random.Next(Words.Count);
            Word wordToHide = Words[randomIndex];

            if (!wordToHide.IsHidden)
            {
                wordToHide.Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.ToString() + " ";

        foreach (Word word in Words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in Words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true;
    }
}