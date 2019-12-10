using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsCars
{
    public class tractor
    {
        /// <summary>
        /// Левая координата отрисовки автомобиля
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки автомобиля
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        private const int carWidth = 100;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        private const int carHeight = 60;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес автомобиля
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color ExtrColor { private set; get; }
        /// <summary>
        /// Признак наличия переднего спойлера
        /// </summary>
        public bool Pipe { private set; get; }
        /// <summary>
        /// Признак наличия боковых спойлеров
        /// </summary>
        public bool frontLadle { private set; get; }
        /// <summary>
        /// Признак наличия заднего спойлера
        /// </summary>
        public bool rearLadle { private set; get; }
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
        public tractor(int maxSpeed, float weight, Color mainColor, Color extrColor,
       bool pipe, bool frontladle, bool rearladle)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            ExtrColor = extrColor;
            Pipe = pipe;
            frontLadle = frontladle;
            rearLadle = rearladle;

        }
        /// <summary>
        /// Установка позиции автомобиля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
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
        public void DrawCar(Graphics g)
        {
            if (frontLadle)
            {
                Brush brLadle = new SolidBrush(ExtrColor);
                Brush brLadleblack = new SolidBrush(Color.Black);
                Pen penLadle = new Pen(Color.Black);
                Pen penLadleIN = new Pen(ExtrColor);
                for (int i = 1; i < 14; i++)
                {
                    g.DrawLine(penLadleIN, _startPosX + 60 + i, _startPosY + 30, _startPosX + 85 + i / 2, _startPosY + 5);
                }
                for (int i = 1; i < 6; ++i)
                {
                    g.DrawLine(penLadleIN, _startPosX + 85 + i, _startPosY + 5, _startPosX + 85 + i, _startPosY + 40);
                }
                for (int z = 1; z < 20; z++)
                {
                    g.DrawLine(penLadleIN, _startPosX + 84, _startPosY + 40 + z / 2, _startPosX + 95, _startPosY + 35 + z);
                }
                //okraska kovsha
                g.FillEllipse(brLadle, _startPosX + 83, _startPosY + 2, 10, 10);
                // окантовка ковшика
                g.DrawLine(penLadle, _startPosX + 60, _startPosY + 30, _startPosX + 85, _startPosY + 5);
                g.DrawLine(penLadle, _startPosX + 70, _startPosY + 30, _startPosX + 90, _startPosY + 10);
                g.DrawEllipse(penLadle, _startPosX + 83, _startPosY + 2, 10, 10);
                g.DrawLine(penLadle, _startPosX + 85, _startPosY + 5, _startPosX + 85, _startPosY + 40);
                g.DrawLine(penLadle, _startPosX + 91, _startPosY + 5, _startPosX + 91, _startPosY + 40);
                //sam kovsh
                g.DrawLine(penLadle, _startPosX + 84, _startPosY + 40, _startPosX + 95, _startPosY + 35);
                g.DrawLine(penLadle, _startPosX + 95, _startPosY + 35, _startPosX + 95, _startPosY + 55);
                g.DrawLine(penLadle, _startPosX + 95, _startPosY + 55, _startPosX + 84, _startPosY + 50);
                g.DrawLine(penLadle, _startPosX + 84, _startPosY + 50, _startPosX + 84, _startPosY + 40);
            }
            if (rearLadle)
            {
                Brush brLadle = new SolidBrush(ExtrColor);
                Brush brLadleblack = new SolidBrush(Color.Black);
                Pen penLadle = new Pen(Color.Black);
                Pen penLadleIN = new Pen(ExtrColor);
                for (int i = 0; i < 10; ++i)
                {
                    g.DrawLine(penLadleIN, _startPosX + 16, _startPosY + 33 + i, _startPosX + 5 + i / 2, _startPosY + 5 - i / 2);
                }
                for (int j = 0; j < 3; ++j)
                {
                    g.DrawLine(penLadleIN, _startPosX + 4 + j, _startPosY + 1, _startPosX + 4 + j, _startPosY + 35);
                }
                for (int z = 0; z < 8; z++)
                {
                    g.DrawLine(penLadleIN, _startPosX + 7, _startPosY + 35 + z / 3, _startPosX, _startPosY + 31 + z);
                }
                //kovsh
                g.DrawLine(penLadle, _startPosX + 7, _startPosY + 35, _startPosX, _startPosY + 30);
                g.DrawLine(penLadle, _startPosX, _startPosY + 30, _startPosX, _startPosY + 40);
                g.DrawLine(penLadle, _startPosX, _startPosY + 40, _startPosX + 7, _startPosY + 37);
                g.DrawLine(penLadle, _startPosX + 7, _startPosY + 37, _startPosX + 7, _startPosY + 35);
                //палки
                g.DrawLine(penLadle, _startPosX + 16, _startPosY + 40, _startPosX + 5, _startPosY + 5);
                g.DrawLine(penLadle, _startPosX + 16, _startPosY + 30, _startPosX + 8, _startPosY + 1);
                g.DrawEllipse(penLadle, _startPosX + 3, _startPosY + 1, 6, 6);
                g.FillEllipse(brLadleblack, _startPosX + 3, _startPosY + 1, 6, 6);
                g.FillEllipse(brLadle, _startPosX + 5, _startPosY + 3, 3, 3);

                g.DrawLine(penLadle, _startPosX + 4, _startPosY + 1, _startPosX + 4, _startPosY + 35);
                g.DrawLine(penLadle, _startPosX + 7, _startPosY + 1, _startPosX + 7, _startPosY + 35);
            }
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

            if (Pipe)
            {
                Pen penPipe = new Pen(Color.Black);
                Brush brPipe = new SolidBrush(Color.Gray);
                g.DrawArc(penPipe, _startPosX + 55, _startPosY + 27, 5, 5, 0, 130);
                g.DrawLine(penPipe, _startPosX + 60, _startPosY + 29, _startPosX + 60, _startPosY + 15);
                g.DrawArc(penPipe, _startPosX + 52, _startPosY + 22, 5, 5, 0, 70);
                g.DrawLine(penPipe, _startPosX + 57, _startPosY + 25, _startPosX + 57, _startPosY + 15);
                g.FillEllipse(brPipe, _startPosX + 56, _startPosY + 25, 4, 7);
                g.FillRectangle(brPipe, _startPosX + 58, _startPosY + 15, 2, 10);
                g.DrawLine(penPipe, _startPosX + 57, _startPosY + 15, _startPosX + 59, _startPosY + 12);
                g.DrawLine(penPipe, _startPosX + 60, _startPosY + 15, _startPosX + 61, _startPosY + 12);
            }
        }
    }
}



