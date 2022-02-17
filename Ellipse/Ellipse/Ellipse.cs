using System;

namespace Ellipse
{
    class Ellipse
    {
        public int SmallRadius
        {
            get;
            private set;
        }

        public int BigRadius
        {
            get;
            private set;
        }

        public Point CenterCords
        {
            get;
            private set;
        }
        
        public ClassEllipse(Point centerCoords, int smallRaduis, int bigRaduis)
        {
            if (smallRaduis < 0)
            {
                throw new ArgumentException(
                   "Small Raduis of Ellipse must be more than zero, but you entered less than zero. Be careful!"
               );
            }

            if (bigRaduis < 0)
            {
                throw new ArgumentException(
                   "Big Raduis of Ellipse must be more than zero, but you entered less than zero. Be careful!"
               );
            }

            SmallRadius = smallRaduis;
            BigRadius = bigRaduis;
            CenterCords = centerCoords;
        
        }

        public ClassEllipse(Point leftTopPoint, Point rightBottomPoint)
        {
            if (leftTopPoint.X > rightBottomPoint.X)
            {
                throw new ArgumentException(
                    "leftTopPoint must be more or equal then rightBottomPoint. Be careful!"
                );
            }

            if (leftTopPoint.Y < rightBottomPoint.Y)
            {
                throw new ArgumentException(
                    "leftTopPoint must be higher or equal then rightBottomPoint. Be careful!"
                );
            }

            SmallRadius = (leftTopPoint.Y - rightBottomPoint.Y) / 2;
            BigRadius = (leftTopPoint.X - rightBottomPoint.X) / 2;

            CenterCords.X = BigRadius + leftTopPoint.X;
            CenterCords.Y = SmallRadius + rightBottomPoint.Y;
        }

        public float GetArea()
        {
            float area = MathF.PI * BigRadius * SmallRadius;
            return area;
        }
        public float GetPerimeter()
        {
            float perimeter = MathF.PI * 2 * MathF.Sqrt((BigRadius * BigRadius + SmallRadius * SmallRadius) / 2);
            return perimeter;
        }
    }
}
