using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Samosvalllll
{
    public class Parking<T, P> where T : class, ITransport where P : class, IDopElement
    {
        private readonly T[] _places;
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly int _placeSizeWidth = 210;
        private readonly int _placeSizeHeight = 80;


        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }


        public static bool operator +(Parking<T, P> p, T car)
        {
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p._places[i] == null)
                {
                    car.SetPosition(p._placeSizeWidth * (int)(i / (int)(p.pictureHeight / p._placeSizeHeight)) + 20, 35 + p._placeSizeHeight * (int)(i % (int)(p.pictureHeight / p._placeSizeHeight)), p.pictureWidth, p.pictureHeight);
                    p._places[i] = car;
                    return true;

                }
            }
            return false;
        }
        public static T operator -(Parking<T, P> p, int index)
        {
            if ((index < p._places.Length) && (index >= 0))
            {
                T car = p._places[index];
                p._places[index] = null;
                return car;
            }
            return null;
        }

        public static bool operator >(Parking<T, P> с, int i)
        {
            return с.Compare() > i;
        }

        public static bool operator <(Parking<T, P> с, int i)
        {
            return с.Compare() < i;
        }

        private int Compare()
        {
            int cnt = 0;
            for (int i = 0; i < _places.Length; ++i)
            {
                if (_places[i] != null)
                {
                    cnt++;
                }
            }
            return cnt;
        }


        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }

        }
    }
}
