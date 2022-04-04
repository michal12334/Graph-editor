using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGraphsEditor {
	public class VertexDrawer {
		private readonly Pen pen;
		private readonly Font font;
		private readonly StringFormat stringFormat;

		public VertexDrawer() {
			pen = new Pen(Brushes.Black) {
				Width = 2
			};
			font = new Font("Arial", 12);
			stringFormat = new StringFormat() {
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center
			};
		}

		public void DrawVertex(Vertex vertex, Bitmap bitmap) {
			using var g = Graphics.FromImage(bitmap);
			using var sb = new SolidBrush(vertex.VertexColor);
			pen.Color = vertex.VertexColor;
			g.DrawEllipse(pen, vertex.PositionX, vertex.PositionY, Form1.RADIUS * 2, Form1.RADIUS * 2);
			g.DrawString(
				vertex.Number.ToString(),
				font,
				sb,
				new RectangleF(vertex.PositionX, vertex.PositionY, Form1.RADIUS * 2, Form1.RADIUS * 2),
				stringFormat
			);
		}
	}
}
