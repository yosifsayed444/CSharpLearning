using Bank;
using Client;
using cn = ConsoleApp1;
using System.Globalization;
using Parentnamespace;
using Nested = Parentnamespace.NestedNameSpace;
using Africa;
using EUROPE;
using Africa.Egypt;
using Cairo = Africa.Egypt.Cairo;
using Africa.Nigeria;
using EUROPE.Germany;
using EUROPE.France;

namespace invoking_namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ExternalBankAccount acc = new ExternalBankAccount();
            Person clientAcc = new Person();
            innerBankAccount innerAcc = new innerBankAccount();
            ParentNameSpaceClass parent = new ParentNameSpaceClass();
            Nested.NestedNameSpaceClass nested = new Nested.NestedNameSpaceClass();
            AfricaClass AFR = new AfricaClass();
            EgyptClass  EGY = new EgyptClass();
            Cairo.CairoClass  cai  = new Cairo.CairoClass();
            EuropeClass EUR = new EuropeClass();
            NigeriaClass NIG = new NigeriaClass();
            GermanyClass GER = new GermanyClass();
            FranceClass FRA = new FranceClass();

            cn.Program program = new cn.Program();
            cn.Program.WorkWithIntegers();
            cn.Program.OrderPrecedence();
            cn.Program.WorkWithDoubles();
            cn.Program.CalculateCircleArea(5.0);


            Greeter gr = new Greeter();
            Console.WriteLine(gr.Greet("John"));


        }
    }
    class Greeter
    {
        public string Greet(string name)
        {
            var culture = CultureInfo.CurrentCulture;
            return $"Hello, {name}! Culture: {culture.Name}";
        }
    }
}

