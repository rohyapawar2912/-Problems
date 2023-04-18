namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("enter the x1 point");
                double x1 = double.Parse(Console.ReadLine());
                Console.WriteLine("enter the y1 point");
                double y1 = double.Parse(Console.ReadLine());
                Console.WriteLine("enter the x2 point");
                double x2 = double.Parse(Console.ReadLine());
                Console.WriteLine("enter the y2 point");
                double y2 = double.Parse(Console.ReadLine());
                Console.WriteLine("enter the p1 point");
                double p1 = double.Parse(Console.ReadLine());
                Console.WriteLine("enter the q1 point");
                double q1 = double.Parse(Console.ReadLine());
                Console.WriteLine("enter the p2 point");
                double p2 = double.Parse(Console.ReadLine());
                Console.WriteLine("enter the q2 point");
                double q2 = double.Parse(Console.ReadLine());
                double length1 = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));
                double length2 = Math.Sqrt((Math.Pow((p2 - p1), 2)) + (Math.Pow((q2 - q1), 2)));
                Console.WriteLine(length1 == length2);
            }
        }
    }

}
