using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGraphsEditor {
	public class GraphDrawer : IDisposable {
		private readonly VertexDrawer vertexDrawer;
		private readonly EdgeDrawer edgeDrawer;

		public GraphDrawer() {
			vertexDrawer = new VertexDrawer();
			edgeDrawer = new EdgeDrawer();
		}

		public void DrawGraph(List<Vertex> vertices, List<Edge> edges, Bitmap bitmap, VertexMarker vertexMarker) {
			foreach(var e in edges)
				edgeDrawer.DrawEdge(e, vertices, bitmap);
			foreach(var v in vertices)
				vertexDrawer.DrawVertex(v, bitmap, IsVertexMarked(vertexMarker, v));
		}

		private static bool IsVertexMarked(VertexMarker vertexMarker, Vertex v) {
			return v.Number == vertexMarker.GetNumberOfCurrentlyMarkedVertex();
		}

		public void Dispose() {
			vertexDrawer.Dispose();
			edgeDrawer.Dispose();
		}
	}
}
