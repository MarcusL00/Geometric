﻿using System;

namespace Geometric.Model
{
    public class Rectangle : IGeometricShape
    {
        private float _length;
        private float _width;

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

        // Constructor
        public Rectangle(float length, float width)
        {
            _length = length;
            _width = width;
        }

        // Method for calculating the perimeter of the rectangle
        public float CalculatePerimeter()
        {
            return 2 * (_length + _width);
        }

        // Method for calculating the area of the rectangle
        public float CalculateArea()
        {
            return _length * _width;
        }
    }
}