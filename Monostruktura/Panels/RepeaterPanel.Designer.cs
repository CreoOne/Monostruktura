namespace Monostruktura.Panels
{
    partial class RepeaterPanel
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
            this.lSpace = new System.Windows.Forms.Label();
            this.tbSpace = new System.Windows.Forms.TrackBar();
            this.lDirection = new System.Windows.Forms.Label();
            this.tbDirection = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
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
            this.tbCount.Maximum = 16;
            this.tbCount.Minimum = 2;
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(144, 45);
            this.tbCount.TabIndex = 1;
            this.tbCount.Value = 2;
            this.tbCount.Scroll += new System.EventHandler(this.tbCount_Scroll);
            // 
            // lSpace
            // 
            this.lSpace.AutoSize = true;
            this.lSpace.Location = new System.Drawing.Point(3, 64);
            this.lSpace.Name = "lSpace";
            this.lSpace.Size = new System.Drawing.Size(38, 13);
            this.lSpace.TabIndex = 2;
            this.lSpace.Text = "Space";
            // 
            // tbSpace
            // 
            this.tbSpace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSpace.Location = new System.Drawing.Point(3, 80);
            this.tbSpace.Maximum = 80;
            this.tbSpace.Minimum = 10;
            this.tbSpace.Name = "tbSpace";
            this.tbSpace.Size = new System.Drawing.Size(144, 45);
            this.tbSpace.TabIndex = 3;
            this.tbSpace.Value = 10;
            this.tbSpace.Scroll += new System.EventHandler(this.tbSpace_Scroll);
            // 
            // lDirection
            // 
            this.lDirection.AutoSize = true;
            this.lDirection.Location = new System.Drawing.Point(3, 128);
            this.lDirection.Name = "lDirection";
            this.lDirection.Size = new System.Drawing.Size(49, 13);
            this.lDirection.TabIndex = 4;
            this.lDirection.Text = "Direction";
            // 
            // tbDirection
            // 
            this.tbDirection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDirection.Location = new System.Drawing.Point(3, 144);
            this.tbDirection.Minimum = -10;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(144, 45);
            this.tbDirection.TabIndex = 5;
            this.tbDirection.Value = 10;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // RepeaterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.lDirection);
            this.Controls.Add(this.tbSpace);
            this.Controls.Add(this.lSpace);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.lCount);
            this.Name = "RepeaterPanel";
            this.Size = new System.Drawing.Size(150, 297);
            ((System.ComponentModel.ISupportInitialize)(this.tbCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.TrackBar tbCount;
        private System.Windows.Forms.Label lSpace;
        private System.Windows.Forms.TrackBar tbSpace;
        private System.Windows.Forms.Label lDirection;
        private System.Windows.Forms.TrackBar tbDirection;
    }
}
