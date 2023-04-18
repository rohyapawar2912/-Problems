using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Line : IComparable<Line>
    {

        public double x1 { get; set; }
        public double y1 { get; set; }
        public double x2 { get; set; }
        public double y2 { get; set; }

        // Constructor
        public Line(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        // Implement CompareTo method to compare lines based on endpoint coordinates
        public int CompareTo(Line other)
        {
            if (other == null)
            {
                return 1;
            }

            // Compare lines based on their endpoint coordinates
            int compare = x1.CompareTo(other.x1);
            if (compare != 0)
            {
                return compare;
            }

            compare = y1.CompareTo(other.y1);
            if (compare != 0)
            {
                return compare;
            }

            compare = x2.CompareTo(other.x2);
            if (compare != 0)
            {
                return compare;
            }

            return y2.CompareTo(other.y2);
        }


    }
}