using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGraphsEditor {
	public class GraphToFileWriter {
		private Graph graph;
		private string filePath;

		public GraphToFileWriter(Graph graph, string filePath) {
			this.graph = graph;
			this.filePath = filePath;
		}

		public void Write() {
			var lines = GraphToStringConverter.Convert(graph);
			using var fileWriter = new StreamWriter(filePath);
			fileWriter.Write(lines);
		}
	}
}
