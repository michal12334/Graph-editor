using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGraphsEditor {
	public static class VertexToStringConverter {
		public static string Convert(Vertex vertex) {
			return $"{vertex.PositionX} {vertex.PositionY} {vertex.VertexColor.R} {vertex.VertexColor.G} {vertex.VertexColor.B}";
		}
	}
}
