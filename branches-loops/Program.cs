namespace branches_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
            ExploreIf();
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"the counter is {counter}");
                counter++;
            }

            int counter2 = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter2}");
                counter2++;
            } while (counter2 < 10);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
            int s = 0;
            for (int i = 0; i < 20; i++)
            {
                if (i % 3 == 0)
                {
                    s += i;
                }

            }
            Console.WriteLine(s);

            List<int> fibNumbers = new() { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int element in fibNumbers)
            {
                Console.Write($"{element} ");
            }
            List<string> students = ["<name>", "Youssef", "Ali", "Ahmed"];
            students.Add("Mohamed");
            PrintList(students);
            students.Add("Sayed");
            PrintList(students);
            students.Remove("Sayed");
            PrintList(students);
            students.Sort();
            PrintList(students);
            var index = students.IndexOf("Ali");
            if (index != -1)
            {
                Console.WriteLine("found");
            }
            var count = students.Count;
            Console.WriteLine($"there is {count} name");

            var isExist = students.Contains("Ali");
            Console.WriteLine(isExist);
            var firstName = students[0];
            Console.WriteLine(firstName);

            foreach (string name in students)
            {
                Console.WriteLine(name.ToUpper());
            }



            List<int> fibs = [1, 1];

        for(int i = 0; i < 18; i++) {
           
            var prev = fibs[fibs.Count - 1];
            var prev2 = fibs[fibs.Count - 2];
            var curr = prev + prev2;
            fibs.Add(curr);

            prev2 = prev;
            prev = curr;
            
        }
            foreach (int element in fibs)
            {
                Console.Write($"{element} ");
            }
        }
        static void ExploreIf()
        {
            int a = 5;
            int b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else // this block will execute
            {
                Console.WriteLine("The answer is not greater than 10");
            }
            int c = 4;
            if ((a + b + c > 10) && (a > b)) // this block will execute
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not greater than the second");
            }
            if ((a + b + c > 10) || (a > b)) // this block will execute
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not greater than the second");
            }
        }
        static void PrintList(List<string> list)
        {
            foreach (string element in list)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }
}
