//using ConsoleApp2;
//using System;
//using System.Collections.Generic;
//using System.Text;

//Shape[] Shapes = new Shape[3];
//Shapes[0] = new Shape();
//Shapes[1] = new Circle();
//Shapes[2] = new Triangle();

//foreach (Shape shape in Shapes)
//{
//    shape.Draw(); // calls the appropriate Draw method based on the actual object type
//}

//Line l = new Line();
//l.Draw(); // calls the Draw method of Line class
//l.SayHello(); // calls the SayHello method of AbstractShape class


////StaticShape staticShape = new StaticShape(); // static class cannot be instantiated
//StaticShape.Draw(); // calls the static Draw method of StaticShape class
////AbstractShape ab = new AbstractShape();   // abstract class cannot be instantiated

namespace ConsoleApp2   
{
    // implementation of polymorphism & Abstract class & Sealed class & Static class
    internal class Shape
    {
        public virtual void Draw() // virtual method can be overridden in derived classes
        {
            Console.WriteLine("Drawing a shape");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello from Shape");
        }
    }

    sealed class SealedShape // sealed class cannot be inherited
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a sealed shape");
        }
    }
    static class StaticShape // static class cannot be instantiated and can only contain static members
    {
        public static void Draw()
        {
            Console.WriteLine("Drawing a static shape");
        }

         /*
         only static members are allowed in a static class.
         cannot be instantiated, inherited, or contain instance members.
         is sealed by default, meaning it cannot be inherited.
         does not have a constructor, and cannot be instantiated.
         */


        //public void NonStaticMethod() // this will cause a compile-time error because static class cannot contain non-static members
        //{
        //    Console.WriteLine("This is a non-static method in a static class");
        //}
    }
    //class InheritedShape : SealedShape // this will cause a compile-time error because SealedShape is sealed
    //{
    //    public void Draw()
    //    {
    //        Console.WriteLine("Drawing an inherited shape");
    //    }
    //}
    abstract class AbstractShape // abstravct class cannot be instantiated and can contain abstract methods that must be implemented in derived classes
    {
        public abstract void Draw(); // abstract method must be implemented in derived classes
        public void SayHello()
        {
            Console.WriteLine("Hello from AbstractShape");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle");
        }
    }

    class Line : AbstractShape
    {
        public override void Draw() // override method must be implemented in derived classes
        {
            Console.WriteLine("Drawing a line");
        }
    }
}
