using System.Drawing;

namespace Shapes.Model
{
    /// <summary>
    /// Эллипс
    /// </summary>
    public class Ellips : IShape
    {
        private int _width;
        private int _height;
        public Ellips(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public int Width
        {
            get
            {
                return _width;
            }
        }

        public int Height
        {
            get { return _height; }
        }

        public Image Draw()
        {
            Image image = new Bitmap((int)_width, (int)_height);

            using (Graphics gfx = Graphics.FromImage(image))
            {
                gfx.DrawEllipse(new Pen(Color.Black),0,0,image.Width-1, image.Height-1);
            }

            return image;
        }

        public override string ToString()
        {
            return "Эллипс";
        }
    }
}