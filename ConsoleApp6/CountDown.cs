using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    internal class CountDown : IEnumerator
    {
        private int count = 11;
        public object Current => count;

        public bool MoveNext() => --count > 0;


        public void Reset()
        {
            count = 11;
        }
    }


    internal class widget : I1, I2
    {
        public void Foo()
        {
            Console.WriteLine("I1.Foo");
        }
        int I2.Foo()
        {
            return 42;
        }
    }
    public class TextBox : IUndoable
    {
        public virtual void Undo() => Console.WriteLine("TextBox.Undo");
    }
    public class RichTextBox : TextBox
    {
        public override void Undo() => Console.WriteLine("RichTextBox.Undo");
    }
}
