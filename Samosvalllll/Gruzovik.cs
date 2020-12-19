using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Samosvalllll
{
    public class Gruzovik : Vehicle
	{
		protected readonly int carWidth = 110;

		protected readonly int carHeight = 60;
		public Gruzovik(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}
		protected Gruzovik(int maxSpeed, float weight, Color mainColor, int carWidth, int carHeight)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			this.carWidth = carWidth;
			this.carHeight = carHeight;
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
