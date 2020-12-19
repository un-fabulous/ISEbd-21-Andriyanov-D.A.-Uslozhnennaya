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
    public partial class FormParking : Form
    {
        private readonly Parking<Gruzovik, EmblemCircle> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<Gruzovik, EmblemCircle>(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        private void buttonSetCar_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new Gruzovik(100, 1000, dialog.Color);

                if (parking + car)
                {

                    Draw();
                }
                else
                {
                    MessageBox.Show("Гараж переполнен");
                }
            }
        }

        private void buttonSetSamosval_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var car = new Samosval(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    if (parking + car)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Гараж переполнен");
                    }
                }
            }
        }
        private void buttonTakeCar_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var car = parking - Convert.ToInt32(maskedTextBox.Text);
                if (car != null)
                {
                    FormSamosval form = new FormSamosval();
                    form.SetCar(car);
                    form.ShowDialog();
                }
                Draw();
            }
        }


        private void ButtonCompare_Click(object sender, EventArgs e)
        {
            int i;
            if (maskedTextBoxCompare.Text != "")
            {
                i = Convert.ToInt32(maskedTextBoxCompare.Text);
            }
            else { return; }
            if (checkBoxMore.Checked && !checkBoxLess.Checked)
            {
                if (parking > i)
                {
                    MessageBox.Show("Гараж заполнен более, чем на " + i + " мест(а)");
                }
                else
                {
                    MessageBox.Show("Гараж заполнен не более, чем на " + i + " мест(а)");
                }
            }

            else if (checkBoxLess.Checked && !checkBoxMore.Checked)
            {
                if (parking < i)
                {
                    MessageBox.Show("Гараж заполнен менее, чем на " + i + " мест(а)");
                }
                else
                {
                    MessageBox.Show("Гараж заполнен не менее, чем на " + i + " мест(а)");
                }
            }
        }
    }
}

