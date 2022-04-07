
namespace WinFormsGraphsEditor {
	partial class Form1 {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.canvas = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBoxEdycja = new System.Windows.Forms.GroupBox();
			this.buttonClearGraph = new System.Windows.Forms.Button();
			this.buttonDeleteVertex = new System.Windows.Forms.Button();
			this.flowLayoutPanelColor = new System.Windows.Forms.FlowLayoutPanel();
			this.buttonColor = new System.Windows.Forms.Button();
			this.pictureBoxColor = new System.Windows.Forms.PictureBox();
			this.groupBoxJezyk = new System.Windows.Forms.GroupBox();
			this.buttonEnglish = new System.Windows.Forms.Button();
			this.buttonPolish = new System.Windows.Forms.Button();
			this.groupBoxImportExport = new System.Windows.Forms.GroupBox();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.colorDialogBox = new System.Windows.Forms.ColorDialog();
			this.TableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBoxEdycja.SuspendLayout();
			this.flowLayoutPanelColor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
			this.groupBoxJezyk.SuspendLayout();
			this.groupBoxImportExport.SuspendLayout();
			this.SuspendLayout();
			// 
			// TableLayoutPanel
			// 
			this.TableLayoutPanel.AutoSize = true;
			this.TableLayoutPanel.ColumnCount = 2;
			this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TableLayoutPanel.Controls.Add(this.canvas, 0, 0);
			this.TableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 0);
			this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.TableLayoutPanel.Name = "TableLayoutPanel";
			this.TableLayoutPanel.RowCount = 1;
			this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 561F));
			this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 561F));
			this.TableLayoutPanel.Size = new System.Drawing.Size(784, 561);
			this.TableLayoutPanel.TabIndex = 0;
			// 
			// canvas
			// 
			this.canvas.Cursor = System.Windows.Forms.Cursors.Cross;
			this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.canvas.Location = new System.Drawing.Point(3, 3);
			this.canvas.Name = "canvas";
			this.canvas.Size = new System.Drawing.Size(621, 555);
			this.canvas.TabIndex = 0;
			this.canvas.TabStop = false;
			this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
			this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
			this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.groupBoxEdycja, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBoxJezyk, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.groupBoxImportExport, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(630, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(151, 555);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// groupBoxEdycja
			// 
			this.groupBoxEdycja.Controls.Add(this.buttonClearGraph);
			this.groupBoxEdycja.Controls.Add(this.buttonDeleteVertex);
			this.groupBoxEdycja.Controls.Add(this.flowLayoutPanelColor);
			this.groupBoxEdycja.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxEdycja.Location = new System.Drawing.Point(3, 3);
			this.groupBoxEdycja.Name = "groupBoxEdycja";
			this.groupBoxEdycja.Size = new System.Drawing.Size(145, 349);
			this.groupBoxEdycja.TabIndex = 0;
			this.groupBoxEdycja.TabStop = false;
			this.groupBoxEdycja.Text = "Edycja";
			// 
			// buttonClearGraph
			// 
			this.buttonClearGraph.Location = new System.Drawing.Point(6, 97);
			this.buttonClearGraph.Name = "buttonClearGraph";
			this.buttonClearGraph.Size = new System.Drawing.Size(132, 28);
			this.buttonClearGraph.TabIndex = 4;
			this.buttonClearGraph.Text = "Wyczyść graf";
			this.buttonClearGraph.UseVisualStyleBackColor = true;
			this.buttonClearGraph.Click += new System.EventHandler(this.ButtonClearGraph_Click);
			// 
			// buttonDeleteVertex
			// 
			this.buttonDeleteVertex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDeleteVertex.Enabled = false;
			this.buttonDeleteVertex.Location = new System.Drawing.Point(6, 63);
			this.buttonDeleteVertex.Name = "buttonDeleteVertex";
			this.buttonDeleteVertex.Size = new System.Drawing.Size(132, 28);
			this.buttonDeleteVertex.TabIndex = 3;
			this.buttonDeleteVertex.Text = "Usuń wierzchołek";
			this.buttonDeleteVertex.UseVisualStyleBackColor = true;
			this.buttonDeleteVertex.Click += new System.EventHandler(this.ButtonDeleteVertex_Click);
			// 
			// flowLayoutPanelColor
			// 
			this.flowLayoutPanelColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanelColor.Controls.Add(this.buttonColor);
			this.flowLayoutPanelColor.Controls.Add(this.pictureBoxColor);
			this.flowLayoutPanelColor.Location = new System.Drawing.Point(3, 19);
			this.flowLayoutPanelColor.Name = "flowLayoutPanelColor";
			this.flowLayoutPanelColor.Size = new System.Drawing.Size(139, 38);
			this.flowLayoutPanelColor.TabIndex = 2;
			// 
			// buttonColor
			// 
			this.buttonColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonColor.Location = new System.Drawing.Point(3, 3);
			this.buttonColor.Name = "buttonColor";
			this.buttonColor.Size = new System.Drawing.Size(95, 31);
			this.buttonColor.TabIndex = 1;
			this.buttonColor.Text = "Kolor";
			this.buttonColor.UseVisualStyleBackColor = true;
			this.buttonColor.Click += new System.EventHandler(this.ButtonColor_Click);
			// 
			// pictureBoxColor
			// 
			this.pictureBoxColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxColor.Location = new System.Drawing.Point(104, 3);
			this.pictureBoxColor.Name = "pictureBoxColor";
			this.pictureBoxColor.Size = new System.Drawing.Size(31, 31);
			this.pictureBoxColor.TabIndex = 0;
			this.pictureBoxColor.TabStop = false;
			// 
			// groupBoxJezyk
			// 
			this.groupBoxJezyk.Controls.Add(this.buttonEnglish);
			this.groupBoxJezyk.Controls.Add(this.buttonPolish);
			this.groupBoxJezyk.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxJezyk.Location = new System.Drawing.Point(3, 358);
			this.groupBoxJezyk.Name = "groupBoxJezyk";
			this.groupBoxJezyk.Size = new System.Drawing.Size(145, 94);
			this.groupBoxJezyk.TabIndex = 1;
			this.groupBoxJezyk.TabStop = false;
			this.groupBoxJezyk.Text = "Język";
			// 
			// buttonEnglish
			// 
			this.buttonEnglish.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonEnglish.Enabled = false;
			this.buttonEnglish.Location = new System.Drawing.Point(3, 58);
			this.buttonEnglish.Name = "buttonEnglish";
			this.buttonEnglish.Size = new System.Drawing.Size(139, 33);
			this.buttonEnglish.TabIndex = 2;
			this.buttonEnglish.Text = "Angielski";
			this.buttonEnglish.UseVisualStyleBackColor = true;
			// 
			// buttonPolish
			// 
			this.buttonPolish.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonPolish.Enabled = false;
			this.buttonPolish.Location = new System.Drawing.Point(3, 19);
			this.buttonPolish.Name = "buttonPolish";
			this.buttonPolish.Size = new System.Drawing.Size(139, 33);
			this.buttonPolish.TabIndex = 1;
			this.buttonPolish.Text = "Polski";
			this.buttonPolish.UseVisualStyleBackColor = true;
			// 
			// groupBoxImportExport
			// 
			this.groupBoxImportExport.Controls.Add(this.buttonOpen);
			this.groupBoxImportExport.Controls.Add(this.buttonSave);
			this.groupBoxImportExport.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxImportExport.Location = new System.Drawing.Point(3, 458);
			this.groupBoxImportExport.Name = "groupBoxImportExport";
			this.groupBoxImportExport.Size = new System.Drawing.Size(145, 94);
			this.groupBoxImportExport.TabIndex = 2;
			this.groupBoxImportExport.TabStop = false;
			this.groupBoxImportExport.Text = "Import/Export";
			// 
			// buttonOpen
			// 
			this.buttonOpen.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonOpen.Location = new System.Drawing.Point(3, 58);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(139, 33);
			this.buttonOpen.TabIndex = 1;
			this.buttonOpen.Text = "Wczytaj";
			this.buttonOpen.UseVisualStyleBackColor = true;
			this.buttonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonSave.Location = new System.Drawing.Point(3, 19);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(139, 33);
			this.buttonSave.TabIndex = 0;
			this.buttonSave.Text = "Zapisz";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.TableLayoutPanel);
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.TableLayoutPanel.ResumeLayout(false);
			this.TableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBoxEdycja.ResumeLayout(false);
			this.flowLayoutPanelColor.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
			this.groupBoxJezyk.ResumeLayout(false);
			this.groupBoxImportExport.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
		private System.Windows.Forms.PictureBox canvas;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBoxEdycja;
		private System.Windows.Forms.GroupBox groupBoxJezyk;
		private System.Windows.Forms.GroupBox groupBoxImportExport;
		private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonEnglish;
		private System.Windows.Forms.Button buttonPolish;
		private System.Windows.Forms.ColorDialog colorDialogBox;
		private System.Windows.Forms.PictureBox pictureBoxColor;
		private System.Windows.Forms.Button buttonColor;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelColor;
		private System.Windows.Forms.Button buttonClearGraph;
		private System.Windows.Forms.Button buttonDeleteVertex;
	}
}

