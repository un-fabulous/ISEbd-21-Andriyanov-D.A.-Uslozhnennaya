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
        private Samosval samos;
        public FormSamosval()
        {
            InitializeComponent();
            comboBoxWheels.Items.AddRange(new string[] { "2 пары колес", "3 пары колес", "4 пары колес" });
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxSamosval.Width, pictureBoxSamosval.Height);
            Graphics gr = Graphics.FromImage(bmp);
            samos.DrawTransport(gr);
            pictureBoxSamosval.Image = bmp;

        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            samos = new Samosval(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray, Color.Red, true, true, (comboBoxWheels.SelectedIndex + 2));
            samos.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxSamosval.Width, pictureBoxSamosval.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    samos.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    samos.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    samos.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                   samos.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
