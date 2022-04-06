using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGraphsEditor {
	public static class StringToVertexConverter {
		private const int NUMBER_OF_ELEMENTS = 5;

		public static Vertex Convert(string vertexAsString) {
			var array = vertexAsString.Split(' ');
			if(array.Length != NUMBER_OF_ELEMENTS)
				throw new ArgumentException();
			var result = new Vertex();
			result.PositionX = int.Parse(array[0]);
			result.PositionY = int.Parse(array[1]);
			byte r = byte.Parse(array[2]);
			byte g = byte.Parse(array[3]);
			byte b = byte.Parse(array[4]);
			result.VertexColor = Color.FromArgb(r, g, b);
			return result;
		}
	}
}
