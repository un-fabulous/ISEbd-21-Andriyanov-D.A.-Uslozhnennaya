using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Samosvalllll
{
    class EmblemCircle : IDopElement
    {
        private ElementsEnum wheelsOrnament;

        public int SetNumberOfElements { set => wheelsOrnament = (ElementsEnum)value; }
        public Color DopColor { private set; get; }

        public Color MainColor { private set; get; }

        public EmblemCircle(int digit, Color dopColor, Color mainColor)
        {
            SetNumberOfElements = digit;
            DopColor = dopColor;
            MainColor = mainColor;
        }

        public void DrawElement(Graphics g, Color dopColor, Color mainColor, float _startPosX, float _startPosY)
        {
            switch (wheelsOrnament)
            {
                case ElementsEnum.Two:
                    DrawTwoWheels(g, _startPosX, _startPosY);
                    break;

                case ElementsEnum.Three:
                    DrawThreeWheels(g, _startPosX, _startPosY);
                    break;

                case ElementsEnum.Four:
                    DrawFourWheels(g, _startPosX, _startPosY);
                    break;
            }

        }

        private void DrawTwoWheels(Graphics g, float _startPosX, float _startPosY)
        {
            Brush wheel = new SolidBrush(Color.Black);


            g.FillEllipse(wheel, _startPosX + 2, _startPosY + 15, 25, 25);
            g.FillEllipse(wheel, _startPosX + 100, _startPosY + 15, 25, 25);

            Brush emblem = new SolidBrush(DopColor);
            g.FillEllipse(emblem, _startPosX + 104, _startPosY + 19, 17, 17);
            g.FillEllipse(emblem, _startPosX + 6, _startPosY + 19, 17, 17);
        }

        private void DrawThreeWheels(Graphics g, float _startPosX, float _startPosY)
        {
            Brush wheel = new SolidBrush(Color.Black);

            DrawTwoWheels(g, _startPosX, _startPosY);
            g.FillEllipse(wheel, _startPosX + 30, _startPosY + 15, 25, 25);

            Brush emblem = new SolidBrush(DopColor);
            g.FillEllipse(emblem, _startPosX + 34, _startPosY + 19, 17, 17);
        }


        private void DrawFourWheels(Graphics g, float _startPosX, float _startPosY)
        {
            Brush wheel = new SolidBrush(Color.Black);

            DrawThreeWheels(g, _startPosX, _startPosY);
            g.FillEllipse(wheel, _startPosX + 65, _startPosY + 15, 25, 25);

            Brush emblem = new SolidBrush(DopColor);
            g.FillEllipse(emblem, _startPosX + 69, _startPosY + 19, 17, 17);

        }

    }
}
