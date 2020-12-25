using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace Samosvalllll
{
    public class Samosval : Gruzovik, IEquatable<Samosval>, IComparable<Samosval>, IEnumerable<object>, IEnumerator<object>
    {
        public Color DopColor { private set; get; }
        public bool Support { private set; get; }
        public bool Carcass { private set; get; }

        IDopElement wheel;

        public new LinkedList<object> objectProperties = new LinkedList<object>();

        private int currentIndex = -1;

        public new object Current => objectProperties.Find(currentIndex);

        object IEnumerator<object>.Current => objectProperties.Find(currentIndex);

        public new void Dispose()
        {
        }

        public new bool MoveNext()
        {
            currentIndex++;
            return (currentIndex < 8);
        }

        public new void Reset()
        {
            currentIndex = -1;
        }

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

            objectProperties.AddLast(DopColor);
            objectProperties.AddLast(Support);
            objectProperties.AddLast(Carcass);
            objectProperties.AddLast(Wheels);
            objectProperties.AddLast(WheelsOrnament);
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
        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{Support}{separator}{Carcass}{separator}{Wheels}{separator}{WheelsOrnament}";
        }
        public bool Equals(Samosval other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Support != other.Support)
            {
                return false;
            }
            if (Carcass != other.Carcass)
            {
                return false;
            }
            if (Wheels != other.Wheels)
            {
                return false;
            }
            if (WheelsOrnament != other.WheelsOrnament)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Samosval carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }

        public int CompareTo(Samosval s)
        {
            if (MaxSpeed != s.MaxSpeed)
            {
                return MaxSpeed.CompareTo(s.MaxSpeed);
            }
            if (Weight != s.Weight)
            {
                return Weight.CompareTo(s.Weight);
            }
            if (MainColor != s.MainColor)
            {
                return MainColor.Name.CompareTo(s.MainColor.Name);
            }
            if (DopColor != s.DopColor)
            {
                return DopColor.Name.CompareTo(s.DopColor.Name);
            }
            if (Support != s.Support)
            {
                return Support.CompareTo(s.Support);
            }
            if (Carcass != s.Carcass)
            {
                return Carcass.CompareTo(s.Carcass);
            }
            if (Wheels != s.Wheels)
            {
                return Wheels.CompareTo(s.Wheels) ;
            }
            if (WheelsOrnament != s.WheelsOrnament)
            {
                return WheelsOrnament.CompareTo(s.WheelsOrnament);
            }
            return 0;
        }

        public new IEnumerator<object> GetEnumerator()
        {
            return (IEnumerator<object>)objectProperties;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
