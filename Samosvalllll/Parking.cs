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
        private readonly List<T> _places;

        private readonly int _maxCount;

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly int _placeSizeWidth = 210;

        private readonly int _placeSizeHeight = 80;


        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
        }


        public static bool operator +(Parking<T, P> p, T car)
        {
            if (p._places.Count >= p._maxCount)
            {
                return false;
            }
            p._places.Add(car);
            return true;
        }
        public static T operator -(Parking<T, P> p, int index)
        {
            if (index < -1 || index > p._places.Count)
            {
                return null;
            }
            T car = p._places[index];
            p._places.RemoveAt(index);
            return car;
        }

       


        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; ++i)
            {
                _places[i].SetPosition(13 + i / 5 * _placeSizeWidth + 5, i % 5 *
                _placeSizeHeight + 33, pictureWidth, pictureHeight);
                _places[i].DrawTransport(g);
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
        public T this[int ind]
        {
            get
            {
                if (ind >= 0 && ind < _maxCount)
                {
                    return _places[ind];
                }
                return null;
            }
        }
    }
}
