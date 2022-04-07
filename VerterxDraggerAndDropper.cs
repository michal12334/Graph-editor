using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGraphsEditor {
	public class VerterxDraggerAndDropper {
		private Vertex vertex;
		private bool enabled = false;
		private (int x, int y) previousMousePosition;

		public void SetVertex(Vertex vertex) {
			this.vertex = vertex;
		}

		public void Start(int mousePositionX, int mousePositionY) {
			enabled = true;
			previousMousePosition = (mousePositionX, mousePositionY);
		}

		public void Move(int mousePositionX, int mousePositionY) {
			if(!enabled)
				return;
			vertex.PositionX += mousePositionX - previousMousePosition.x;
			vertex.PositionY += mousePositionY - previousMousePosition.y;
			previousMousePosition = (mousePositionX, mousePositionY);
		}

		public void End() {
			enabled = false;
		}
	}
}
