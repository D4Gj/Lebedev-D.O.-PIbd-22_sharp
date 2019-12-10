using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCars
{
    public partial class FormCar : Form
    {
        private tractor car;
        public FormCar()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            car = new tractor(rnd.Next(30, 80), rnd.Next(1000, 1500), Color.Orange,
                Color.Gray, true, true, true);
            car.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCars.Width,
                pictureBoxCars.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCars.Width, pictureBoxCars.Height);
            Graphics gr = Graphics.FromImage(bmp);
            car.DrawCar(gr);
            pictureBoxCars.Image = bmp;
        }

        private void Button_up_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "button_up":
                    car.MoveTransport(Direction.Up);
                    break;
                case "button_down":
                    car.MoveTransport(Direction.Down);
                    break;
                case "button_left":
                    car.MoveTransport(Direction.Left);
                    break;
                case "button_right":
                    car.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
