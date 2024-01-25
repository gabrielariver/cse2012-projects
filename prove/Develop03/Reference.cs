using System;
using System.Text.RegularExpressions;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;

    private Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public static Reference Parse(string input)
    {
        var match = Regex.Match(input, @"(\D+)\s+(\d+):(\d+)(-(\d+))?");
        if (!match.Success)
        {
            throw new ArgumentException("Invalid scripture reference format. Expected format: 'Book Chapter:Verse-EndVerse'");
        }

        string book = match.Groups[1].Value;
        int chapter = int.Parse(match.Groups[2].Value);
        int startVerse = int.Parse(match.Groups[3].Value);
        int? endVerse = match.Groups[5].Success ? int.Parse(match.Groups[5].Value) : (int?)null;

        return new Reference(book, chapter, startVerse, endVerse);
    }

    public override string ToString()
    {
        return _endVerse.HasValue ? $"{_book} {_chapter}:{_startVerse}-{_endVerse.Value}" : $"{_book} {_chapter}:{_startVerse}";
    }
}
