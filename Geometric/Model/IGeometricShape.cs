using System;

namespace Geometric.Model
{
    public interface IGeometricShape
    {
        float CalculatePerimeter();
        float CalculateArea();
    }
}