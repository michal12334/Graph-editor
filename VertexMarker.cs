using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsGraphsEditor.Exceptions;

namespace WinFormsGraphsEditor {
	public class VertexMarker {
		private int numberOfCurrentlyMarkedVertex;

		public VertexMarker() {
			numberOfCurrentlyMarkedVertex = -1;
		}

		public void UpdateCurrentMarkedVertex(Graph graph, int mousePositionX, int mousePositionY) {
			for(int i = 0; i < graph.vertices.Count; i++) {
				if(IsMouseInVertex(graph.vertices[i], mousePositionX, mousePositionY)) {
					numberOfCurrentlyMarkedVertex = i + 1;
					return;
				}
			}
			numberOfCurrentlyMarkedVertex = -1;
		}

		private bool IsMouseInVertex(Vertex vertex, int mousePositionX, int mousePositionY) {
			var vertextCenterPosition = vertex.GetCenterPosition();
			int distance2 = (vertextCenterPosition.x - mousePositionX) * (vertextCenterPosition.x - mousePositionX) 
				+ (vertextCenterPosition.y - mousePositionY) * (vertextCenterPosition.y - mousePositionY);
			return distance2 <= Form1.RADIUS * Form1.RADIUS;
		}

		public int GetNumberOfCurrentlyMarkedVertex() {
			return numberOfCurrentlyMarkedVertex;
		}

		public bool IsAnyVertexMarked() {
			return numberOfCurrentlyMarkedVertex != -1;
		}

		public void UnmarkVertex() {
			numberOfCurrentlyMarkedVertex = -1;
		}

		public int GetIndexOfCurrentlyMarkedVertex() {
			if(IsAnyVertexMarked())
				return GetNumberOfCurrentlyMarkedVertex() - 1;
			throw new ThereIsNotMarkedVertexException();
		}
	}
}
