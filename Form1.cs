using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsGraphsEditor {
	public partial class Form1 : Form {
		private Bitmap drawArea;
		public const int RADIUS = 15;
		private readonly Graph graph;
		private readonly VertexDrawer vertexDrawer;
		private readonly VertexMarker vertexMarker;
		
		public Form1() {
			InitializeComponent();
			drawArea = new Bitmap(canvas.Size.Width, canvas.Size.Height);
			canvas.Image = drawArea;
			ClearCanvas();
			graph = new Graph();
			pictureBoxColor.BackColor = Color.Black;
			vertexDrawer = new VertexDrawer();
			vertexMarker = new VertexMarker();
		}

		private void ClearCanvas() {
			using(Graphics g = Graphics.FromImage(drawArea)) {
				g.Clear(Color.White);
			}
		}

		private void Canvas_MouseDown(object sender, MouseEventArgs e) {
			if(e.Button == MouseButtons.Left) {
				var newVertex = new Vertex() {
					PositionX = e.X - RADIUS,
					PositionY = e.Y - RADIUS,
					Number = graph.GetNumberOfVertices() + 1,
					VertexColor = colorDialogBox.Color
				};
				graph.AddVertexIfPossible(newVertex);
				if(newVertex.Number == graph.GetNumberOfVertices())
					DrawVertex(newVertex);
			} else if(e.Button == MouseButtons.Right) {
				vertexMarker.UpdateCurrentMarkedVertex(graph, e.X, e.Y);
				//graph.DeleteVertex(vertexMarker.GetNumberOfCurrentMarkedVertex(), vertexMarker);
				DrawGraph();
			}
		}

		private void DrawVertex(Vertex vertex) {
			vertexDrawer.DrawVertex(vertex, drawArea);
			canvas.Refresh();
		}

		private void DrawGraph() {
			ClearCanvas();
			graph.Draw(drawArea, vertexMarker);
			canvas.Refresh();
		}

		private void Form1_Resize(object sender, EventArgs e) {
			drawArea.Dispose();
			drawArea = new Bitmap(canvas.Size.Width, canvas.Size.Height);
			canvas.Image = drawArea;
			using(Graphics g = Graphics.FromImage(drawArea)) {
				g.Clear(Color.White);
			}
			DrawGraph();
		}

		private void ButtonColor_Click(object sender, EventArgs e) {
			var colorDialog = new ColorDialog();
			if(colorDialog.ShowDialog() == DialogResult.OK) {
				colorDialogBox.Color = colorDialog.Color;
				pictureBoxColor.BackColor = colorDialog.Color;
			}
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e) {
			if((e.KeyData & Keys.Delete) != 0) {
				if(vertexMarker.IsAnyVertexMarked()) { 
					graph.DeleteVertex(vertexMarker.GetNumberOfCurrentMarkedVertex(), vertexMarker);
					DrawGraph();
				}
			}
		}
	}
}
