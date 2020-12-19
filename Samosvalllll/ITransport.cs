using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Samosvalllll
{
	public interface ITransport
	{
		void MoveTransport(Direction direction);
		void SetPosition(int x, int y, int width, int height);
		void DrawTransport(Graphics g);
	}
}