using System.Drawing;

namespace Shapes.Model
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : IShape
    {

        private readonly int _width;


        public Circle(int width)
        {
            _width = width;
        }

        public int Width => _width;
        public int Height => _width;
        public Image Draw()
        {
            Image image = new Bitmap((int)_width, (int)_width);

            using (Graphics gfx = Graphics.FromImage(image))
            {
                gfx.DrawEllipse(new Pen(Color.Black),0,0,image.Width, image.Height);
            }

            return image;
        }

        public override string ToString()
        {
            return "Круг";
        }
    }
}