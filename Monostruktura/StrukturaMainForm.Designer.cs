namespace Monostruktura
{
    partial class StrukturaMainForm
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
            this.pMain = new System.Windows.Forms.PictureBox();
            this.bRegenerate = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pMain.Location = new System.Drawing.Point(12, 41);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(804, 465);
            this.pMain.TabIndex = 0;
            this.pMain.TabStop = false;
            // 
            // bRegenerate
            // 
            this.bRegenerate.Location = new System.Drawing.Point(12, 12);
            this.bRegenerate.Name = "bRegenerate";
            this.bRegenerate.Size = new System.Drawing.Size(75, 23);
            this.bRegenerate.TabIndex = 1;
            this.bRegenerate.Text = "Regenerate";
            this.bRegenerate.UseVisualStyleBackColor = true;
            this.bRegenerate.Click += new System.EventHandler(this.bRegenerate_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(93, 12);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 2;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // StrukturaMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 518);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bRegenerate);
            this.Controls.Add(this.pMain);
            this.Name = "StrukturaMainForm";
            this.Load += new System.EventHandler(this.StrukturaMainForm_Load);
            this.Shown += new System.EventHandler(this.StrukturaMainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pMain;
        private System.Windows.Forms.Button bRegenerate;
        private System.Windows.Forms.Button bSave;
    }
}