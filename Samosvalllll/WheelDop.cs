using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Samosvalllll
{
    class WheelDop : IDopElement
    {
        private ElementsEnum wheels;
       
        public int SetNumberOfElements

        {
            set
            {
                switch (value)
                {
                    case 2:
                        wheels = ElementsEnum.Two;
                        break;
                    case 3:
                        wheels = ElementsEnum.Three;
                        break;
                    case 4:
                        wheels = ElementsEnum.Four;
                        break;
                }
            }
        }


        public void DrawElement(Graphics g, Color mainColor, Color dopColor, float _startPosX, float _startPosY)
        {
            if (wheels == ElementsEnum.Two)
            {
                DrawTwoWheels(g, mainColor, _startPosX, _startPosY);
            }
            else if (wheels == ElementsEnum.Three)
            {
                DrawThreeWheels(g, mainColor, _startPosX, _startPosY);
            }
            else if (wheels == ElementsEnum.Four)
            {
                DrawFourWheels(g, mainColor, _startPosX, _startPosY);
            }
        }

        private void DrawTwoWheels(Graphics g, Color mainColor, float _startPosX, float _startPosY)
        {
            Brush wheel = new SolidBrush(mainColor);


            g.FillEllipse(wheel, _startPosX + 2, _startPosY + 15, 25, 25);
            g.FillEllipse(wheel, _startPosX + 100, _startPosY + 15, 25, 25);
        }

        private void DrawThreeWheels(Graphics g, Color mainColor, float _startPosX, float _startPosY)
        {
            Brush wheel = new SolidBrush(mainColor);

            DrawTwoWheels(g, mainColor, _startPosX, _startPosY);
            g.FillEllipse(wheel, _startPosX + 30, _startPosY + 15, 25, 25);
        }

        private void DrawFourWheels(Graphics g, Color mainColor, float _startPosX, float _startPosY)
        {
            Brush wheel = new SolidBrush(mainColor);

            DrawThreeWheels(g, mainColor, _startPosX, _startPosY);

            g.FillEllipse(wheel, _startPosX + 65, _startPosY + 15, 25, 25);
        }
    }
}