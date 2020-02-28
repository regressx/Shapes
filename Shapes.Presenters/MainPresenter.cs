using System.Drawing;
using Shapes.Model;

namespace Shapes.Presenters
{

    /// <summary>
    /// Представитель главной формы
    /// </summary>
    public class MainPresenter
    {
        /// <summary>
        /// интерфейс формы
        /// </summary>
        private readonly IMainView _view;

        public MainPresenter(IMainView view)
        {
            _view = view;
            _view.DrawShape += _view_DrawShape;
        }

        /// <summary>
        /// обработчик события рисования фигуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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