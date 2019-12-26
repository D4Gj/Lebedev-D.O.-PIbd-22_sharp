using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars
{
    public class ExcavatorTractor : Tractor, IComparable<ExcavatorTractor>, IEquatable<ExcavatorTractor>
    {
        public Color DopColor { private set; get; }
        public bool RearLadle { private set; get; }
        public bool FrontLadle { private set; get; }
        public bool Pipe { private set; get; }

        public ExcavatorTractor(int maxSpeed, float weight, Color mainColor, Color extrColor,
            bool rearLadle, bool frontLadle, bool pipe) : base(maxSpeed, weight, mainColor)
        {
            DopColor = extrColor;
            RearLadle = rearLadle;
            FrontLadle = frontLadle;
            Pipe = pipe;
        }

        public ExcavatorTractor(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                RearLadle = Convert.ToBoolean(strs[4]);
                FrontLadle = Convert.ToBoolean(strs[5]);
                Pipe = Convert.ToBoolean(strs[6]);
            }
        }
        public override void Draw(Graphics g)
        {
            if (FrontLadle)
            {
                Brush brLadle = new SolidBrush(DopColor);
                Brush brLadleblack = new SolidBrush(Color.Black);
                Pen penLadle = new Pen(Color.Black);
                Pen penLadleIN = new Pen(DopColor);
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
            if (RearLadle)
            {
                Brush brLadle = new SolidBrush(DopColor);
                Brush brLadleblack = new SolidBrush(Color.Black);
                Pen penLadle = new Pen(Color.Black);
                Pen penLadleIN = new Pen(DopColor);
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
            base.Draw(g);

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
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + RearLadle + ";" +
                    FrontLadle + ";" + Pipe;
        }

        public int CompareTo(ExcavatorTractor other)
        {
            var res = (this is Tractor).CompareTo(other is Tractor);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (FrontLadle != other.FrontLadle)
            {
                return FrontLadle.CompareTo(other.FrontLadle);
            }
            if (RearLadle != other.RearLadle)
            {
                return RearLadle.CompareTo(other.RearLadle);
            }
            if (Pipe != other.Pipe)
            {
                return Pipe.CompareTo(other.Pipe);
            }
            return 0;
        }

        public bool Equals(ExcavatorTractor other)
        {
            var res = (this as Tractor).Equals(other as Tractor);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (RearLadle != other.RearLadle)
            {
                return false;
            }
            if (FrontLadle != other.FrontLadle)
            {
                return false;
            }
            if (Pipe != other.Pipe)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is ExcavatorTractor tractorObj))
            {
                return false;
            }
            else
            {
                return Equals(tractorObj);
            }
        }
    }
}
