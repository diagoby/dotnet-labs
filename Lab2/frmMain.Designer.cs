
namespace Lab2
{
    partial class frmMain
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
            this.dtgridvMatrix = new System.Windows.Forms.DataGridView();
            this.bindsrcMatrix = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridvMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindsrcMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgridvMatrix
            // 
            this.dtgridvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridvMatrix.ColumnHeadersVisible = false;
            this.dtgridvMatrix.Location = new System.Drawing.Point(29, 29);
            this.dtgridvMatrix.Name = "dtgridvMatrix";
            this.dtgridvMatrix.RowTemplate.Height = 25;
            this.dtgridvMatrix.Size = new System.Drawing.Size(555, 417);
            this.dtgridvMatrix.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 471);
            this.Controls.Add(this.dtgridvMatrix);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridvMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindsrcMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgridvMatrix;
        private System.Windows.Forms.BindingSource bindsrcMatrix;
    }
}

