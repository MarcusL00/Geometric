using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric.Model
{
    internal class Rectangle : Square, IRectangle
    {
        public Rectangle(float side) : base(side)
        {
        }
    }
}
