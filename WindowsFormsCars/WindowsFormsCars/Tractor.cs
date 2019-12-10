using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsCars
{

    /// <summary>
    /// Класс отрисовки автомобиля
    /// </summary>
    public class tractor : Vehicle
    {
        /// <summary>
        /// Левая координата отрисовки автомобиля
        /// </summary>
        private const int carWidth = 100;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        private const int carHeight = 60;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontSpoiler">Признак наличия переднего спойлера</param>
        /// <param name="sideSpoiler">Признак наличия боковых спойлеров</param>
        /// <param name="backSpoiler">Признак наличия заднего спойлера</param>
        public tractor(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;

        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)

                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Отрисовка автомобиля
        /// </summary>
        /// <param name="g"></param>
        public override void DrawCar(Graphics g)
        {
            // теперь отрисуем основной кузов 
            //границы трактора
            Pen penBody = new Pen(Color.Black);
            Brush brBody = new SolidBrush(Color.Black);
            g.DrawRectangle(penBody, _startPosX + 15, _startPosY, 25, 45);
            g.DrawRectangle(penBody, _startPosX + 15, _startPosY + 25, 65, 20);
            // гусеницы
            g.DrawRectangle(penBody, _startPosX + 35, _startPosY + 45, 25, 10);
            g.FillRectangle(brBody, _startPosX + 35, _startPosY + 45, 25, 10);
            g.DrawRectangle(penBody, _startPosX + 20, _startPosY + 50, 55, 10);
            //круги
            g.DrawEllipse(penBody, _startPosX + 15, _startPosY + 50, 10, 10);
            g.DrawEllipse(penBody, _startPosX + 70, _startPosY + 50, 10, 10);
            g.DrawEllipse(penBody, _startPosX + 60, _startPosY + 50, 10, 10);
            g.DrawEllipse(penBody, _startPosX + 25, _startPosY + 50, 10, 10);
            // задняя фара окантовка
            g.DrawArc(penBody, _startPosX + 12, _startPosY + 30, 10, 10, 180, 360);
            // передняя фара окантовка 
            g.DrawArc(penBody, _startPosX + 75, _startPosY + 35, 8, 8, 270, 180);
            //задние фары
            Brush brStopLights = new SolidBrush(Color.Red);
            g.FillEllipse(brStopLights, _startPosX + 12, _startPosY + 31, 9, 9);
            //кузов
            Brush brMain = new SolidBrush(MainColor);
            g.FillRectangle(brMain, _startPosX + 16, _startPosY + 1, 24, 44);
            g.FillRectangle(brMain, _startPosX + 16, _startPosY + 26, 64, 19);
            // wheels
            Brush brWhl = new SolidBrush(Color.Black);
            g.FillEllipse(brWhl, _startPosX + 16, _startPosY + 51, 8, 8);
            g.FillEllipse(brWhl, _startPosX + 71, _startPosY + 51, 8, 8);
            g.FillEllipse(brWhl, _startPosX + 61, _startPosY + 51, 8, 8);
            g.FillEllipse(brWhl, _startPosX + 26, _startPosY + 51, 8, 8);
            //стекла
            Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brBlue, _startPosX + 20, _startPosY + 5, 20, 15);
            g.DrawLine(penBody, _startPosX + 35, _startPosY + 25, _startPosX + 40, _startPosY + 30);
            g.DrawLine(penBody, _startPosX + 40, _startPosY + 30, _startPosX + 35, _startPosY + 35);
        }
    }
}
