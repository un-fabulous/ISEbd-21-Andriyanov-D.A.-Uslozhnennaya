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
    public partial class FormCarConfig : Form
    {
        Vehicle car = null;

        private event Action<Vehicle> eventAddCar;
        public FormCarConfig()
        {
            InitializeComponent();

            panelRed.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelGrey.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;


            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };                                                                                                                                                            //panelRed.MouseDown += new MouseEventHandler(panelColor_MouseDown);

        }

        private void DrawTransport()
        {
            if (car != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxCar.Width, pictureBoxCar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                car.SetPosition(15, 40, pictureBoxCar.Width, pictureBoxCar.Height);
                car.DrawTransport(gr);
                pictureBoxCar.Image = bmp;
            }
        }

        public void AddEvent(Action<Vehicle> e)
        {
            if (eventAddCar == null)
            {
                eventAddCar = new Action<Vehicle>(e);
            }
            else
            {
                eventAddCar += e;
            }
        }




        private void labelGruzovik_MouseDown(object sender, MouseEventArgs e)
        {
            labelGruzovik.DoDragDrop(labelGruzovik.Text, DragDropEffects.Move |
         DragDropEffects.Copy);
        }
        private void labelSamosval_MouseDown(object sender, MouseEventArgs e)
        {
            labelSamosval.DoDragDrop(labelSamosval.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }
        private void panelCar_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void panelCar_DragDrop(object sender, DragEventArgs e)
        {
            Object ob = e.Data.GetData(DataFormats.Text);
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Грузовик":
                    car = new Gruzovik((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Самосвал":
                    car = new Samosval((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black,
                        checkBoxSupport.Checked, checkBoxCarcass.Checked);
                    break;
            }
            DrawTransport();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            Color color = (sender as Panel).BackColor;
            (sender as Panel).DoDragDrop(color, DragDropEffects.Move |
            DragDropEffects.Copy);

        }
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(Color)) != null)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car != null)
            {
                car.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawTransport();
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car != null && car is Samosval)
            {
                (car as Samosval).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                DrawTransport();
            }
        }
        private void buttonCr_Click(object sender, EventArgs e)
        {
            eventAddCar?.Invoke(car);
            Close();
        }

        private void LabelChangeWheels_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(EmblemCircle)) || e.Data.GetDataPresent(typeof(EmblemTriangle))
                || e.Data.GetDataPresent(typeof(EmblemRectangle)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void LabelChangeWheels_DragDrop(object sender, DragEventArgs e)
        {
            if (car is Samosval s)
            {
                if (e.Data.GetData(typeof(EmblemCircle)) != null)
                {
                    s.SetWheel((EmblemCircle)e.Data.GetData(typeof(EmblemCircle)));
                }
                else if (e.Data.GetData(typeof(EmblemTriangle)) != null)
                {
                    s.SetWheel((EmblemTriangle)e.Data.GetData(typeof(EmblemTriangle)));
                }
                else if (e.Data.GetData(typeof(EmblemRectangle)) != null)
                {
                    s.SetWheel((EmblemRectangle)e.Data.GetData(typeof(EmblemRectangle)));
                }
                DrawTransport();
            }
        }
        private void LabelOrnamentWheel_MouseDown(object sender, MouseEventArgs e)
        {
            IDopElement emblem = null;
            if (car is Samosval s)
            {
                switch (((Label)sender).Text)
                {
                    case "Круг":
                        emblem = new EmblemCircle(s.Wheels, s.DopColor, s.MainColor);
                        break;
                    case "Треугольник":
                        emblem = new EmblemTriangle(s.Wheels, s.DopColor, s.MainColor);
                        break;
                    case "Квадрат":
                        emblem = new EmblemRectangle(s.Wheels, s.DopColor, s.MainColor);
                        break;
                }
                if (emblem != null)
                {
                    ((Label)sender).DoDragDrop(emblem, DragDropEffects.Move | DragDropEffects.Copy);
                }
            }
        }
        private void LabelNumberWheels_MouseDown(object sender, MouseEventArgs e)
        {
            if (car is Samosval s)
            {
                IDopElement wheel = null;
                int wheelsNumber = Convert.ToInt32(((Label)sender).Text);
                switch (s.WheelsOrnament)
                {
                    case "EmblemCircle":
                        wheel = new EmblemCircle(wheelsNumber, s.DopColor, s.MainColor);
                        break;
                    case "EmblemTriangle":
                        wheel = new EmblemTriangle(wheelsNumber, s.DopColor, s.MainColor);
                        break;
                    case "EmblemRectangle":
                        wheel = new EmblemRectangle(wheelsNumber, s.DopColor, s.MainColor);
                        break;
                }
                if (wheel != null)
                {
                    ((Label)sender).DoDragDrop(wheel, DragDropEffects.Move | DragDropEffects.Copy);
                    s.SetWheelsNumber(wheelsNumber);
                }
            }
        }
    }
}

