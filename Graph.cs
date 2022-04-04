using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsGraphsEditor {
	public class Graph {
		private readonly List<Vertex> vertices;
		private readonly GraphDrawer graphDrawer;

		public Graph() {
			vertices = new List<Vertex>();
			graphDrawer = new GraphDrawer();
		}

		public void AddVertexIfPossible(Vertex vertex) {
			if(IsPossibleToAddVertex(vertex))
				vertices.Add(vertex);
		}

		private bool IsPossibleToAddVertex(Vertex v) {
			foreach(var u in vertices)
				if(IsCollisionBetweenTwoVertexes(v, u))
					return false;
			return true;
		}

		private static bool IsCollisionBetweenTwoVertexes(Vertex v, Vertex u) {
			int distance2 = (v.PositionX - u.PositionX) * (v.PositionX - u.PositionX) + (v.PositionY - u.PositionY) * (v.PositionY - u.PositionY);
			return distance2 <= Form1.RADIUS * Form1.RADIUS * 4;
		}

		public int GetNumberOfVertices() {
			return vertices.Count;
		}

		public void Draw(Bitmap bitmap) {
			graphDrawer.DrawGraph(vertices, bitmap);
		}
	}
}
