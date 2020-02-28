using System.Drawing;

namespace Shapes.Model
{
    /// <summary>
    /// квадрат
    /// </summary>
    public class Square : IShape
    {
        private readonly int _width;

        public Square(int width)
        {
            _width = width;
        }

        public override string ToString()
        {
            return "Квадрат";
        }

        public int Width => _width;
        public int Height => _width;
        public Image Draw()
        {
            Image image = new Bitmap((int)_width, (int)_width);

            using (Graphics gfx = Graphics.FromImage(image))
            {
                gfx.DrawRectangle(new Pen(Color.Black),0,0,image.Width-1, image.Height-1);
            }

            return image;
        }
    }
}