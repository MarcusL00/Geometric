using System;

namespace Geometric.Model
{
    public class Parallelogram : IGeometricShape
    {
        private float _length;
        private float _width;
        private float _angle;

        // Properties
        public float Length
        {
            get => _length;
            set => _length = value;
        }

        public float Width
        {
            get => _width;
            set => _width = value;
        }

        public float Angle
        {
            get => _angle;
            set => _angle = value;
        }

        // Constructor
        public Parallelogram(float length, float width, float angle)
        {
            _length = length;
            _width = width;
            _angle = angle;
        }

        // Method for calculating the perimeter of the parallelogram
        public float CalculatePerimeter()
        {
            return 2 * (_length + _width);
        }

        // Method for calculating the area of the parallelogram
        public float CalculateArea()
        {
            // Convert angle to radians
            float angleInRadians = _angle * (MathF.PI / 180.0f);
            return _length * _width * MathF.Sin(angleInRadians);
        }
    }
}