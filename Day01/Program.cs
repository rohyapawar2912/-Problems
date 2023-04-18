namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Input the coordinates of the two points
                Console.WriteLine("Enter the coordinates of Point 1 (x1, y1):");
                double x1 = Convert.ToDouble(Console.ReadLine());
                double y1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the coordinates of Point 2 (x2, y2):");
                double x2 = Convert.ToDouble(Console.ReadLine());
                double y2 = Convert.ToDouble(Console.ReadLine());

                // Calculate the length of the line
                double length = CalculateLineLength(x1, y1, x2, y2);

                // Output the result
                Console.WriteLine("The length of the line between Point 1 and Point 2 is: " + length);
            }

            static double CalculateLineLength(double x1, double y1, double x2, double y2)
            {
                // Calculate the square of the differences in x and y coordinates
                double dx = x2 - x1;
                double dy = y2 - y1;
                double dxSquared = Math.Pow(dx, 2);
                double dySquared = Math.Pow(dy, 2);

                // Calculate the length of the line using the formula: sqrt(dx^2 + dy^2)
                double length = Math.Sqrt(dxSquared + dySquared);

                return length;
            }

        }
    }
}
