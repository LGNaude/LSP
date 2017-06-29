using System;
using System.Collections.Generic;

namespace LSP
{
    /// <summary>
    /// Liskov Substitution Principle
    /// The object of a derived class should be able to replace the object of a base class without introducing errors or modifying the behavior of the base class.
    /// A list of shape is declared, but objects of the derived classes is passed through.. The Draw method of the base class is called - without introducing errors or modifying the behavior of the base class.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Shape - but add the derived classes to it
            List<Shape> shapeList = new List<LSP.Shape>();
            shapeList.Add(new Rectangle());
            shapeList.Add(new Square());
            shapeList.Add(new Circle());

            // Iterate through Shape list, and call the abstract method for each - the derived classes' methods will be called.
            foreach (Shape shape in shapeList)
            {
                shape.Draw();
            }

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Declares an abstract shape class.
    /// </summary>
    abstract class Shape
    {
        public abstract void Draw();
    }

    /// <summary>
    /// Inherits from Shape class and override Draw method
    /// </summary>
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle");
        }
    }

    /// <summary>
    /// Inherits from Shape class and override Draw method
    /// </summary>
    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Square");
        }
    }

    /// <summary>
    /// Inherits from Shape class and override Draw method
    /// </summary>
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Circle");
        }
    }
}
