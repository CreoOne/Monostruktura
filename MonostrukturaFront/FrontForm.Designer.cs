namespace MonostrukturaFront
{
    partial class FrontForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bMonostrukturaMainForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bMonostrukturaMainForm
            // 
            this.bMonostrukturaMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bMonostrukturaMainForm.Location = new System.Drawing.Point(12, 12);
            this.bMonostrukturaMainForm.Name = "bMonostrukturaMainForm";
            this.bMonostrukturaMainForm.Size = new System.Drawing.Size(260, 23);
            this.bMonostrukturaMainForm.TabIndex = 0;
            this.bMonostrukturaMainForm.Text = "Monostruktura Main Form";
            this.bMonostrukturaMainForm.UseVisualStyleBackColor = true;
            this.bMonostrukturaMainForm.Click += new System.EventHandler(this.bMonostrukturaMainForm_Click);
            // 
            // FrontForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bMonostrukturaMainForm);
            this.Name = "FrontForm";
            this.Text = "Monostruktura";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bMonostrukturaMainForm;
    }
}

