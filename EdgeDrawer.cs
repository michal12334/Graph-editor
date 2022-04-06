using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGraphsEditor {
	public class EdgeDrawer : IDisposable {
		private readonly Pen pen;

		public EdgeDrawer() {
			pen = new Pen(Brushes.Black) {
				Width = 2
			};
		}

		public void DrawEdge(Edge edge, List<Vertex> vertices, Bitmap bitmap) {
			using var g = Graphics.FromImage(bitmap);
			g.DrawLine(
				pen,
				vertices[edge.Vertex1 - 1].GetCenterPosition().x, vertices[edge.Vertex1 - 1].GetCenterPosition().y,
				vertices[edge.Vertex2 - 1].GetCenterPosition().x, vertices[edge.Vertex2 - 1].GetCenterPosition().y
			);
		}

		public void Dispose() {
			pen.Dispose();
		}
	}
}
