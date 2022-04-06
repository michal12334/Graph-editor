using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGraphsEditor {
	public static class StringToEdgeConverter {
		private const int NUMBER_OF_ELEMENTS = 2;

		public static Edge Convert(string edgeAsString) {
			var array = edgeAsString.Split(' ');
			if(array.Length != NUMBER_OF_ELEMENTS)
				throw new ArgumentException();
			var result = new Edge();
			result.Vertex1 = int.Parse(array[0]);
			result.Vertex2 = int.Parse(array[1]);
			return result;
		}
	}
}
