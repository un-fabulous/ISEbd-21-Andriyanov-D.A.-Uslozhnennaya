using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Samosvalllll
{
    class WheelDop
    {
        private WheelsEnum wheels;

        public int Digit { set => wheels = (WheelsEnum)value; }

        public Color DopColor { private set; get; }

        public void Draw(Graphics g, float _startPosX, float _startPosY)
        {
            switch (wheels)
            {
                case WheelsEnum.Two:
                    DrawTwoWheels(g, _startPosX, _startPosY);
                    break;

                case WheelsEnum.Three:
                    DrawThreeWheels(g, _startPosX, _startPosY);
                    break;

                case WheelsEnum.Four:
                    DrawFourWheels(g, _startPosX, _startPosY);
                    break;
            }
        }
        public WheelDop(int digit, Color dopColor)
        {
            Digit = digit;
            DopColor = dopColor;
        }
        private void DrawTwoWheels(Graphics g, float _startPosX, float _startPosY)
        {
            Brush wheel = new SolidBrush(DopColor);

           
            g.FillEllipse(wheel, _startPosX + 2, _startPosY + 15, 25, 25);
            g.FillEllipse(wheel, _startPosX + 100, _startPosY + 15, 25, 25);


        }

        private void DrawThreeWheels(Graphics g, float _startPosX, float _startPosY)
        {
            Brush wheel = new SolidBrush(DopColor);

            DrawTwoWheels(g, _startPosX, _startPosY);
            g.FillEllipse(wheel, _startPosX + 30, _startPosY + 15, 25, 25);

        }

        private void DrawFourWheels(Graphics g, float _startPosX, float _startPosY)
        {
            Brush wheel = new SolidBrush(DopColor);

            DrawThreeWheels(g, _startPosX, _startPosY);

            g.FillEllipse(wheel, _startPosX + 65, _startPosY + 15, 25, 25);

        }
    }
}