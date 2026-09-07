namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //// calling by val , ref
            //int x = 0;
            //increase(x);
            //Console.WriteLine(x);
            //string firstEmployee, secondEmployee;
            //firstEmployee = "Youssef";
            //secondEmployee = "Sayed";
            //Console.WriteLine($"inside Main before calling method {firstEmployee} , {secondEmployee}");
            //changeEmployeeNameByVal(firstEmployee, secondEmployee);
            //Console.WriteLine($"inside Main after calling method (pass by val){firstEmployee} , {secondEmployee}");
            //changeEmployeeNameByRef(ref firstEmployee, ref secondEmployee);
            //Console.WriteLine($"inside Main after calling method (pass by ref){firstEmployee} , {secondEmployee}");


            //int total = 100;
            //Console.WriteLine($"inside Main before calling method {total}");
            //calculate(ref total);
            //Console.WriteLine($"inside Main after calling method {total}");

            //int a = 10, b = 20, c = 30;
            //AddNumbers(a, b ,c);

            //// Method Overloading
            //string guestName = "Youssef";
            //if(guestName == "")
            //{
            //    WelcomeGuest();
            //}f
            //else
            //{
            //    WelcomeGuest(guestName);
            //}


            //Employee[] AllEmployees = new Employee[5];
            //for (int i = 0; i < AllEmployees.Length; i++) { 
            //    AllEmployees[i] = new Employee(i);
            //}
            //foreach (Employee e in AllEmployees) {
            //    Console.WriteLine("Enter first name ");
            //    e.fname = Console.ReadLine();
            //    Console.WriteLine("Enter last name ");
            //    e.lname = Console.ReadLine();
            //    Console.WriteLine("Enter wage");
            //    e.wage = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Enter Logged Hours ");
            //    e.LoggedHours = Convert.ToDouble(Console.ReadLine());
            //    e.PrintData(e);
            //}

            //Car c = new Car();
            //Marker marker = new Marker();
            //Instructor ins = new Instructor();
            //ins.writeOnBoard(marker);

            //Enemy e1 = new Enemy();
            //Enemy e2 = new Enemy();
            //Enemy e3 = new Enemy();
            //Enemy e4 = new Enemy();
            //Console.WriteLine(e1.health);

            //Enemy e5 = new Enemy("Zombie", 300);
            //Console.WriteLine(e5.health);

            //Enemy e6 = new Enemy(e5);

            //Enemy.StaticMethod();
            //e6.NonStaticMethod();

            //int persentage = -10;
            //if (ExtensionClass.IsNumberBetween(persentage, 0, 100))
            //{
            //    Console.WriteLine("valid persentage");
            //}
            //else
            //{
            //    Console.WriteLine("invalid persentage");
            //}

            //if (persentage.IsNumberBetweenUsingExtensionMethod(0,100))
            //{
            //    Console.WriteLine("valid persentage");
            //}
            //else
            //{
            //    Console.WriteLine("invalid persentage");
            //}
            //Console.WriteLine("Enter value: ");
            //var inp = Console.ReadLine();
            //Console.WriteLine(inp.RemoveWhiteSpaces().Reverse());



            //Animal a = new Animal();
            //a.AnimalName = "Generic Animal";
            //a.BirthDate = DateOnly.FromDateTime(DateTime.Now);
            //a.TrainAnimalInternal(); // this will call the base class method
            //a.publicVariable = "This is a public variable"; // this will access the public variable from the base class
            //a.TrainAnimalInternal(); // this will call the base class method
            //a.internalVariable = "This is an internal variable"; // this will access the internal variable from the base class

            //Dog d = new Dog();
            //d.AnimalName = "Buddy";
            //d.BirthDate = DateOnly.FromDateTime(DateTime.Now);
            //d.bark(); // this will call the derived class method
            //d.internalVariable = "This is an internal variable"; // this will access the internal variable from the base class
            //d.publicVariable = "This is a public variable"; // this will access the public variable from the base class



            //Bird b = new Bird();
            //b.fly(); // this will call the derived class method

            //OuterClassAnimal outer = new OuterClassAnimal();
            //OuterClassAnimal.InnerClassDog innerDog = new OuterClassAnimal.InnerClassDog();
            //innerDog.DogBreed = "Labrador";
            //OuterClassAnimal.InnerClassBird innerBird = new OuterClassAnimal.InnerClassBird();

            //CurrentAccount curr = new CurrentAccount();
            //curr.BankFees();
            //SavingsAccount savings = new SavingsAccount();
            //savings.BankFees();
            //EmployeeStruct employeeStruct = new EmployeeStruct();
            //PersonFromEnum personFromEnum = new PersonFromEnum("Youssef", 50000, Country.Egypt, Language.Arabic, Status.Pending, Months.Jan, 18, 10);
            //personFromEnum.DisplayInfo();


            //int x = 0;
            //int div = 0;
            //try
            //{
            //    div = 5 / x;

            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("An error occurred while performing the division.");

            //}
            //finally { Console.WriteLine(div); }

            //string[] colors = { "Red", "Green", "Blue" };
            //int idx = -1;

            //try
            //{
            //    Console.WriteLine(colors[idx]);

            //}
            //catch (IndexOutOfRangeException ex) when (idx < 0)
            //{
            //    Console.WriteLine("index cannot be negative" + ex.Message);
            //}
            //catch (IndexOutOfRangeException ex) when (idx >= colors.Length)
            //{
            //    Console.WriteLine("index cannot be greater than the length of the array" + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("The program has completed execution.");
            //}

            //int[] nums = { 1, 2, 3 };
            //Console.WriteLine(GetVal(nums, 1));

            //static int GetVal(int[]arr , int idx)
            //{
            //    try
            //    {
            //        return arr[idx];
            //    }
            //    catch(IndexOutOfRangeException ex)
            //    {
            //        throw new ArgumentOutOfRangeException("Index is out of range", ex);
            //    }
            
            //}
            
            //static void AddNumbers(int x, int y)
            //{
            //    Console.WriteLine($"Sum of {x} and {y} is {x + y}");
            //}
            //static void AddNumbers(int x, int y,int z)
            //{
            //    Console.WriteLine($"Sum of {x} and {y} and {z} is {x + y + z}");
            //}
            //static int increase(int x)
            //{
            //    return x++;
            //}
            //static void changeEmployeeNameByVal(string first, string sec)
            //{
            //    first = "Ahmed";
            //    sec = "Ali";
            //    Console.WriteLine($"inside Method {first} , {sec}");
            //}
            //static void changeEmployeeNameByRef(ref string first, ref string sec)
            //{
            //    first = "Ahmed";
            //    sec = "Ali";
            //    Console.WriteLine($"inside Method {first} , {sec}");
            //}

            //static int calculate(ref int total)
            //{
            //    total += 100;
            //    return total;
            //}

            //static void WelcomeGuest()
            //{
            //    Console.WriteLine("How can I help you");
            //}

            //static void WelcomeGuest(string name)
            //{
            //    Console.WriteLine($"Good {name} , how can I help you");
            //}


        }
    }
}