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
		private readonly VerterxDraggerAndDropper verterxDraggerAndDropper;
		
		public Form1() {
			InitializeComponent();
			drawArea = new Bitmap(canvas.Size.Width, canvas.Size.Height);
			canvas.Image = drawArea;
			ClearCanvas();
			graph = new Graph();
			pictureBoxColor.BackColor = Color.Black;
			vertexDrawer = new VertexDrawer();
			vertexMarker = new VertexMarker();
			verterxDraggerAndDropper = new VerterxDraggerAndDropper();
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
			} else if(e.Button == MouseButtons.Middle) {
				if(vertexMarker.IsAnyVertexMarked()) {
					verterxDraggerAndDropper.SetVertex(graph.vertices[vertexMarker.GetIndexOfCurrentlyMarkedVertex()]);
					verterxDraggerAndDropper.Start(e.X, e.Y);
				}
			}
		}

		private void DrawVertex(Vertex vertex) {
			vertexDrawer.DrawVertex(vertex, drawArea);
			canvas.Refresh();
		}

		private void DrawGraph() {
			ClearCanvas();
			buttonDeleteVertex.Enabled = vertexMarker.IsAnyVertexMarked();
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
				DeleteMarkedVertex();
			}
		}

		private void DeleteMarkedVertex() {
			if(vertexMarker.IsAnyVertexMarked()) {
				graph.DeleteVertex(vertexMarker);
				DrawGraph();
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
					graph.Dispose();
					graph = reader.GetGraph();
					vertexMarker.UnmarkVertex();
					DrawGraph();
				} catch(Exception) {
					MessageBox.Show("Cannot read graph from this file!!");
				}
			}
		}

		private void ButtonDeleteVertex_Click(object sender, EventArgs e) {
			DeleteMarkedVertex();
		}

		private void ButtonClearGraph_Click(object sender, EventArgs e) {
			graph.Dispose();
			graph = new Graph();
			vertexMarker.UnmarkVertex();
			DrawGraph();
		}

		private void Canvas_MouseMove(object sender, MouseEventArgs e) {
			verterxDraggerAndDropper.Move(e.X, e.Y);
			DrawGraph();
		}

		private void Canvas_MouseUp(object sender, MouseEventArgs e) {
			if(e.Button == MouseButtons.Middle) {
				verterxDraggerAndDropper.End();
			}
		}
	}
}
