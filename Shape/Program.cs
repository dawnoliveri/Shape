using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(3); 
            ShowShape(circle); 
            var rectangle = new Rectangle(20, 25); 
            ShowShape(rectangle); 
            var square = new Square(18); 
            ShowShape(square); 
            square.Length = 55; 
            ShowShape(square); 
            ReadKey();
        }
        static void ShowShape(Shape.Shape shape) 
        { 
            WriteLine($"Area = {shape.Area}\t\tPerimeter = {shape.Perimeter}\t\tUom= {shape.UoM}"); }
    
    }
}
