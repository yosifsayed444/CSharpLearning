
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //// Value type vs Reference type
            //int n = 4;

            //string s1 = "Youssef";
            //string s2 = " Sayed";

            //string s3 = s1 + s2;
            //Console.WriteLine(s3);

            //Console.WriteLine($"My name is {s1}{s2}");


            //// var
            //var myVar = "Youssef";
            //var f = 3.14f;
            //var d = 3.14d;
            //var b = true;
            //var c = 'A';

            //Console.WriteLine(myVar);
            //Console.WriteLine(f);
            //Console.WriteLine(d);
            //Console.WriteLine(b);
            //Console.WriteLine(c);


            //// dynamic
            //dynamic myDynamic = 9;

            //myDynamic = "some string";
            //myDynamic = 3.14;

            //Console.WriteLine(myDynamic);


            //// Operators
            //int x = 10;
            //int y = 10;

            //Console.WriteLine(x == y);

            //bool isVip = 1000 >= 900;

            //Console.WriteLine(isVip);


            //bool isFirstFive = true;
            //double GPA = 3.69;

            //bool isEligible = GPA >= 3.5 && isFirstFive;

            //Console.WriteLine(isEligible);


            //WorkWithIntegers();

            //OrderPrecedence();

            //WorkWithDoubles();


            //// Circle
            //double radius = 2.5;

            //Console.WriteLine(CalculateCircleArea(radius));


            //// Strings
            //string name = "Youssef";

            //Console.WriteLine(name);

            //name = "Ahmed";

            //Console.WriteLine($"Hello my name is {name}");


            //string firstFriend = "Ali";
            //string secondFriend = "Mohamed";

            //Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

            //Console.WriteLine(firstFriend.Length);


            //// White spaces
            //string greeting = "      Hello World!       ";

            //Console.WriteLine($"[{greeting}]");

            //Console.WriteLine($"[{greeting.TrimStart()}]");
            //Console.WriteLine($"[{greeting.TrimEnd()}]");
            //Console.WriteLine($"[{greeting.Trim()}]");


            //// Replace and search
            //string text = "Hello World!";

            //Console.WriteLine(text);

            //text = text.Replace("Hello", "Greetings");

            //Console.WriteLine(text);

            //Console.WriteLine(text.ToUpper());
            //Console.WriteLine(text.ToLower());


            //string songLyrics = "You say goodbye, and I say hello";

            //Console.WriteLine(songLyrics.Contains("goodbye"));
            //Console.WriteLine(songLyrics.Contains("hello"));

            //Console.WriteLine(songLyrics.StartsWith("You"));


            // Value type: each variable holds its own copy
            var point1 = new Coords(3, 4);
            var point2 = point1;
            Console.WriteLine($"point1: ({point1.X}, {point1.Y})");
            Console.WriteLine($"point2: ({point2.X}, {point2.Y})");
            point2 = new Coords(5,6);
            Console.WriteLine($"point1: ({point1.X}, {point1.Y})");
            Console.WriteLine($"point2: ({point2.X}, {point2.Y})");
            // point1 and point2 are independent copies
            // Reference type: both variables refer to the same object
            var list1 = new List<int> { 1, 2, 3 };
            var list2 = list1;
            list2.Add(4);
            list1.Add(10);
            PrintList(list1);
            PrintList(list2);

            int population = 67_000_000;
            long distance = 384_400_000L;
            short temperature = -40;
            byte red = 255;
            double pi = 3.141592653589793;
            float gravity = 9.81f;
            decimal price = 19.99m;
            uint fileSize = 4_294_967_295;
            ulong totalBytes = 18_446_744_073_709_551_615;
            ushort port = 443;
            bool isValid = true;
            char grade = 'A';
            string greeting = "Hello, world!";

            //int literals
            int dec = 42;
            int hex = 0x2A;
            int bin = 0b_0010_1010;
            long big = 1_000_000_000L;
            Console.WriteLine(dec.GetType());

            // floating-point literals
            double d = 3.14;
            float f = 3.14f;
            decimal m = 3.14m;
            double scientific = 1.5e6;

            // char and string literals
            char newline = '\n';
            char unicode = '\u0041'; // 'A'
            string message = $"Found {dec} items"; //string interpolation
            string path = @"C:\Users\docs\file.txt"; // verbatim string literal


            int defaultInt = default;// 0
            
            bool defaultBool = default;// false
            
            string? defaultString = default;// null
            var count = 10;            // compiler infers int
            var name = "C#";// compiler infers string
            var items = new List<int>(); // compiler infers List<int>





            dynamic value1 = 42;
            Console.WriteLine(value1.GetType()); // System.Int32
            value1 = "Now I'm a string";
            Console.WriteLine(value1.GetType() ); 


            // var is statically typed, dynamic is dynamically typed
            var value2 = 42;
            Console.WriteLine(value2.GetType()); // System.Int32
            //value2 = "Now I'm a string"; this is error
            //Console.WriteLine(value2.GetType() )
                                               
        }

        public static void PrintList(List<int> l)
        {
            foreach (int i in l) Console.WriteLine(i);
        }
        public static void WorkWithIntegers()
        {
            int a = 18;
            int b = 6;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
        }
        public readonly record struct Coords(int X, int Y);


        public static void WorkWithDoubles()
        {
            double a = 19;
            double b = 23;
            double c = 8;

            double result = (a + b) / c;

            Console.WriteLine(result);

            Console.WriteLine($"Double range: {double.MinValue} -> {double.MaxValue}");

            Console.WriteLine(1.0 / 3.0);
        }


        public static void OrderPrecedence()
        {
            int a = 5;
            int b = 4;
            int c = 2;

            Console.WriteLine(a + b * c);

            Console.WriteLine((a + b) * c);
        }


        public static double CalculateCircleArea(double r)
        {
            return Math.PI * r * r;
        }
    }
}

