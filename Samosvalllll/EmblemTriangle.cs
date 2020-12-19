using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Samosvalllll
{
    class EmblemTriangle : IDopElement
    {
        private ElementsEnum wheelsOrnament;

        public int SetNumberOfElements { set => wheelsOrnament = (ElementsEnum)value; }

        public Color DopColor { private set; get; }

        public Color MainColor { private set; get; }

        public EmblemTriangle(int digit, Color dopColor, Color mainColor)
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
            Brush wheel = new SolidBrush(MainColor);


            g.FillEllipse(wheel, _startPosX + 2, _startPosY + 15, 25, 25);
            g.FillEllipse(wheel, _startPosX + 100, _startPosY + 15, 25, 25);

            Brush emblem = new SolidBrush(DopColor);
            PointF f1 = new PointF(_startPosX + 8, _startPosY + 35);
            PointF f2 = new PointF(_startPosX + 20, _startPosY + 35);
            PointF f3 = new PointF(_startPosX + 14, _startPosY +25);
            PointF[] emblemtr1 = { f1, f2, f3 };
            g.FillPolygon(emblem, emblemtr1);

            PointF b1 = new PointF(_startPosX + 106, _startPosY + 35);
            PointF b2 = new PointF(_startPosX + 118, _startPosY + 35);
            PointF b3 = new PointF(_startPosX + 112, _startPosY + 25);
            PointF[] emblemtr2 = { b1, b2, b3 };
            g.FillPolygon(emblem, emblemtr2);
        }

        private void DrawThreeWheels(Graphics g, float _startPosX, float _startPosY)
        {
            Brush wheel = new SolidBrush(MainColor);

            DrawTwoWheels(g, _startPosX, _startPosY);
            g.FillEllipse(wheel, _startPosX + 30, _startPosY + 15, 25, 25);

            Brush emblem = new SolidBrush(DopColor);
            PointF c1 = new PointF(_startPosX + 36, _startPosY + 35);
            PointF c2 = new PointF(_startPosX + 48, _startPosY + 35);
            PointF c3 = new PointF(_startPosX + 42, _startPosY + 25);
            PointF[] emblemtr3 = { c1, c2, c3 };
            g.FillPolygon(emblem, emblemtr3);
        }

        private void DrawFourWheels(Graphics g, float _startPosX, float _startPosY)
        {
            Brush wheel = new SolidBrush(MainColor);

            DrawThreeWheels(g, _startPosX, _startPosY);
            g.FillEllipse(wheel, _startPosX + 65, _startPosY + 15, 25, 25);

            Brush emblem = new SolidBrush(DopColor);
            PointF d1 = new PointF(_startPosX + 71, _startPosY + 35);
            PointF d2 = new PointF(_startPosX + 83, _startPosY + 35);
            PointF d3 = new PointF(_startPosX + 77, _startPosY + 25);
            PointF[] emblemtr4 = { d1, d2, d3 };
            g.FillPolygon(emblem, emblemtr4);
        }
    }
}

