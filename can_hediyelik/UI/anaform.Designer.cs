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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TabPage = new TabControl();
            Musteriler = new TabPage();
            dataGridView1 = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnMusteriEkle = new ToolStripButton();
            btnMusteriDuzenle = new ToolStripButton();
            btnMusteriSil = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnMusteriBul = new ToolStripButton();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripLabel1 = new ToolStripLabel();
            Urunler = new TabPage();
            dataGridView2 = new DataGridView();
            toolStrip3 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            toolStripTextBox2 = new ToolStripTextBox();
            toolStripLabel2 = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            TabPage.SuspendLayout();
            Musteriler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            Urunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            toolStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // TabPage
            // 
            TabPage.Controls.Add(Musteriler);
            TabPage.Controls.Add(Urunler);
            TabPage.Dock = DockStyle.Fill;
            TabPage.Location = new Point(0, 0);
            TabPage.Name = "TabPage";
            TabPage.SelectedIndex = 0;
            TabPage.Size = new Size(683, 441);
            TabPage.TabIndex = 0;
            // 
            // Musteriler
            // 
            Musteriler.Controls.Add(dataGridView1);
            Musteriler.Controls.Add(toolStrip1);
            Musteriler.Location = new Point(4, 24);
            Musteriler.Name = "Musteriler";
            Musteriler.Padding = new Padding(3);
            Musteriler.Size = new Size(675, 413);
            Musteriler.TabIndex = 0;
            Musteriler.Text = "Musteriler";
            Musteriler.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(3, 34);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(669, 376);
            dataGridView1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnMusteriEkle, btnMusteriDuzenle, btnMusteriSil, toolStripSeparator1, btnMusteriBul, toolStripTextBox1, toolStripLabel1 });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(669, 31);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.Image = (Image)resources.GetObject("btnMusteriEkle.Image");
            btnMusteriEkle.ImageTransparentColor = Color.Magenta;
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Size = new Size(56, 28);
            btnMusteriEkle.Text = "Ekle";
            btnMusteriEkle.Click += btnMusteriEkle_Click;
            // 
            // btnMusteriDuzenle
            // 
            btnMusteriDuzenle.Image = (Image)resources.GetObject("btnMusteriDuzenle.Image");
            btnMusteriDuzenle.ImageTransparentColor = Color.Magenta;
            btnMusteriDuzenle.Name = "btnMusteriDuzenle";
            btnMusteriDuzenle.Size = new Size(77, 28);
            btnMusteriDuzenle.Text = "Düzenle";
            btnMusteriDuzenle.Click += btnMusteriDuzenle_Click;
            // 
            // btnMusteriSil
            // 
            btnMusteriSil.Image = (Image)resources.GetObject("btnMusteriSil.Image");
            btnMusteriSil.ImageTransparentColor = Color.Magenta;
            btnMusteriSil.Name = "btnMusteriSil";
            btnMusteriSil.Size = new Size(47, 28);
            btnMusteriSil.Text = "Sil";
            btnMusteriSil.Click += btnMusteriSil_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // btnMusteriBul
            // 
            btnMusteriBul.Alignment = ToolStripItemAlignment.Right;
            btnMusteriBul.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMusteriBul.Image = (Image)resources.GetObject("btnMusteriBul.Image");
            btnMusteriBul.ImageTransparentColor = Color.Magenta;
            btnMusteriBul.Name = "btnMusteriBul";
            btnMusteriBul.Size = new Size(28, 28);
            btnMusteriBul.Text = "toolStripButton1";
            btnMusteriBul.Click += btnMusteriBul_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Alignment = ToolStripItemAlignment.Right;
            toolStripTextBox1.BorderStyle = BorderStyle.FixedSingle;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 31);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(31, 28);
            toolStripLabel1.Text = "Ara :";
            // 
            // Urunler
            // 
            Urunler.Controls.Add(dataGridView2);
            Urunler.Controls.Add(toolStrip3);
            Urunler.Location = new Point(4, 24);
            Urunler.Name = "Urunler";
            Urunler.Padding = new Padding(3);
            Urunler.Size = new Size(675, 413);
            Urunler.TabIndex = 1;
            Urunler.Text = "Urunler";
            Urunler.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 34);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(669, 376);
            dataGridView2.TabIndex = 2;
            // 
            // toolStrip3
            // 
            toolStrip3.ImageScalingSize = new Size(24, 24);
            toolStrip3.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripSeparator2, toolStripButton4, toolStripTextBox2, toolStripLabel2 });
            toolStrip3.Location = new Point(3, 3);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Size = new Size(669, 31);
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
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(47, 28);
            toolStripButton3.Text = "Sil";
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
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 419);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(683, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 441);
            Controls.Add(statusStrip1);
            Controls.Add(TabPage);
            Name = "Form1";
            Text = "CAN Hediyelik";
            Load += Form1_Load;
            TabPage.ResumeLayout(false);
            Musteriler.ResumeLayout(false);
            Musteriler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            Urunler.ResumeLayout(false);
            Urunler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl TabPage;
        private TabPage Musteriler;
        private TabPage Urunler;
        private ToolStrip toolStrip1;
        private ToolStrip toolStrip2;
        private StatusStrip statusStrip1;
        private ToolStripButton btnMusteriSil;
        private ToolStripButton btnMusteriEkle;
        private ToolStripButton btnMusteriDuzenle;
        private DataGridView dataGridView1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripButton btnMusteriBul;
        private DataGridView dataGridView2;
        private ToolStrip toolStrip3;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton4;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripLabel toolStripLabel2;
    }
}