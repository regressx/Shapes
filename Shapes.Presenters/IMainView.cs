using System;
using System.Drawing;

namespace Shapes.Presenters
{
    /// <summary>
    /// интерфейс представления
    /// </summary>
    public interface IMainView
    {
        /// <summary>
        /// событие рисования фигуры
        /// </summary>
        event EventHandler<DrawEventArgs> DrawShape;

        /// <summary>
        /// показываем форму
        /// </summary>
        void Show();
        /// <summary>
        /// показываем фигуру
        /// </summary>
        /// <param name="bitmap">рисунок фигуры</param>
        /// <param name="x">координата х, где ее показать</param>
        /// <param name="y">координата y, где показать изображение</param>
        void ShowShape(Image bitmap, int x, int y);
        /// <summary>
        /// Метод позволяет извлечь имя фигуры, которую надо показать
        /// </summary>
        /// <returns>Возвращает имя фигуры</returns>
        string GetShapeType();

    }
}