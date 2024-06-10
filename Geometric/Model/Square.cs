using System;

namespace Geometric.Model
{
    public class Square : IGeometricShape
    {
        private float _side;

        // Property
        public float Side
        {
            get => _side;
            set => _side = value;
        }

        // Constructor
        public Square(float side)
        {
            _side = side;
        }

        // Method for calculating the perimeter of the square
        public float CalculatePerimeter()
        {
            return _side * 4;
        }

        // Method for calculating the area of the square
        public float CalculateArea()
        {
            return _side * _side;
        }
    }
}