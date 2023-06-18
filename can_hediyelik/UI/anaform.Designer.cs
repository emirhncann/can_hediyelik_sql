namespace can_hediyelik
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            statusStrip1 = new StatusStrip();
            ımageList1 = new ImageList(components);
            toolStrip1 = new ToolStrip();
            toolStripSplitButton1 = new ToolStripSplitButton();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripSeparator3 = new ToolStripSeparator();
            btnMusteriler = new ToolStripSplitButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSplitButton3 = new ToolStripSplitButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSplitButton4 = new ToolStripSplitButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripSplitButton5 = new ToolStripSplitButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 419);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(683, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageSize = new Size(16, 16);
            ımageList1.TransparentColor = Color.Transparent;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSplitButton1, toolStripSeparator6, toolStripSeparator5, toolStripSeparator3, btnMusteriler, toolStripSeparator1, toolStripSplitButton3, toolStripSeparator2, toolStripSplitButton4, toolStripSeparator4, toolStripSplitButton5 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(683, 39);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(16, 36);
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 39);
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 39);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 39);
            // 
            // btnMusteriler
            // 
            btnMusteriler.Image = (Image)resources.GetObject("btnMusteriler.Image");
            btnMusteriler.ImageTransparentColor = Color.Magenta;
            btnMusteriler.Name = "btnMusteriler";
            btnMusteriler.Size = new Size(108, 36);
            btnMusteriler.Text = "Müşteriler";
            btnMusteriler.ButtonClick += btnMusteriler_ButtonClick;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // toolStripSplitButton3
            // 
            toolStripSplitButton3.Image = (Image)resources.GetObject("toolStripSplitButton3.Image");
            toolStripSplitButton3.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton3.Name = "toolStripSplitButton3";
            toolStripSplitButton3.Size = new Size(94, 36);
            toolStripSplitButton3.Text = "Ürünler";
            toolStripSplitButton3.ButtonClick += toolStripSplitButton3_ButtonClick;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 39);
            // 
            // toolStripSplitButton4
            // 
            toolStripSplitButton4.Image = (Image)resources.GetObject("toolStripSplitButton4.Image");
            toolStripSplitButton4.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton4.Name = "toolStripSplitButton4";
            toolStripSplitButton4.Size = new Size(92, 36);
            toolStripSplitButton4.Text = "Satışlar";
            toolStripSplitButton4.ButtonClick += toolStripSplitButton4_ButtonClick;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 39);
            // 
            // toolStripSplitButton5
            // 
            toolStripSplitButton5.Image = (Image)resources.GetObject("toolStripSplitButton5.Image");
            toolStripSplitButton5.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton5.Name = "toolStripSplitButton5";
            toolStripSplitButton5.Size = new Size(107, 36);
            toolStripSplitButton5.Text = "Ödemeler";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 441);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Name = "Form1";
            Text = "CAN Hediyelik";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip2;
        private StatusStrip statusStrip1;
        private ImageList ımageList1;
        private ToolStrip toolStrip1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSplitButton btnMusteriler;
        private ToolStripSplitButton toolStripSplitButton3;
        private ToolStripSplitButton toolStripSplitButton4;
        private ToolStripSplitButton toolStripSplitButton5;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator4;
    }
}