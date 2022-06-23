using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathUtils.Interfaces;
using MathUtils.Shapes;

namespace DependencyInjectionCONSTRUCTOR
{
    internal class Program
    {
        static MathLogicConsumer Shapes;
        static void Main(string[] args)
        {
            Shapes = new MathLogicConsumer(new Square(), new Circle(), new Rectangle());
            Console.WriteLine($"\n Volume: {MathLogicConsumer.GetSquare().Volume()}" +
                              $"\n Area:   {MathLogicConsumer.GetSquare().Area()}" +
                              $"\n Type:   {MathLogicConsumer.GetSquare().GetShapeType()}");

            Console.WriteLine($"\n Volume: {MathLogicConsumer.GetRectangle().Volume()}" +
                              $"\n Area:   {MathLogicConsumer.GetRectangle().Area()}" +
                              $"\n Type:   {MathLogicConsumer.GetRectangle().GetShapeType()}");

            Console.WriteLine($"\n Radius: {MathLogicConsumer.GetCircle().GetRadius()}" +
                              $"\n Area:   {MathLogicConsumer.GetCircle().GetArea()}" +
                              $"\n Circumference: {MathLogicConsumer.GetCircle().GetCircumference()}" +
                              $"\n Type: {MathLogicConsumer.GetCircle().GetShapeType()}");




        }
    }
}

