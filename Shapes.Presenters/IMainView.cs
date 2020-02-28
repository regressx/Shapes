using System;
using System.Drawing;

namespace Shapes.Presenters
{
    public interface IMainView
    {
        event EventHandler<DrawEventArgs> DrawShape;

        void Show();
        void ShowShape(Image bitmap, int x, int y);

        string GetShapeType();

    }
}