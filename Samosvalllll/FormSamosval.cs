using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samosvalllll
{
    public partial class FormSamosval : Form
    {
        private ITransport car;

        public FormSamosval()
        {
            InitializeComponent();
            comboBoxWheels.Items.AddRange(new string[] { "2 пары колес", "3 пары колес", "4 пары колес" });                                                                                                                                 // buttonCreatePlane.Enabled = false;
                                                                                                                                                                                                                                            // buttonCreateWaterPlane.Enabled = false;

        }

        public void SetCar(ITransport car)
        {
            this.car = car;
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxSamosval.Width, pictureBoxSamosval.Height);
            Graphics gr = Graphics.FromImage(bmp);
            car.DrawTransport(gr);
            pictureBoxSamosval.Image = bmp;

        }

        private void buttonCreateGruz_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            car = new Gruzovik(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray);
            car.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxSamosval.Width, pictureBoxSamosval.Height);
            Draw();
        }

        private void ButtonCreateSamosval_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();

            int numberOfWheels = (comboBoxWheels.SelectedIndex + 2);

            int ornamentwheel = (checkBoxTriangle.Checked && !checkBoxRectangle.Checked && !checkBoxCircle.Checked) ? 1 :
                                (!checkBoxTriangle.Checked && checkBoxRectangle.Checked && !checkBoxCircle.Checked) ? 2 :
                                (!checkBoxTriangle.Checked && !checkBoxRectangle.Checked && checkBoxCircle.Checked ? 3 : 0);
            
        
            car = new Samosval(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray, Color.Red, true, true, numberOfWheels, ornamentwheel);
            car.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxSamosval.Width, pictureBoxSamosval.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    car.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    car.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    car.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    car.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
