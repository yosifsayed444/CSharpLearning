using System.Collections;

namespace ConsoleApp6
{
    internal class Program
    {
        delegate int OperationDelegate(int x);
        public delegate void ProgressReportDelegate(int percentComplete);
        public delegate T MyGenericDelegate<T>(T arg);
        static void Main(string[] args)
        {
            //Employee e = new Employee();
            //e.AddPayItem("basic salary", 1000);            
            //e.AddPayItem("Housing", 500);            
            //e.AddPayItem("transporation", 200);            
            //e.AddPayItem("Insures", 100);

            ////foreach (var Payitem in e) { 

            ////    Console.WriteLine($"{Payitem.Name} --> {Payitem.Value}");

            ////}

            //for (int i = 0; i < e.Count(); i++) {

            //    Console.WriteLine($"{e.GetPayitem(i).Name} -> {e.GetPayitem(i).Value}");
            //    //Console.WriteLine($"{e[i].Name} -> {e[i].Value}");


            ////}
            //Console.WriteLine();
            //IEnumerator en = new CountDown();
            //while (en.MoveNext())
            //    Console.Write(en.Current);


            //widget w = new widget();
            //w.Foo();  // implict
            //((I1)w).Foo(); // explicit
            //((I2)w).Foo(); // explicit

            //RichTextBox r = new RichTextBox();
            //r.Undo();
            //((IUndoable)r).Undo();
            //((TextBox)r).Undo();


            OperationDelegate op;
            //int[] vals = { 1, 2, 3, 4 };
            //Transform(vals, op2);
            //foreach (var val in vals)
            //    Console.WriteLine(val);

            //TestDel td = new TestDel();
            //op = td.Square;
            //Console.WriteLine(op(5));
            //op = TestDel.Cube;
            //Console.WriteLine(op(5));

            //ProgressReportDelegate prdel;

            //MyReporter r = new MyReporter();
            //r.Prefix = "Progress: ";
            //prdel = r.Report;
            //prdel += r.Report2;
            //prdel(99);
            //Console.WriteLine(prdel.Target);
            //Console.WriteLine(prdel.Method);
            //r.Prefix = "";
            ////prdel(99);

            //ProgressReportDelegate prdel2;
            //prdel2 = WriteProgressToConsole;
            //prdel2 += WriteProgressToFile;
            //MyReporter.HardWork(prdel2);

            //MyGenericDelegate<int> mgd = Square;
            //int[] vals = { 1, 2, 3, 4 };
            //MyReporter.HardWork(vals, mgd);
            //foreach (var val in vals)
            //    Console.WriteLine(val);
            //MyReporter.TransformByInterface(vals, new SquareClass());

            //foreach (var val in vals)
            //    Console.WriteLine(val);


            Broadcaster b = new Broadcaster("ABC");
            b.Price = 27.1m;
            b.PriceChanged += B_PriceChanged;
            b.Price = 31.59M;


        }

        private static void B_PriceChanged(object sender, PriceChangedEventArgs e)
        {
            if ((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
                Console.WriteLine("Alert, 10% stock price increase!");
        }

        static void Transform(int[] vals, OperationDelegate op)
        {
            for (int i = 0; i < vals.Length; i++)
                vals[i] = op(vals[i]);
        }

        class SquareClass : IDelegate
        {
            public int Transform(int x) => x * x;
        }
        static int Square(int x) => x * x;
        static int Cube(int x) => x * x * x;
        static int Quad(int x) => x * x * x * x;

        static void WriteProgressToConsole(int percentComplete)
          => Console.WriteLine(percentComplete);

        static void WriteProgressToFile(int percentComplete)
          => System.IO.File.WriteAllText("progress.txt",
                                           percentComplete.ToString());
    }
}
