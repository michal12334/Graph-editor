using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsGraphsEditor {
	public class Graph : IDisposable {
		internal readonly List<Vertex> vertices;
		private readonly GraphDrawer graphDrawer;
		internal readonly List<Edge> edges;

		public Graph() {
			vertices = new List<Vertex>();
			graphDrawer = new GraphDrawer();
			edges = new List<Edge>();
		}

		internal Graph(List<Vertex> vertices, List<Edge> edges) {
			this.vertices = vertices;
			this.edges = edges;
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

		public void Draw(Bitmap bitmap, VertexMarker vertexMarker) {
			graphDrawer.DrawGraph(vertices, edges, bitmap, vertexMarker);
		}

		public void DeleteVertex(VertexMarker vertexMarker) {
			DeleteAndEnumarateVertices(vertexMarker.GetNumberOfCurrentlyMarkedVertex());
			DeleteAndEnumerateEdges(vertexMarker.GetNumberOfCurrentlyMarkedVertex());
			vertexMarker.UnmarkVertex();
		}

		private void DeleteAndEnumerateEdges(int vertexNumber) {
			for(int i = 0; i < edges.Count; i++) {
				if(edges[i].Vertex1 == vertexNumber || edges[i].Vertex2 == vertexNumber) {
					edges.RemoveAt(i);
					i--;
					continue;
				}
				if(edges[i].Vertex1 > vertexNumber) {
					edges[i].Vertex1--;
				}
				if(edges[i].Vertex2 > vertexNumber) {
					edges[i].Vertex2--;
				}
			}
		}

		private void DeleteAndEnumarateVertices(int vertexNumber) {
			for(int i = 0; i < vertices.Count; i++) {
				if(vertices[i].Number == vertexNumber) {
					vertices.RemoveAt(i);
					i--;
					continue;
				}
				if(vertices[i].Number > vertexNumber) {
					vertices[i].Number--;
				}
			}
		}

		public void ChangeColorOfMarkedVertex(Color newColor, VertexMarker vertexMarker) {
			if(vertexMarker.IsAnyVertexMarked()) {
				vertices[vertexMarker.GetIndexOfCurrentlyMarkedVertex()].VertexColor = newColor;
			}
		}

		public void AddOrRemoveEdge(int v1Number, int v2Number) {
			if(v1Number > v2Number)
				(v1Number, v2Number) = (v2Number, v1Number);
			var edge = new Edge() {
				Vertex1 = v1Number,
				Vertex2 = v2Number
			};
			/*if(edges.Contains(edge))
				edges.Remove(edge);
			else
				edges.Add(edge);*/
			bool wasEdgeRemoved = false;
			for(int i = 0; i < edges.Count; i++) {
				if(edges[i].Vertex1 == edge.Vertex1 && edges[i].Vertex2 == edge.Vertex2) {
					edges.RemoveAt(i);
					wasEdgeRemoved = true;
					break;
				}
			}
			if(!wasEdgeRemoved)
				edges.Add(edge);
		}

		public void Dispose() {
			graphDrawer.Dispose();
		}
	}
}
