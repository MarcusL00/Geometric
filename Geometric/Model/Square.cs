using System;

namespace Geometric.Model
{
    public class Square
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
            this._side = side;
        }

        //Method for calculating the perimiter of the square
        public float CalculatePerimiter()
        {
            return _side * 4;
        }
    }
}
