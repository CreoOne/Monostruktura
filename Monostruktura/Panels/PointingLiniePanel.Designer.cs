namespace Monostruktura.Panels
{
    partial class PointingLiniePanel
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
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.lDirection = new System.Windows.Forms.Label();
            this.lLength = new System.Windows.Forms.Label();
            this.tbLength = new System.Windows.Forms.TrackBar();
            this.lWidth = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TrackBar();
            this.cbNegative = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(3, 16);
            this.tbDirection.Minimum = -10;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(180, 45);
            this.tbDirection.TabIndex = 0;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // lDirection
            // 
            this.lDirection.AutoSize = true;
            this.lDirection.Location = new System.Drawing.Point(3, 0);
            this.lDirection.Name = "lDirection";
            this.lDirection.Size = new System.Drawing.Size(49, 13);
            this.lDirection.TabIndex = 1;
            this.lDirection.Text = "Direction";
            // 
            // lLength
            // 
            this.lLength.AutoSize = true;
            this.lLength.Location = new System.Drawing.Point(3, 64);
            this.lLength.Name = "lLength";
            this.lLength.Size = new System.Drawing.Size(40, 13);
            this.lLength.TabIndex = 2;
            this.lLength.Text = "Length";
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(3, 80);
            this.tbLength.Maximum = 100;
            this.tbLength.Minimum = 3;
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(180, 45);
            this.tbLength.TabIndex = 3;
            this.tbLength.Value = 3;
            this.tbLength.Scroll += new System.EventHandler(this.tbLength_Scroll);
            // 
            // lWidth
            // 
            this.lWidth.AutoSize = true;
            this.lWidth.Location = new System.Drawing.Point(3, 128);
            this.lWidth.Name = "lWidth";
            this.lWidth.Size = new System.Drawing.Size(35, 13);
            this.lWidth.TabIndex = 4;
            this.lWidth.Text = "Width";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(3, 144);
            this.tbWidth.Maximum = 4;
            this.tbWidth.Minimum = 1;
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(180, 45);
            this.tbWidth.TabIndex = 5;
            this.tbWidth.Value = 3;
            this.tbWidth.Scroll += new System.EventHandler(this.tbWidth_Scroll);
            // 
            // cbNegative
            // 
            this.cbNegative.AutoSize = true;
            this.cbNegative.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbNegative.Location = new System.Drawing.Point(3, 195);
            this.cbNegative.Name = "cbNegative";
            this.cbNegative.Size = new System.Drawing.Size(69, 17);
            this.cbNegative.TabIndex = 7;
            this.cbNegative.Text = "Negative";
            this.cbNegative.UseVisualStyleBackColor = true;
            this.cbNegative.CheckedChanged += new System.EventHandler(this.cbNegative_CheckedChanged);
            // 
            // PointingLiniePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbNegative);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.lWidth);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.lLength);
            this.Controls.Add(this.lDirection);
            this.Controls.Add(this.tbDirection);
            this.Name = "PointingLiniePanel";
            this.Size = new System.Drawing.Size(186, 291);
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.Label lDirection;
        private System.Windows.Forms.Label lLength;
        private System.Windows.Forms.TrackBar tbLength;
        private System.Windows.Forms.Label lWidth;
        private System.Windows.Forms.TrackBar tbWidth;
        private System.Windows.Forms.CheckBox cbNegative;
    }
}
