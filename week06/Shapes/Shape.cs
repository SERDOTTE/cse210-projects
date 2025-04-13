using System;

public abstract class Shape
{
    private string _color;

    // Constructor
    public Shape(string color)
    {
        _color = color;
    }

    // Getter for Color
    public string GetColor()
    {
        return _color;
    }

    // Abstract method for GetArea
    public abstract double GetArea();
}