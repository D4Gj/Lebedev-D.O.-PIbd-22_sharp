using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars
{
    public abstract class Vehicle : ITractor
    {
        protected float _startPosX;
        protected float _startPosY;
        protected int _pictureWidth;
        protected int _pictureHeight;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { protected set; get; }
        /// <summary>
        /// Вес автомобиля
        /// </summary>
        public float Weight { protected set; get; }
        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { protected set; get; }
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public abstract void DrawCar(Graphics g);
        public abstract void MoveTransport(Direction direction);
    }
}
