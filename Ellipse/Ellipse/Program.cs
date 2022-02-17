using System;

namespace Ellipse
{
    class Program
    {
        static void Main(string[] args)
        {
            var centerCords = new Point
            {
                X = 100,
                Y = 80
            };
            
            int smallRadius = 5;
            int bigRadius = 10;

            try
            {
                var ellipse = new Ellipse(centerCords, smallRadius, bigRadius);
                Console.WriteLine(
                    $"Big radius is {ellipse.BigRadius}, small radius is {ellipse.SmallRadius}\n" +
                    $"Also the center is {ellipse.CenterCords}\n" +
                    $"Area of Ellipse is {ellipse.GetArea()}\n" +
                    $"and perimeter of Ellipse is {ellipse.GetPerimeter()}"
                    ); 
            }
            catch(ArgumentException s)
            {
                Console.WriteLine(s.Message);
            }
        }
    }
}
