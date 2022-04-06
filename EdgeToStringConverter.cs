using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGraphsEditor {
	public static class EdgeToStringConverter {
		public static string Convert(Edge edge) {
			return $"{edge.Vertex1} {edge.Vertex2}";
		}
	}
}
