using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGraphsEditor {
	public class Vertex {
		public int PositionX { get; set; }
		public int PositionY { get; set; }
		public int Number { get; set; }
		public Color VertexColor { get; set; }

		public (int x, int y) GetCenterPosition() {
			return (PositionX + Form1.RADIUS, PositionY + Form1.RADIUS);
		}
	}
}
