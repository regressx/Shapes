using System.Drawing;
using Shapes.Model;

namespace Shapes.Presenters
{
    public class MainPresenter
    {
        private IMainView _view;

        public MainPresenter(IMainView view)
        {
            _view = view;
            _view.DrawShape += _view_DrawShape;
        }

        private void _view_DrawShape(object sender, DrawEventArgs e)
        {
            string shapeType = _view.GetShapeType();

            if (shapeType == string.Empty)
            {
                return;
            }


            IShape shapeToDraw = ShapeFactory.Create(shapeType, e.Width, e.Height);

            _view.ShowShape(shapeToDraw.Draw(),e.X - e.Width/2, e.Y - e.Height/2);
        }

        public void Run()
        {
            _view.Show();
        }
    }
}