using System;

public class Bodya
{
    public static void Main()
    {

    }

}

abstract class CGraphicsObject
{
    public abstract void Show();

    ~CGraphicsObject()
    {
        Console.WriteLine("Destructor was called!");
    }
}

interface ITriangle
{
    double CalculateArea();
}

interface IHexagon
{
    double CalculateArea();
}

class Triangle : CGraphicsObject, ITriangle
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double a, double b, double c)
    {
        this.SideA = a;
        this.SideB = b;
        this.SideC = c;
    }

    public double CalculateArea()
    {
        double p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * ((p - SideA) + (p - SideB) + (p - SideC)));
    }

    public override void Show()
    {
        Console.WriteLine("Side A:{0} Side B:{1} Side B:{2}", SideA, SideB, SideC);
    }

    public delegate double AreaDelegate();

    ~Triangle()
    {
        Console.WriteLine("Hexagon was removed from memory");
    }
}

class Hexagon : CGraphicsObject, IHexagon
{
    public double Side { get; set; }

    public Hexagon(double side)
    {
        this.Side = side;
    }

    public override void Show()
    {
        Console.WriteLine("Side Length: {0}", Side);
    }

    public double CalculateArea()
    {
        return ((3 * Math.Sqrt(3)) / 2) * Math.Pow(Side, 2);
    }

    public delegate double AreaDelegate();

    ~Hexagon()
    {
        Console.WriteLine("Hexagon was removed from memory");
    }
}