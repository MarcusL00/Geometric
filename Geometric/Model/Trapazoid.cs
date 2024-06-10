namespace Geometric.Model;

public class Trapazoid : IGeometricShape
{
    private float _bottom;
    private float _side1;
    private float _top;
    private float _side2;
    

    // Properties
    public float Bottom
    {
        get => _bottom;
        set => _bottom = value;
    }

    public float Side1
    {
        get => _side1;
        set => _side1 = value;
    }

    public float Top
    {
        get => _top;
        set => _top = value;
    }  
    public float Side2
    {
        get => _side2;
        set => _side2 = value;
    }
    // Constructor
    public Trapazoid(float bottom, float side1, float top, float side2)
    {
        _bottom = bottom;
        _side1 = side1;
        _top = top;
        _side2 = side2;
    }
    // Method for calculating the perimeter of the trapezoid
    public float CalculatePerimeter()
    {
        return (_bottom + _side1 + _top + _side2);
    }

    // Method for calculating the area of the trapezoid
    public float CalculateArea()
    {
        float s = (_bottom + _side1 + _top + _side2) / 2;
        float height = (2.0f / (_bottom - _top)) * (float)Math.Sqrt(s * (s - _bottom + _top) * (s - _side1) * (s - _side2));
        Console.WriteLine(height);
        return (0.5f * (_bottom + _top) * height);
    }
}