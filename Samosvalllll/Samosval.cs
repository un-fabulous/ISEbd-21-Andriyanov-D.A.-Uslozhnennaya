using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Samosvalllll
{ 
    class Samosval
    {
        int downBottom = 40;
        int upBottom = 2;
        private float _startPosX;

        private float _startPosY;

        private int _pictureWidth;

        private int _pictureHeight;

        private readonly int samosvalWidth = 130;

        private readonly int samosvalHeight = 90;

        public int MaxSpeed { private set; get; }

        public float Weight { private set; get; }

        public Color MainColor { private set; get; }

        public Color DopColor { private set; get; }

        public bool Support { private set; get; }

        public bool Carcass { private set; get; }


        private WheelDop wheels;


        public Samosval(int maxSpeed, float weight, Color mainColor, Color dopColor, bool support, bool carcass, int wheelsCount)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Support = support;
            Carcass = carcass;
            wheels = new WheelDop(wheelsCount, dopColor);
        }


        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }


        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {

                case Direction.Right:   
                    if (_startPosX + step < _pictureWidth - samosvalWidth)
                    {
                        _startPosX += step;
                    }
                    break;

                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;

                case Direction.Up:
                    if (_startPosY + step > samosvalHeight / upBottom)
                    {
                        _startPosY -= step;
                    }
                    break;

                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - samosvalHeight + downBottom)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawTransport(Graphics g)
        {

            Brush samos = new SolidBrush(MainColor);

            PointF p1 = new PointF(_startPosX, _startPosY);
            PointF p2 = new PointF(_startPosX, _startPosY + 20);
            PointF p3 = new PointF(_startPosX + 85, _startPosY + 20);
            PointF p4 = new PointF(_startPosX +85 , _startPosY);


            PointF[] samosP = { p1, p2, p3, p4 };
            g.FillPolygon(samos, samosP);

            Brush head = new SolidBrush(MainColor);

            PointF s1 = new PointF(_startPosX + 95, _startPosY -20);
            PointF s2 = new PointF(_startPosX + 130, _startPosY -20);
            PointF s3 = new PointF(_startPosX + 130, _startPosY + 20);
            PointF s4 = new PointF(_startPosX + 95, _startPosY + 20);
    


            PointF[] headP = { s1, s2, s3, s4 };
            g.FillPolygon(head, headP);

            wheels.Draw(g, _startPosX, _startPosY);
            Pen line = new Pen(MainColor, 45);
            g.DrawLine(Pens.Black, _startPosX, _startPosY + 20, _startPosX + 128, _startPosY + 20);

            if (Support)
            {
                Brush support = new SolidBrush(DopColor);

                PointF w1 = new PointF(_startPosX + 65, _startPosY - 30 );
                PointF w2 = new PointF(_startPosX + 70, _startPosY + 20);
                PointF w3 = new PointF(_startPosX + 103, _startPosY + 20);
        

                PointF[] supportP = { w1, w2, w3};
                g.FillPolygon(support, supportP);
            }

            if (Carcass)
            {
                Brush carcass = new SolidBrush(DopColor);

                PointF f1 = new PointF(_startPosX+70, _startPosY);
                PointF f2 = new PointF(_startPosX, _startPosY + 20);
                PointF f3 = new PointF(_startPosX-10, _startPosY - 10);
                PointF f4 = new PointF(_startPosX + 65, _startPosY -30);


                PointF[] carcassP = { f1, f2, f3, f4};
                g.FillPolygon(carcass, carcassP);
            }
        }
    }
}