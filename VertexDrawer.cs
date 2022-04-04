using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGraphsEditor {
	public class VertexDrawer {
		private readonly Pen normalPen;
		private readonly Pen dashedPen;
		private readonly Font font;
		private readonly StringFormat stringFormat;

		public VertexDrawer() {
			normalPen = new Pen(Brushes.Black) {
				Width = 2
			};
			dashedPen = new Pen(Brushes.Black) {
				Width = 2,
				DashPattern = new float[] { 2.0f, 2.0f }
			};
			font = new Font("Arial", 12);
			stringFormat = new StringFormat() {
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center
			};
		}

		public void DrawVertex(Vertex vertex, Bitmap bitmap, bool isVertexMarked = false) {
			using var g = Graphics.FromImage(bitmap);
			using var sb = new SolidBrush(vertex.VertexColor);
			normalPen.Color = vertex.VertexColor;
			dashedPen.Color = vertex.VertexColor;
			g.DrawEllipse(GetPen(isVertexMarked), vertex.PositionX, vertex.PositionY, Form1.RADIUS * 2, Form1.RADIUS * 2);
			g.DrawString(
				vertex.Number.ToString(),
				font,
				sb,
				new RectangleF(vertex.PositionX, vertex.PositionY, Form1.RADIUS * 2, Form1.RADIUS * 2),
				stringFormat
			);
		}

		private Pen GetPen(bool isVertexMarked) {
			return isVertexMarked ? dashedPen : normalPen;
		}
	}
}
