namespace Monostruktura.Panels
{
    partial class RotorPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lCount = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lCount
            // 
            this.lCount.AutoSize = true;
            this.lCount.Location = new System.Drawing.Point(3, 0);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(35, 13);
            this.lCount.TabIndex = 0;
            this.lCount.Text = "Count";
            // 
            // tbCount
            // 
            this.tbCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCount.Location = new System.Drawing.Point(3, 16);
            this.tbCount.Maximum = 7;
            this.tbCount.Minimum = 2;
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(144, 45);
            this.tbCount.TabIndex = 1;
            this.tbCount.Value = 2;
            this.tbCount.Scroll += new System.EventHandler(this.tbCount_Scroll);
            // 
            // RotorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.lCount);
            this.Name = "RotorPanel";
            ((System.ComponentModel.ISupportInitialize)(this.tbCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.TrackBar tbCount;
    }
}
