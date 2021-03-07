
namespace Lab1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mstripMain = new System.Windows.Forms.MenuStrip();
			this.tstripFile = new System.Windows.Forms.ToolStripMenuItem();
			this.tstripFileExit = new System.Windows.Forms.ToolStripButton();
			this.tstripHelp = new System.Windows.Forms.ToolStripButton();
			this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pboxTask = new System.Windows.Forms.PictureBox();
			this.tboxArrA = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.errpvdArrA = new System.Windows.Forms.ErrorProvider(this.components);
			this.mstripMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pboxTask)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errpvdArrA)).BeginInit();
			this.SuspendLayout();
			// 
			// mstripMain
			// 
			this.mstripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstripFile,
            this.tstripHelp});
			this.mstripMain.Location = new System.Drawing.Point(0, 0);
			this.mstripMain.Name = "mstripMain";
			this.mstripMain.Size = new System.Drawing.Size(702, 26);
			this.mstripMain.TabIndex = 2;
			this.mstripMain.Text = "Main menu";
			// 
			// tstripFile
			// 
			this.tstripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstripFileExit});
			this.tstripFile.Name = "tstripFile";
			this.tstripFile.Size = new System.Drawing.Size(37, 22);
			this.tstripFile.Text = "&File";
			// 
			// tstripFileExit
			// 
			this.tstripFileExit.Name = "tstripFileExit";
			this.tstripFileExit.Size = new System.Drawing.Size(30, 19);
			this.tstripFileExit.Text = "E&xit";
			this.tstripFileExit.Click += new System.EventHandler(this.tstripFileExit_Click);
			// 
			// tstripHelp
			// 
			this.tstripHelp.Name = "tstripHelp";
			this.tstripHelp.Size = new System.Drawing.Size(36, 19);
			this.tstripHelp.Text = "&Help";
			// 
			// customizeToolStripMenuItem
			// 
			this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
			this.customizeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			this.customizeToolStripMenuItem.Text = "&Customize";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			this.optionsToolStripMenuItem.Text = "&Options";
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			this.undoToolStripMenuItem.Text = "&Undo";
			// 
			// redoToolStripMenuItem
			// 
			this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
			this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.redoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			this.redoToolStripMenuItem.Text = "&Redo";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
			this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.cutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			this.cutToolStripMenuItem.Text = "Cu&t";
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
			this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			this.copyToolStripMenuItem.Text = "&Copy";
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
			this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			this.pasteToolStripMenuItem.Text = "&Paste";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 6);
			// 
			// selectAllToolStripMenuItem
			// 
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			this.selectAllToolStripMenuItem.Text = "Select &All";
			// 
			// pboxTask
			// 
			this.pboxTask.Image = global::Lab1.Properties.Resources.Task;
			this.pboxTask.InitialImage = ((System.Drawing.Image)(resources.GetObject("pboxTask.InitialImage")));
			this.pboxTask.Location = new System.Drawing.Point(12, 29);
			this.pboxTask.Name = "pboxTask";
			this.pboxTask.Size = new System.Drawing.Size(678, 81);
			this.pboxTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pboxTask.TabIndex = 3;
			this.pboxTask.TabStop = false;
			// 
			// tboxArrA
			// 
			this.tboxArrA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tboxArrA.Location = new System.Drawing.Point(12, 144);
			this.tboxArrA.Name = "tboxArrA";
			this.tboxArrA.Size = new System.Drawing.Size(598, 29);
			this.tboxArrA.TabIndex = 4;
			this.tboxArrA.TextChanged += new System.EventHandler(this.tboxArrA_TextChanged);
			this.tboxArrA.Validating += new System.ComponentModel.CancelEventHandler(this.tboxArrA_Validating);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox1.Location = new System.Drawing.Point(12, 211);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(598, 29);
			this.textBox1.TabIndex = 5;
			// 
			// errpvdArrA
			// 
			this.errpvdArrA.ContainerControl = this;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(702, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.tboxArrA);
			this.Controls.Add(this.pboxTask);
			this.Controls.Add(this.mstripMain);
			this.MainMenuStrip = this.mstripMain;
			this.Name = "MainForm";
			this.Text = "Lab1";
			this.mstripMain.ResumeLayout(false);
			this.mstripMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pboxTask)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errpvdArrA)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mstripMain;
        private System.Windows.Forms.ToolStripMenuItem tstripFile;
        private System.Windows.Forms.ToolStripButton tstripFileExit;
        private System.Windows.Forms.ToolStripButton tstripHelp;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.PictureBox pboxTask;
        private System.Windows.Forms.TextBox tboxArrA;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ErrorProvider epvdArrA;
		private System.Windows.Forms.ErrorProvider errpvdArrA;
	}
}

