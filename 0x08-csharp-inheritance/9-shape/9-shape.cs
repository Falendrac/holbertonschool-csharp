using System;

/// <summary>Class Shape not implemented</summary>
class Shape
{
    /// <summary>Method Area not implemented yet</summary>
    /// <exceptions>NotImplementedException</exceptions>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}


/// <summary>Define a rectangle, inherited of Shape</summary>
class Rectangle : Shape
{
    // The width of rectangle
    private int width;
    // The height of rectangle
    private int height;

    /// <summary>Get or set the width with value</summary>
    /// <exceptions>ArgumentException when value is less than 0</exceptions>
    /// <returns>The width of the rectangle</returns>
    public int Width
    {
        get { return this.width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            this.width = value;
        }
    }

    /// <summary>Get or set the height with value</summary>
    /// <exceptions>ArgumentException when value is less than 0</exceptions>
    /// <returns>The height of the rectangle</returns>
    public int Height
    {
        get { return this.height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            this.height = value;
        }
    }

    /// <summary>Calculate the Area of the rectangle</summary>
    /// <returns>The area of the rectangle</returns>
    public new int Area()
    {
        return this.width * this.height;
    }

    /// <summary>Override ToString method for the new string representation</summary>
    /// <returns>The string representation of rectangle</returns>
    public override string ToString()
    {
        return "[Rectangle] " + this.width + " / " + this.height;
    }
}


/// <summary>Define a square, class inherited of Rectangle</summary>
class Square : Rectangle
{
    // The size of the Square
    private int size;

    /// <summary>Get or set the size with value</summary>
    /// <exceptions>ArgumentException when value is less than 0</exceptions>
    /// <returns>The size of the square</returns>
    public int Size
    {
        get
        {
            return this.size;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            this.size = value;
            this.Width = value;
            this.Height = value;
        }
    }

    /// <summary>Override ToString method for the new string representation</summary>
    /// <returns>The string representation of square</returns>
    public override string ToString()
    {
        return "[Square] " + this.size + " / " + this.size;
    }
}
