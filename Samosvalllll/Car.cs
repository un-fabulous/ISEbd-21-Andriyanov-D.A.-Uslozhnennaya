using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace Samosvalllll
{
	 public class Car : Gruzovik, IEquatable<Car>, IComparable<Car>, IEnumerable<object>, IEnumerator<object>
	{
		protected readonly int carWidth = 110;

		protected readonly int carHeight = 60;

		protected readonly char separator = ';';

		public LinkedList<object> objectProperties = new LinkedList<object>();

		private int currentIndex = -1;

		public object Current => objectProperties.Find(currentIndex);

		object IEnumerator<object>.Current => objectProperties.Find(currentIndex);

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			currentIndex++;
			return (currentIndex < 8);
		}

		public void Reset()
		{
			currentIndex = -1;
		}

		public Car(string info)
		{
			string[] strs = info.Split(separator);
			if (strs.Length == 3)
			{
				MaxSpeed = Convert.ToInt32(strs[0]);
				Weight = Convert.ToInt32(strs[1]);
				MainColor = Color.FromName(strs[2]);
				objectProperties.AddLast(MaxSpeed);
				objectProperties.AddLast(Weight);
				objectProperties.AddLast(MainColor);
			}
		}

		public override string ToString()
		{
			return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
		}

		public Car(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			objectProperties.AddLast(MaxSpeed);
			objectProperties.AddLast(Weight);
			objectProperties.AddLast(MainColor);
		}
		protected Car(int maxSpeed, float weight, Color mainColor, int carWidth, int carHeight)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			this.carWidth = carWidth;
			this.carHeight = carHeight;
			objectProperties.AddLast(MaxSpeed);
			objectProperties.AddLast(Weight);
			objectProperties.AddLast(MainColor);
		}

		public bool Equals(Car other)
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
			return true;
		}

		public override bool Equals(Object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (!(obj is Car planeObj))
			{
				return false;
			}
			else
			{
				return Equals(planeObj);
			}
		}

		public int CompareTo(Car p)
		{
			if (MaxSpeed != p.MaxSpeed)
			{
				return MaxSpeed.CompareTo(p.MaxSpeed);
			}
			if (Weight != p.Weight)
			{
				return Weight.CompareTo(p.Weight);
			}
			if (MainColor != p.MainColor)
			{
				return MainColor.Name.CompareTo(p.MainColor.Name);
			}
			return 0;
		}

		public IEnumerator<object> GetEnumerator()
		{
			return (IEnumerator<object>)objectProperties;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public override void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - carWidth)
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
					if (_startPosY + step > carHeight / 2)
					{
						_startPosY -= step;
					}
					break;

				case Direction.Down:
					if (_startPosY + step < _pictureHeight - carHeight + 40)
					{
						_startPosY += step;
					}
					break;
			}
		}
		public override void DrawTransport(Graphics g)
		{
			Pen line = new Pen(MainColor, 45);
			g.DrawLine(Pens.Black, _startPosX, _startPosY + 20, _startPosX + 128, _startPosY + 20);

			Brush samos = new SolidBrush(MainColor);

			PointF p1 = new PointF(_startPosX, _startPosY);
			PointF p2 = new PointF(_startPosX, _startPosY + 20);
			PointF p3 = new PointF(_startPosX + 85, _startPosY + 20);
			PointF p4 = new PointF(_startPosX + 85, _startPosY);


			PointF[] samosP = { p1, p2, p3, p4 };
			g.FillPolygon(samos, samosP);

			Brush head = new SolidBrush(MainColor);

			PointF s1 = new PointF(_startPosX + 95, _startPosY - 20);
			PointF s2 = new PointF(_startPosX + 130, _startPosY - 20);
			PointF s3 = new PointF(_startPosX + 130, _startPosY + 20);
			PointF s4 = new PointF(_startPosX + 95, _startPosY + 20);



			PointF[] headP = { s1, s2, s3, s4 };
			g.FillPolygon(head, headP);

			Brush circ = new SolidBrush(MainColor);
			g.FillEllipse(circ, _startPosX + 2, _startPosY + 15, 25, 25);
			
			g.FillEllipse(circ, _startPosX + 100, _startPosY + 15, 25, 25);
		}
			
	}
}
