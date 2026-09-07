using System.Security.Cryptography.X509Certificates;

namespace tubles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pt1 = (X: 1, Y: 2);
            var slope = (double)pt1.Y / (double)pt1.X;
            Console.WriteLine($"A line from the origin to the point {pt1} has a slope of {slope}.");
            pt1.X += 5;
            Console.WriteLine($"The point is now at {pt1}.");

            var pt2 = pt1 with { X = 3, Y = 10 };
            Console.WriteLine($"A line from the origin to the point {pt2} has a slope of {slope}.");

            var subscript = (A: 0, B: 0);
            subscript = pt1;
            Console.WriteLine(subscript);

            var namedData = (

                Name: "Morning observation",
                Temp: 17,
                Wind: 4
                );
            Console.WriteLine(namedData);

            Point pt3 = new Point(3, 4);
            var pt4 = pt3 with { X = 5, Y = 6 };
            double slopeResult = pt4.Slope();
            Console.WriteLine($"The slope of {pt4} is {slopeResult}");
            Console.WriteLine($"the 2 points are {pt3} and {pt4}");

            Student student1 = new Student("Alice", 20, "Computer Science");
            Console.WriteLine(student1.ToString());

        }
        public record struct Point(int X, int Y)
        {
            public double Slope() => (double)Y / (double)X;
        }

        public record struct Student(string Name, int Age, string Major)
        {
            public override string ToString() => $"{Name}, {Age}, {Major}";

        }
    }
}
