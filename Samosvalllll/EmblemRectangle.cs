using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Samosvalllll
{
    class EmblemRectangle : IDopElement
    {
        private ElementsEnum wheelsOrnament;

        public int SetNumberOfElements { set => wheelsOrnament = (ElementsEnum)value; }

        public Color DopColor { private set; get; }

        public Color MainColor { private set; get; }

        public EmblemRectangle(int digit, Color dopColor, Color mainColor)
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
            PointF f3 = new PointF(_startPosX + 20, _startPosY + 25);
            PointF f4 = new PointF(_startPosX + 8, _startPosY + 25);
            PointF[] emblemrc1 = { f1, f2, f3, f4 };
            g.FillPolygon(emblem, emblemrc1);

            PointF b1 = new PointF(_startPosX + 106, _startPosY + 35);
            PointF b2 = new PointF(_startPosX + 118, _startPosY + 35);
            PointF b3 = new PointF(_startPosX + 118, _startPosY + 25);
            PointF b4 = new PointF(_startPosX + 106, _startPosY + 25);
            PointF[] emblemrc2 = { b1, b2, b3, b4 };
            g.FillPolygon(emblem, emblemrc2);


        }

        private void DrawThreeWheels(Graphics g, float _startPosX, float _startPosY)
        {
            Brush wheel = new SolidBrush(MainColor);

            DrawTwoWheels(g, _startPosX, _startPosY);
            g.FillEllipse(wheel, _startPosX + 30, _startPosY + 15, 25, 25);

            Brush emblem = new SolidBrush(DopColor);
            PointF c1 = new PointF(_startPosX + 36, _startPosY + 35);
            PointF c2 = new PointF(_startPosX + 48, _startPosY + 35);
            PointF c3 = new PointF(_startPosX + 48, _startPosY + 25);
            PointF c4 = new PointF(_startPosX + 36, _startPosY + 25);
            PointF[] emblemrc3 = { c1, c2, c3, c4 };
            g.FillPolygon(emblem, emblemrc3);

        }


        private void DrawFourWheels(Graphics g, float _startPosX, float _startPosY)
        {
            Brush wheel = new SolidBrush(MainColor);

            DrawThreeWheels(g, _startPosX, _startPosY);
            g.FillEllipse(wheel, _startPosX + 65, _startPosY + 15, 25, 25);

           
            Brush emblem = new SolidBrush(DopColor);
            PointF d1 = new PointF(_startPosX + 71, _startPosY + 35);
            PointF d2 = new PointF(_startPosX + 83, _startPosY + 35);
            PointF d3 = new PointF(_startPosX + 83, _startPosY + 25);
            PointF d4 = new PointF(_startPosX + 71, _startPosY + 25);
            PointF[] emblemrc4 = { d1, d2, d3, d4 };
            g.FillPolygon(emblem, emblemrc4);

        }

    }
}
