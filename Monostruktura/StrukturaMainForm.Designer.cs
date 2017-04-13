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
            this.nWidth = new System.Windows.Forms.NumericUpDown();
            this.nHeight = new System.Windows.Forms.NumericUpDown();
            this.bRedraw = new System.Windows.Forms.Button();
            this.cPreset = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHeight)).BeginInit();
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
            // nWidth
            // 
            this.nWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nWidth.Location = new System.Drawing.Point(557, 15);
            this.nWidth.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.nWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nWidth.Name = "nWidth";
            this.nWidth.Size = new System.Drawing.Size(86, 20);
            this.nWidth.TabIndex = 3;
            this.nWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nWidth.Leave += new System.EventHandler(this.nWidth_nHeight_Leave);
            // 
            // nHeight
            // 
            this.nHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nHeight.Location = new System.Drawing.Point(649, 15);
            this.nHeight.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.nHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nHeight.Name = "nHeight";
            this.nHeight.Size = new System.Drawing.Size(86, 20);
            this.nHeight.TabIndex = 4;
            this.nHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nHeight.Leave += new System.EventHandler(this.nWidth_nHeight_Leave);
            // 
            // bRedraw
            // 
            this.bRedraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRedraw.Location = new System.Drawing.Point(741, 12);
            this.bRedraw.Name = "bRedraw";
            this.bRedraw.Size = new System.Drawing.Size(75, 23);
            this.bRedraw.TabIndex = 5;
            this.bRedraw.Text = "Redraw";
            this.bRedraw.UseVisualStyleBackColor = true;
            this.bRedraw.Click += new System.EventHandler(this.bRedraw_Click);
            // 
            // cPreset
            // 
            this.cPreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cPreset.FormattingEnabled = true;
            this.cPreset.Items.AddRange(new object[] {
            "Custom",
            "Facebook Post",
            "Facebook Profile",
            "Facebook Cover"});
            this.cPreset.Location = new System.Drawing.Point(430, 14);
            this.cPreset.Name = "cPreset";
            this.cPreset.Size = new System.Drawing.Size(121, 21);
            this.cPreset.TabIndex = 6;
            this.cPreset.SelectedIndexChanged += new System.EventHandler(this.cPreset_SelectedIndexChanged);
            // 
            // StrukturaMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 518);
            this.Controls.Add(this.cPreset);
            this.Controls.Add(this.bRedraw);
            this.Controls.Add(this.nHeight);
            this.Controls.Add(this.nWidth);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bRegenerate);
            this.Controls.Add(this.pMain);
            this.Name = "StrukturaMainForm";
            this.Load += new System.EventHandler(this.StrukturaMainForm_Load);
            this.Shown += new System.EventHandler(this.StrukturaMainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pMain;
        private System.Windows.Forms.Button bRegenerate;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.NumericUpDown nWidth;
        private System.Windows.Forms.NumericUpDown nHeight;
        private System.Windows.Forms.Button bRedraw;
        private System.Windows.Forms.ComboBox cPreset;
    }
}