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
		private Graph graph;
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
			using Graphics g = Graphics.FromImage(drawArea);
			g.Clear(Color.White);
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
				else {
					int clickedVertex = VertexMouseClicker.GetNumberOfClickedVertex(graph, e.X, e.Y);
					if(clickedVertex != vertexMarker.GetNumberOfCurrentlyMarkedVertex() && clickedVertex != -1 && vertexMarker.IsAnyVertexMarked()) {
						graph.AddOrRemoveEdge(clickedVertex, vertexMarker.GetNumberOfCurrentlyMarkedVertex());
						DrawGraph();
					}
				}
			} else if(e.Button == MouseButtons.Right) {
				vertexMarker.UpdateCurrentMarkedVertex(graph, e.X, e.Y);
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
				graph.ChangeColorOfMarkedVertex(colorDialog.Color, vertexMarker);
				DrawGraph();
			}
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e) {
			if((e.KeyData & Keys.Delete) != 0) {
				if(vertexMarker.IsAnyVertexMarked()) { 
					graph.DeleteVertex(vertexMarker);
					DrawGraph();
				}
			}
		}

		private void ButtonSave_Click(object sender, EventArgs e) {
			var saveFileDialog = new SaveFileDialog {
				Filter = "graph files (*.graph)|*.graph",
				RestoreDirectory = true
			};

			if(saveFileDialog.ShowDialog() == DialogResult.OK) {
				try {
					var writer = new GraphToFileWriter(graph, saveFileDialog.FileName);
					writer.Write();
				} catch(Exception) {
					MessageBox.Show("Cannot open this file!!");
				}
			}
		}

		private void ButtonOpen_Click(object sender, EventArgs e) {
			var readFileDialog = new OpenFileDialog() {
				Filter = "graph files (*.graph)|*.graph"
			};

			if(readFileDialog.ShowDialog() == DialogResult.OK) {
				try { 
					var reader = new GraphFromFileReader(readFileDialog.FileName);
					reader.Read();
					graph = reader.GetGraph();
					vertexMarker.UnmarkVertex();
					DrawGraph();
				} catch(Exception) {
					MessageBox.Show("Cannot read graph from this file!!");
				}
			}
		}
	}
}
