using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGraphsEditor {
	public static class VertexMouseClicker {
		public static int GetNumberOfClickedVertex(Graph graph, int mousePositionX, int mousePositionY) {
			for(int i = 0; i < graph.vertices.Count; i++) {
				if(IsMouseInVertex(graph.vertices[i], mousePositionX, mousePositionY)) {
					return i + 1;
				}
			}
			return -1;
		}

		private static bool IsMouseInVertex(Vertex vertex, int mousePositionX, int mousePositionY) {
			var vertextCenterPosition = vertex.GetCenterPosition();
			int distance2 = (vertextCenterPosition.x - mousePositionX) * (vertextCenterPosition.x - mousePositionX)
				+ (vertextCenterPosition.y - mousePositionY) * (vertextCenterPosition.y - mousePositionY);
			return distance2 <= Form1.RADIUS * Form1.RADIUS;
		}
	}
}
