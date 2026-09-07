using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using static ConsoleApp6.Program;

namespace ConsoleApp6
{
    internal class MyReporter
    {
        public string Prefix = "";
        public void Report (int val) => Console.WriteLine($"{Prefix}{val}");
        public void Report2 (int val) => Console.WriteLine($"{Prefix}{val}");
        public static void HardWork(ProgressReportDelegate p)
        {
            for (int i = 0; i < 10; i++)
            {
                p(i * 10);                           // Invoke delegate 
                System.Threading.Thread.Sleep(100);  // Simulate hard work 
            }
        }
        public static void HardWork<T>(T[] vals , MyGenericDelegate<T> del)
        {
            for(int i = 0; i < vals.Length; i++ ) vals[i] = del(vals[i]);
        }
        public static void TransformByInterface(int[] values, IDelegate del)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = del.Transform(values[i]);
        }
    }
}
