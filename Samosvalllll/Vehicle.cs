using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Samosvalllll
{
	public abstract class Vehicle : ITransport
	{
		protected float _startPosX;
		protected float _startPosY;
		protected int _pictureWidth;
		protected int _pictureHeight;
		public int MaxSpeed { protected set; get; }
		public float Weight { protected set; get; }
		public Color MainColor { protected set; get; }
		public void SetMainColor(Color color)
		{
			MainColor = color;
		}
		public void SetPosition(int x, int y, int width, int height)
		{
			_startPosX = x;
			_startPosY = y;
			_pictureWidth = width;
			_pictureHeight = height;
		}
		public abstract void DrawTransport(Graphics g);
		public abstract void MoveTransport(Direction direction);
	}
}
