namespace Monostruktura
{
    partial class PartPanel
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
            this.pParent = new System.Windows.Forms.Panel();
            this.bParent = new System.Windows.Forms.Button();
            this.pControls = new System.Windows.Forms.Panel();
            this.bCore = new System.Windows.Forms.Button();
            this.pParent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pParent
            // 
            this.pParent.Controls.Add(this.bCore);
            this.pParent.Controls.Add(this.bParent);
            this.pParent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pParent.Location = new System.Drawing.Point(0, 0);
            this.pParent.Name = "pParent";
            this.pParent.Size = new System.Drawing.Size(279, 30);
            this.pParent.TabIndex = 0;
            // 
            // bParent
            // 
            this.bParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bParent.Location = new System.Drawing.Point(52, 3);
            this.bParent.Name = "bParent";
            this.bParent.Size = new System.Drawing.Size(224, 23);
            this.bParent.TabIndex = 0;
            this.bParent.Text = "Parent";
            this.bParent.UseVisualStyleBackColor = true;
            this.bParent.Click += new System.EventHandler(this.bParent_Click);
            // 
            // pControls
            // 
            this.pControls.AutoScroll = true;
            this.pControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pControls.Location = new System.Drawing.Point(0, 30);
            this.pControls.Name = "pControls";
            this.pControls.Size = new System.Drawing.Size(279, 283);
            this.pControls.TabIndex = 1;
            // 
            // bCore
            // 
            this.bCore.Location = new System.Drawing.Point(3, 3);
            this.bCore.Name = "bCore";
            this.bCore.Size = new System.Drawing.Size(43, 23);
            this.bCore.TabIndex = 1;
            this.bCore.Text = "Core";
            this.bCore.UseVisualStyleBackColor = true;
            this.bCore.Click += new System.EventHandler(this.bCore_Click);
            // 
            // PartPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pControls);
            this.Controls.Add(this.pParent);
            this.Name = "PartPanel";
            this.Size = new System.Drawing.Size(279, 313);
            this.pParent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pParent;
        private System.Windows.Forms.Button bCore;
        private System.Windows.Forms.Button bParent;
        private System.Windows.Forms.Panel pControls;
    }
}
