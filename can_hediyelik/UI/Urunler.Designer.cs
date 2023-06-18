namespace can_hediyelik.UI
{
    partial class Urunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urunler));
            Ürünler = new TabControl();
            tabPage1 = new TabPage();
            btnOk = new Button();
            btnCancel = new Button();
            dataGridView2 = new DataGridView();
            toolStrip3 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            toolStripTextBox2 = new ToolStripTextBox();
            toolStripLabel2 = new ToolStripLabel();
            Ürünler.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            toolStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // Ürünler
            // 
            Ürünler.Controls.Add(tabPage1);
            Ürünler.Dock = DockStyle.Fill;
            Ürünler.Location = new Point(0, 0);
            Ürünler.Name = "Ürünler";
            Ürünler.SelectedIndex = 0;
            Ürünler.Size = new Size(635, 360);
            Ürünler.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnOk);
            tabPage1.Controls.Add(btnCancel);
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(toolStrip3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(627, 332);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.Location = new Point(548, 301);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(71, 23);
            btnOk.TabIndex = 58;
            btnOk.Text = "Tamam";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(467, 301);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(71, 23);
            btnCancel.TabIndex = 57;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(-4, 37);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(831, 255);
            dataGridView2.TabIndex = 2;
            // 
            // toolStrip3
            // 
            toolStrip3.ImageScalingSize = new Size(24, 24);
            toolStrip3.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripSeparator2, toolStripButton4, toolStripTextBox2, toolStripLabel2 });
            toolStrip3.Location = new Point(3, 3);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Size = new Size(621, 31);
            toolStrip3.TabIndex = 1;
            toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(56, 28);
            toolStripButton1.Text = "Ekle";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(77, 28);
            toolStripButton2.Text = "Düzenle";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(47, 28);
            toolStripButton3.Text = "Sil";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 31);
            // 
            // toolStripButton4
            // 
            toolStripButton4.Alignment = ToolStripItemAlignment.Right;
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(28, 28);
            toolStripButton4.Text = "toolStripButton1";
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Alignment = ToolStripItemAlignment.Right;
            toolStripTextBox2.BorderStyle = BorderStyle.FixedSingle;
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 31);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(31, 28);
            toolStripLabel2.Text = "Ara :";
            // 
            // Urunler
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(635, 360);
            Controls.Add(Ürünler);
            Name = "Urunler";
            Text = "Urunler";
            Load += Urunler_Load;
            Ürünler.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Ürünler;
        private TabPage tabPage1;
        private DataGridView dataGridView2;
        private ToolStrip toolStrip3;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton4;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripLabel toolStripLabel2;
        private Button btnOk;
        private Button btnCancel;
    }
}