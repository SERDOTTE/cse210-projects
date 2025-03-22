using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    // Constructor to initialize the scripture with a reference and text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
        _random = new Random();
    }

    // Method to display the scripture
    public void Display()
    {
        Console.WriteLine($"{_reference} {string.Join(" ", _words)}");
    }

    // Method to replace a random word in the scripture with underscores
    public bool ReplaceRandomWord()
    {
        List<Word> availableWords = _words.FindAll(word => !word.IsHidden);
        if (availableWords.Count == 0)
        {
            return false;
        }

        int index = _random.Next(availableWords.Count);
        availableWords[index].Hide();
        return true;
    }
}