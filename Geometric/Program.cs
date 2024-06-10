using Geometric.Model;

namespace Geometric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float side = 10;
            Square square = new Square(side);
            Console.WriteLine(square.CalculatePerimiter());
        }
    }
}
