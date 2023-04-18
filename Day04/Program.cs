using System;
abstract class test
{
    public abstract double twoLines(double x1, double y1, double x2, double y2);
}
class child1 : test
{
    public override double twoLines(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));
    }
}
class main
{
    public static void Main(string[] args)
    {
        child1 c = new child1();
        double length1 = c.twoLines(10, 22, 45, 91);
        double length2 = c.twoLines(93, 52, 19, 29);
        int status = length1.CompareTo(length2);
        if (status > 0)
            Console.WriteLine("{0} is greater than {1}", length1, length2);
        else if (status < 0)
            Console.WriteLine("{0} is lesser than {1}", length1, length2);
        else
            Console.WriteLine("{0} is equal to {1}", length1, length2);
    }
}