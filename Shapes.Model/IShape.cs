using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Model
{
    /// <summary>
    /// Интерфейс 2д фигуры
    /// </summary>
    public interface IShape
    {
    /// <summary>
    /// ширина
    /// </summary>
        int Width { get; }

        /// <summary>
        /// Высота
        /// </summary>
        int Height { get;}

        /// <summary>
        /// Метод рисования
        /// </summary>
        /// <returns>Возвращает изображение фигуры</returns>
        Image Draw();
    }
}
