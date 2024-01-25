using System;

public class Word
{
    private string _text;
    private bool _isVisible = true;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isVisible = false;
    }

    public override string ToString()
    {
        return _isVisible ? _text : new string('_', _text.Length);
    }

    public bool IsVisible => _isVisible;
}
