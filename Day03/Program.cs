namespace practice
{
    internal class Program
    {
            static void Main(string[] args)
            {
                {
                    // Create two lines
                    Line line1 = new Line(0, 0, 1, 1);
                    Line line2 = new Line(0, 1, 1, 0);

                    // Compare lines using CompareTo method
                    int compareResult = line1.CompareTo(line2);

                    // Output the result
                    if (compareResult < 0)
                    {
                        Console.WriteLine("Line 1 is less than Line 2");
                    }
                    else if (compareResult > 0)
                    {
                        Console.WriteLine("Line 1 is greater than Line 2");
                    }
                    else
                    {
                        Console.WriteLine("Line 1 is equal to Line 2");
                    }
                }
            }
        
    }
}