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
            this.nWidth = new System.Windows.Forms.NumericUpDown();
            this.nHeight = new System.Windows.Forms.NumericUpDown();
            this.bRedraw = new System.Windows.Forms.Button();
            this.cPreset = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.structureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pPartPanel = new Monostruktura.PartPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHeight)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pMain.Location = new System.Drawing.Point(226, 56);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(611, 450);
            this.pMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pMain.TabIndex = 0;
            this.pMain.TabStop = false;
            // 
            // nWidth
            // 
            this.nWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nWidth.Location = new System.Drawing.Point(578, 30);
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
            this.nHeight.Location = new System.Drawing.Point(670, 30);
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
            this.bRedraw.Location = new System.Drawing.Point(762, 27);
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
            this.cPreset.Location = new System.Drawing.Point(451, 29);
            this.cPreset.Name = "cPreset";
            this.cPreset.Size = new System.Drawing.Size(121, 21);
            this.cPreset.TabIndex = 6;
            this.cPreset.SelectedIndexChanged += new System.EventHandler(this.cPreset_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.structureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // structureToolStripMenuItem
            // 
            this.structureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.structureToolStripMenuItem.Name = "structureToolStripMenuItem";
            this.structureToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.structureToolStripMenuItem.Text = "Structure";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emptyToolStripMenuItem,
            this.randomToolStripMenuItem});
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.generateToolStripMenuItem.Text = "Generate";
            // 
            // emptyToolStripMenuItem
            // 
            this.emptyToolStripMenuItem.Name = "emptyToolStripMenuItem";
            this.emptyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.emptyToolStripMenuItem.Text = "Empty";
            this.emptyToolStripMenuItem.Click += new System.EventHandler(this.emptyToolStripMenuItem_Click);
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.randomToolStripMenuItem.Text = "Random";
            this.randomToolStripMenuItem.Click += new System.EventHandler(this.randomToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pPartPanel
            // 
            this.pPartPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPartPanel.Location = new System.Drawing.Point(12, 56);
            this.pPartPanel.Name = "pPartPanel";
            this.pPartPanel.Size = new System.Drawing.Size(208, 450);
            this.pPartPanel.TabIndex = 7;
            // 
            // StrukturaMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 518);
            this.Controls.Add(this.pPartPanel);
            this.Controls.Add(this.cPreset);
            this.Controls.Add(this.bRedraw);
            this.Controls.Add(this.nHeight);
            this.Controls.Add(this.nWidth);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StrukturaMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StrukturaMainForm_Load);
            this.Shown += new System.EventHandler(this.StrukturaMainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHeight)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pMain;
        private System.Windows.Forms.NumericUpDown nWidth;
        private System.Windows.Forms.NumericUpDown nHeight;
        private System.Windows.Forms.Button bRedraw;
        private System.Windows.Forms.ComboBox cPreset;
        private PartPanel pPartPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem structureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}