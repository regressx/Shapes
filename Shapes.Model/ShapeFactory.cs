using System;
using System.ComponentModel;

namespace Shapes.Model
{
    /// <summary>
    /// Фабрика фигур. Умеет по имени получить нужный экземпляр фигуры. Решение со Switch case на вид так себе, но для теста пойдет
    /// </summary>
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