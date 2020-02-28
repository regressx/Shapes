using System;
using System.Drawing;

namespace Shapes.Model
{
    public class Triangle : IShape
    {
        private readonly int _x1;
        private readonly int _y1;
        private readonly int _x2;
        private readonly int _y2;
        private readonly int _x3;
        private readonly int _y3;

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            _x1 = x1;
            _y1 = y1;
            _x2 = x2;
            _y2 = y2;
            _x3 = x3;
            _y3 = y3;
        }

        public override string ToString()
        {
            return "Треугольник";
        }

        public int Width { get; }
        public int Height { get; }
        public Image Draw()
        {
            // ищем максимальную сторону
            double AB = Math.Sqrt(Math.Pow(_x2 - _x1, 2) + Math.Pow(_y2 - _y1, 2));
            double BC = Math.Sqrt(Math.Pow(_x3 - _x2, 2) + Math.Pow(_y3 - _y2, 2));
            double AC = Math.Sqrt(Math.Pow(_x3 - _x1, 2) + Math.Pow(_y3 - _y1, 2));

            double max = Math.Max(AB, Math.Max(BC, AC));

            // создаем Image с максимальными сторонами
            Image image = new Bitmap((int)max,(int)max);

            using (Graphics gfx = Graphics.FromImage(image))
            {
                gfx.DrawLine(new Pen(Color.Black),_x1,_y1, _x2,_y2);
                gfx.DrawLine(new Pen(Color.Black),_x2,_y2, _x3,_y3);
                gfx.DrawLine(new Pen(Color.Black),_x3,_y3, _x1,_y1);
            }

            return image;
        }
    }
}