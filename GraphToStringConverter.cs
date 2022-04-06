using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGraphsEditor {
	public static class GraphToStringConverter {
		public static string Convert(Graph graph) {
			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(graph.vertices.Count.ToString());
			foreach(var v in graph.vertices)
				stringBuilder.AppendLine(VertexToStringConverter.Convert(v));
			foreach(var e in graph.edges)
				stringBuilder.AppendLine(EdgeToStringConverter.Convert(e));
			return stringBuilder.ToString();
		}
	}
}
