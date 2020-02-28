using System;

namespace Shapes.Presenters
{
    public class DrawEventArgs : EventArgs
    {
        private int _x;
        private int _y;
        private readonly int _width;
        private readonly int _height;

        public DrawEventArgs(int x, int y, int width, int height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }

        public int X
        {
            get => _x;
            set => _x = value;
        }

        public int Y
        {
            get => _y;
            set => _y = value;
        }

        public int Width
        {
            get => _width;
        }

        public int Height
        {
            get => _height;
        }
    }
}