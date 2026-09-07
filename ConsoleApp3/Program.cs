namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
namespace Bank
{
    public class ExternalBankAccount
    {
        public ExternalBankAccount() { Console.WriteLine("Bank acc is created"); }
        int Id { get; set; }
        public int AccountNumber { get; set; }
    }
}

namespace Client
{
    public class Person
    {
        public Person() { Console.WriteLine("Client is created"); }
        int Id { get; set; }
        public string Name { get; set; }

        public int createBankAcc { get; set; }
    }
}

namespace Parentnamespace
{

    public class ParentNameSpaceClass
    {
        public ParentNameSpaceClass() { Console.WriteLine("Parent class is created"); }
    }

    namespace NestedNameSpace
    {
        public class NestedNameSpaceClass
        {
            public NestedNameSpaceClass() { Console.WriteLine("Nested class is created"); }
        }
    }
}



