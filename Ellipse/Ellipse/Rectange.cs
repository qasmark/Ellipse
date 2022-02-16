using System;
namespace Ellipse
{
    public class Rectangle
    {
        public Point LeftTopPoint 
        { 
            get; 
            private set; 
        }

        public Point RightBottomPoint 
        { 
            get; 
            private set; 
        }

        public Rectangle(Point leftTopPoint, Point rightBottomPoint)
        {
            if (leftTopPoint.X > rightBottomPoint.X)
            {
                throw new ArgumentException(
                    "leftTopPoint have to be to lefter than rightBottomPoint"
                );
            }

            if (leftTopPoint.Y < rightBottomPoint.Y)
            {
                throw new ArgumentException(
                    "leftTopPoint have to be to higher than rightBottomPoint"
                );
            }

            LeftTopPoint = leftTopPoint;
            RightBottomPoint = rightBottomPoint;
        }

        public int GetSquare()
        {
            int width = RightBottomPoint.X - LeftTopPoint.X;
            int height = LeftTopPoint.Y - RightBottomPoint.Y;
            return width * height;
        }
    }
}
