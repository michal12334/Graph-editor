using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGraphsEditor {
	public class GraphFromFileReader {
		private string filePath;
		private Graph graph;

		public GraphFromFileReader(string filePath) {
			this.filePath = filePath;
		}

		public void Read() {
			using var fileReader = new StreamReader(filePath);
			int lineIter = 0;
			int numberOfVertices = 0;
			List<Vertex> vertices = new List<Vertex>();
			List<Edge> edges = new List<Edge>();
			while(true) {
				string currentLine = fileReader.ReadLine();
				if(currentLine == null)
					break;
				if(lineIter == 0) {
					numberOfVertices = int.Parse(currentLine);
				} else if(lineIter <= numberOfVertices) {
					var newVertex = StringToVertexConverter.Convert(currentLine);
					newVertex.Number = lineIter;
					vertices.Add(newVertex);
				} else {
					var newEdge = StringToEdgeConverter.Convert(currentLine);
					if(!IsEdgeValid(newEdge, numberOfVertices)) {
						throw new Exception();
					}
					edges.Add(newEdge);
				}
				lineIter++;
			}
			graph = new Graph(vertices, edges);
		}

		private bool IsEdgeValid(Edge edge, int numberOfVertices) {
			return IsOneEndOfEdgeValid(edge.Vertex1, numberOfVertices) && IsOneEndOfEdgeValid(edge.Vertex2, numberOfVertices) && edge.Vertex2 > edge.Vertex1;
		}

		private bool IsOneEndOfEdgeValid(int endOfEdge, int numberOfVertices) {
			return endOfEdge > 0 && endOfEdge <= numberOfVertices;
		}

		public Graph GetGraph() {
			return graph;
		}
	}
}
