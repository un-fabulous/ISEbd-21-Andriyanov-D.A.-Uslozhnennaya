﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Samosvalllll
{

    public class Samosval : Gruzovik
    {
        public Color DopColor { private set; get; }
        public bool Support { private set; get; }
        public bool Carcass { private set; get; }

        IDopElement wheel;

        public int Wheels { private set; get; }

        public string WheelsOrnament { private set; get; }

        public Samosval(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Support = Convert.ToBoolean(strs[4]);
                Carcass = Convert.ToBoolean(strs[5]);
                Wheels = Convert.ToInt32(strs[6]);
                WheelsOrnament = strs[7];

                if (WheelsOrnament == "EmblemTriangle")
                {
                    wheel = new EmblemTriangle(Wheels, DopColor, MainColor);
                }
                else if (WheelsOrnament == "EmblemRectangle")
                {
                    wheel = new EmblemRectangle(Wheels, DopColor, MainColor);
                }
                else if (WheelsOrnament == "EmblemCircle")
                {
                    wheel = new EmblemCircle(Wheels, DopColor, MainColor);
                }
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{Support}{separator}{Carcass}{separator}{Wheels}{separator}{WheelsOrnament}";
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
            if (WheelsOrnament == "EmblemCircle")
            {
                wheel = new EmblemCircle(Wheels, DopColor, MainColor);
            }
            else if (WheelsOrnament == "EmblemTriangle")
            {
                wheel = new EmblemTriangle(Wheels, DopColor, MainColor);
            }
            else if (WheelsOrnament == "EmblemRectangle")
            {
                wheel = new EmblemRectangle(Wheels, DopColor, MainColor);
            }
        }


        public void SetWheel(IDopElement wheels)
        {
            wheel = wheels;
            WheelsOrnament = wheel.GetType().Name;
        }

        public void SetWheelsNumber(int wheelNumber)
        {
            Wheels = wheelNumber;
        }

        public Samosval(int maxSpeed, float weight, Color mainColor, Color dopColor,
            bool support, bool carcass, int numberOfWheels, string ornamentwheel) :
            base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;
            Support = support;
            Carcass = carcass;
            Wheels = numberOfWheels;
            WheelsOrnament = ornamentwheel;

            if (WheelsOrnament == "EmblemCircle")
            {
                wheel = new EmblemCircle(Wheels, DopColor, MainColor);
            }
            else if (WheelsOrnament == "EmblemTriangle")
            {
                wheel = new EmblemTriangle(Wheels, DopColor, MainColor);
            }
            else if (WheelsOrnament == "EmblemRectangle")
            {
                wheel = new EmblemRectangle(Wheels, DopColor, MainColor);
            }
        }

        public Samosval(int maxSpeed, float weight, Color mainColor, Color dopColor, bool support, bool carcass) :
          base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;
            Support = support;
            Carcass = carcass;
            wheel = new EmblemCircle(3, dopColor, mainColor);
        }

        public override void DrawTransport(Graphics g)
        {
           

            if (Support)
            {
                Brush support = new SolidBrush(DopColor);

                PointF w1 = new PointF(_startPosX + 65, _startPosY - 30);
                PointF w2 = new PointF(_startPosX + 70, _startPosY + 20);
                PointF w3 = new PointF(_startPosX + 103, _startPosY + 20);


                PointF[] supportP = { w1, w2, w3 };
                g.FillPolygon(support, supportP);
            }

            if (Carcass)
            {
                Brush carcass = new SolidBrush(DopColor);

                PointF f1 = new PointF(_startPosX + 70, _startPosY);
                PointF f2 = new PointF(_startPosX, _startPosY + 20);
                PointF f3 = new PointF(_startPosX - 10, _startPosY - 10);
                PointF f4 = new PointF(_startPosX + 65, _startPosY - 30);


                PointF[] carcassP = { f1, f2, f3, f4 };
                g.FillPolygon(carcass, carcassP);
            }
            base.DrawTransport(g);
            Pen line = new Pen(MainColor, 45);
            g.DrawLine(Pens.Black, _startPosX, _startPosY + 20, _startPosX + 128, _startPosY + 20);

            if (wheel != null)
            {
                wheel.DrawElement(g, DopColor, MainColor, _startPosX, _startPosY);
            }
        }
        
    }
}
