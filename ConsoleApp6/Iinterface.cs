using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    internal interface IEatable
    {
        void Eat(); //implicitly public and abstract
        int MyProperty { get; set; }
        event Action<int> EatAction;

        int this[int index] { get; }
    }
    interface I1 { void Foo(); }
    interface I2 { int Foo(); }
    interface IUndoable { void Undo(); }

}
