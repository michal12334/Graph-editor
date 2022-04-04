using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGraphsEditor {
	public class GraphDrawer {
		private readonly VertexDrawer vertexDrawer;

		public GraphDrawer() {
			vertexDrawer = new VertexDrawer();
		}

		public void DrawGraph(List<Vertex> vertices, Bitmap bitmap) {
			foreach(var v in vertices)
				vertexDrawer.DrawVertex(v, bitmap);
		}
	}
}
