using System;

public class Shape
{
    public void Draw()
    {
        Console.WriteLine("Draw the shape.....");
    }
    
}

public class Triangle : Shape
{
    public void Hypothenus()
    {
        Console.WriteLine("The triangle's hypothenus = ");
    }
}

public class ColoredTriangle : Triangle
{
    public void Color()
    {
        Console.WriteLine("The color of the triangle is pink>>>");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ColoredTriangle pinkTriangle = new ColoredTriangle();
        pinkTriangle.Draw();
        pinkTriangle.Hypothenus();
        pinkTriangle.Color();
    }
}