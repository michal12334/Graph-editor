using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGraphsEditor.Exceptions {
	public class ThereIsNotMarkedVertexException : Exception {
		public ThereIsNotMarkedVertexException(string message = "") :base(message) {
		}
	}
}
