using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(new[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(w => new Word(w)).ToList();
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.ToString());
        Console.WriteLine(string.Join(" ", _words.Select(w => w.ToString())));
    }

    public void HideRandomWords()
    {
        var visibleWords = _words.Where(w => w.IsVisible).ToList();
        if (visibleWords.Count == 0) return;

        int wordsToHide = Math.Max(1, visibleWords.Count / 4);

        for (int i = 0; i < wordsToHide && visibleWords.Count > 0; i++)
        {
            int indexToHide = _random.Next(visibleWords.Count);
            visibleWords[indexToHide].Hide();
            visibleWords.RemoveAt(indexToHide);
        }
    }

    public bool AreAllWordsHidden()
    {
        return _words.All(w => !w.IsVisible);
    }
}