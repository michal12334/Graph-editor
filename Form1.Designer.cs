
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.canvas = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBoxEdycja = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBoxColor = new System.Windows.Forms.PictureBox();
			this.buttonColor = new System.Windows.Forms.Button();
			this.buttonClearGraph = new System.Windows.Forms.Button();
			this.buttonDeleteVertex = new System.Windows.Forms.Button();
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
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
			this.groupBoxJezyk.SuspendLayout();
			this.groupBoxImportExport.SuspendLayout();
			this.SuspendLayout();
			// 
			// TableLayoutPanel
			// 
			resources.ApplyResources(this.TableLayoutPanel, "TableLayoutPanel");
			this.TableLayoutPanel.Controls.Add(this.canvas, 0, 0);
			this.TableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 0);
			this.TableLayoutPanel.Name = "TableLayoutPanel";
			// 
			// canvas
			// 
			resources.ApplyResources(this.canvas, "canvas");
			this.canvas.Cursor = System.Windows.Forms.Cursors.Cross;
			this.canvas.Name = "canvas";
			this.canvas.TabStop = false;
			this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
			this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
			this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.groupBoxEdycja, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBoxJezyk, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.groupBoxImportExport, 0, 2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// groupBoxEdycja
			// 
			resources.ApplyResources(this.groupBoxEdycja, "groupBoxEdycja");
			this.groupBoxEdycja.Controls.Add(this.panel1);
			this.groupBoxEdycja.Controls.Add(this.buttonClearGraph);
			this.groupBoxEdycja.Controls.Add(this.buttonDeleteVertex);
			this.groupBoxEdycja.Name = "groupBoxEdycja";
			this.groupBoxEdycja.TabStop = false;
			// 
			// panel1
			// 
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Controls.Add(this.pictureBoxColor);
			this.panel1.Controls.Add(this.buttonColor);
			this.panel1.Name = "panel1";
			// 
			// pictureBoxColor
			// 
			resources.ApplyResources(this.pictureBoxColor, "pictureBoxColor");
			this.pictureBoxColor.Name = "pictureBoxColor";
			this.pictureBoxColor.TabStop = false;
			// 
			// buttonColor
			// 
			resources.ApplyResources(this.buttonColor, "buttonColor");
			this.buttonColor.Name = "buttonColor";
			this.buttonColor.UseVisualStyleBackColor = true;
			this.buttonColor.Click += new System.EventHandler(this.ButtonColor_Click);
			// 
			// buttonClearGraph
			// 
			resources.ApplyResources(this.buttonClearGraph, "buttonClearGraph");
			this.buttonClearGraph.Name = "buttonClearGraph";
			this.buttonClearGraph.UseVisualStyleBackColor = true;
			this.buttonClearGraph.Click += new System.EventHandler(this.ButtonClearGraph_Click);
			// 
			// buttonDeleteVertex
			// 
			resources.ApplyResources(this.buttonDeleteVertex, "buttonDeleteVertex");
			this.buttonDeleteVertex.Name = "buttonDeleteVertex";
			this.buttonDeleteVertex.UseVisualStyleBackColor = true;
			this.buttonDeleteVertex.Click += new System.EventHandler(this.ButtonDeleteVertex_Click);
			// 
			// groupBoxJezyk
			// 
			resources.ApplyResources(this.groupBoxJezyk, "groupBoxJezyk");
			this.groupBoxJezyk.Controls.Add(this.buttonEnglish);
			this.groupBoxJezyk.Controls.Add(this.buttonPolish);
			this.groupBoxJezyk.Name = "groupBoxJezyk";
			this.groupBoxJezyk.TabStop = false;
			// 
			// buttonEnglish
			// 
			resources.ApplyResources(this.buttonEnglish, "buttonEnglish");
			this.buttonEnglish.Name = "buttonEnglish";
			this.buttonEnglish.UseVisualStyleBackColor = true;
			this.buttonEnglish.Click += new System.EventHandler(this.ButtonEnglish_Click);
			// 
			// buttonPolish
			// 
			resources.ApplyResources(this.buttonPolish, "buttonPolish");
			this.buttonPolish.Name = "buttonPolish";
			this.buttonPolish.UseVisualStyleBackColor = true;
			this.buttonPolish.Click += new System.EventHandler(this.ButtonPolish_Click);
			// 
			// groupBoxImportExport
			// 
			resources.ApplyResources(this.groupBoxImportExport, "groupBoxImportExport");
			this.groupBoxImportExport.Controls.Add(this.buttonOpen);
			this.groupBoxImportExport.Controls.Add(this.buttonSave);
			this.groupBoxImportExport.Name = "groupBoxImportExport";
			this.groupBoxImportExport.TabStop = false;
			// 
			// buttonOpen
			// 
			resources.ApplyResources(this.buttonOpen, "buttonOpen");
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.UseVisualStyleBackColor = true;
			this.buttonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
			// 
			// buttonSave
			// 
			resources.ApplyResources(this.buttonSave, "buttonSave");
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TableLayoutPanel);
			this.KeyPreview = true;
			this.Name = "Form1";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.TableLayoutPanel.ResumeLayout(false);
			this.TableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBoxEdycja.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
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
		private System.Windows.Forms.Button buttonClearGraph;
		private System.Windows.Forms.Button buttonDeleteVertex;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBoxColor;
		private System.Windows.Forms.Button buttonColor;
	}
}

