using System.Drawing;

namespace Shapes.Model
{
    public class Rectangle : IShape
    {
        private readonly int _width;
        private readonly int _height;

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public override string ToString()
        {
            return "Прямоугольник";
        }

        public int Width => _width;
        public int Height => _height;
        public Image Draw()
        {
            Image image = new Bitmap((int)_width, (int)_height);

            using (Graphics gfx = Graphics.FromImage(image))
            {
                gfx.DrawRectangle(new Pen(Color.Black),0,0,image.Width-1, image.Height-1);
            }

            return image;
        }
    }
}