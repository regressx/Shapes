using System;

namespace Shapes.Presenters
{
    public class DrawEventArgs : EventArgs
    {
        /// <summary>
        /// Координата х центра
        /// </summary>
        private int _x;

        /// <summary>
        /// Координата y центра
        /// </summary>
        private int _y;
        /// <summary>
        /// ширина
        /// </summary>
        private readonly int _width;
        /// <summary>
        /// высота
        /// </summary>
        private readonly int _height;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">координата х центра</param>
        /// <param name="y">координата y центра</param>
        /// <param name="width">ширина</param>
        /// <param name="height">высота</param>
        public DrawEventArgs(int x, int y, int width, int height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }
        /// <summary>
        /// Координата х центра
        /// </summary>
        public int X
        {
            get => _x;
            set => _x = value;
        }
        /// <summary>
        /// Координата y центра
        /// </summary>
        public int Y
        {
            get => _y;
            set => _y = value;
        }
        /// <summary>
        /// ширина
        /// </summary>
        public int Width
        {
            get => _width;
        }
        /// <summary>
        /// высота
        /// </summary>
        public int Height
        {
            get => _height;
        }
    }
}