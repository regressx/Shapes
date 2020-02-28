using System;
using System.ComponentModel;

namespace Shapes.Model
{
    public class ShapeFactory
    {
        public static IShape Create(string name, int width, int height)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name", "Не указано имя объекта, который надо создать");
            }


            IShape shape = null;
            switch (name)
            {
                case "Квадрат":

                    shape = new Square(width);
                    break;
                case "Круг":

                    shape = new Circle(width);
                    break;

                case "Эллипс":
                    shape = new Ellips(width, height);

                    break;

                case "Прямоугольник":

                    shape = new Rectangle(width, height);
                    break;
                default:
                    throw new NotImplementedException("Для запрошенного типа фигуры нет метода для рисования");
            }

            return shape;
        }
    }
}