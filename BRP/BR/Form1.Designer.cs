namespace BR
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dotButton = new System.Windows.Forms.ToolStripButton();
            this.polyButton = new System.Windows.Forms.ToolStripButton();
            this.expandButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbCornerType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmbExpand = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cmbColor = new System.Windows.Forms.ToolStripComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dotButton,
            this.polyButton,
            this.expandButton,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.cmbCornerType,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.cmbExpand,
            this.toolStripLabel3,
            this.cmbColor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1300, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dotButton
            // 
            this.dotButton.Image = ((System.Drawing.Image)(resources.GetObject("dotButton.Image")));
            this.dotButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(58, 25);
            this.dotButton.Text = "Dot";
            this.dotButton.Click += new System.EventHandler(this.dotButton_Click);
            // 
            // polyButton
            // 
            this.polyButton.Image = ((System.Drawing.Image)(resources.GetObject("polyButton.Image")));
            this.polyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.polyButton.Name = "polyButton";
            this.polyButton.Size = new System.Drawing.Size(86, 25);
            this.polyButton.Text = "Polygon";
            this.polyButton.Click += new System.EventHandler(this.polyButton_Click);
            // 
            // expandButton
            // 
            this.expandButton.Image = ((System.Drawing.Image)(resources.GetObject("expandButton.Image")));
            this.expandButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.expandButton.Name = "expandButton";
            this.expandButton.Size = new System.Drawing.Size(82, 25);
            this.expandButton.Text = "Expand";
            this.expandButton.Click += new System.EventHandler(this.expandButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(91, 25);
            this.toolStripLabel1.Text = "Corner Type:";
            // 
            // cmbCornerType
            // 
            this.cmbCornerType.Items.AddRange(new object[] {
            "Miter",
            "Round",
            "Square"});
            this.cmbCornerType.Name = "cmbCornerType";
            this.cmbCornerType.Size = new System.Drawing.Size(160, 28);
            this.cmbCornerType.SelectedIndexChanged += new System.EventHandler(this.cmbCornerType_SelectedIndexChanged);
            this.cmbCornerType.Click += new System.EventHandler(this.cmbCornerType_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(74, 25);
            this.toolStripLabel2.Text = "Thickness:";
            // 
            // cmbExpand
            // 
            this.cmbExpand.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25"});
            this.cmbExpand.Name = "cmbExpand";
            this.cmbExpand.Size = new System.Drawing.Size(160, 28);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(45, 25);
            this.toolStripLabel3.Text = "Color";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // cmbColor
            // 
            this.cmbColor.Items.AddRange(new object[] {
            "Red",
            "Black",
            "Green",
            "Blue"});
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(160, 28);
            this.cmbColor.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1300, 661);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 689);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton dotButton;
        private System.Windows.Forms.ToolStripButton polyButton;
        private System.Windows.Forms.ToolStripButton expandButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripComboBox cmbCornerType;
        private System.Windows.Forms.ToolStripComboBox cmbExpand;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmbColor;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
    }
}

