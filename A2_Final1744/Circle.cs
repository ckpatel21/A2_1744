using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_Final1744
{
    public class Circle
    {
        private int radius { get; set; }

        public Circle(int radius)
        {
            this.radius = 1;
        }

        public Circle()
        {
            this.radius = 1;
        }

        public int GetRadius()
        {
            return this.radius;
        }

        public void SetRadius(int radius)
        {
            this.radius = radius;
        }

        public double GetCircumference()
        {
            return 2 * 3.14 * this.radius;
        }

        public double GetArea()
        {
            return 3.14 * this.radius * this.radius;
        }
    }
}
