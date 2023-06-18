namespace can_hediyelik.UI
{
    partial class Müsteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Müsteriler));
            Musteriler = new TabPage();
            btnOk = new Button();
            btnCancel = new Button();
            dataGridView1 = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnMusteriEkle = new ToolStripButton();
            btnMusteriDuzenle = new ToolStripButton();
            btnMusteriSil = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnMusteriBul = new ToolStripButton();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripLabel1 = new ToolStripLabel();
            TabPage = new TabControl();
            Musteriler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            TabPage.SuspendLayout();
            SuspendLayout();
            // 
            // Musteriler
            // 
            Musteriler.Controls.Add(btnOk);
            Musteriler.Controls.Add(btnCancel);
            Musteriler.Controls.Add(dataGridView1);
            Musteriler.Controls.Add(toolStrip1);
            Musteriler.Location = new Point(4, 24);
            Musteriler.Name = "Musteriler";
            Musteriler.Padding = new Padding(3);
            Musteriler.Size = new Size(661, 345);
            Musteriler.TabIndex = 0;
            Musteriler.Text = "Musteriler";
            Musteriler.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.Location = new Point(582, 314);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(71, 23);
            btnOk.TabIndex = 56;
            btnOk.Text = "Tamam";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(501, 314);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(71, 23);
            btnCancel.TabIndex = 55;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(3, 34);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(662, 268);
            dataGridView1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnMusteriEkle, btnMusteriDuzenle, btnMusteriSil, toolStripSeparator1, btnMusteriBul, toolStripTextBox1, toolStripLabel1 });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(655, 31);
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
            // TabPage
            // 
            TabPage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabPage.Controls.Add(Musteriler);
            TabPage.Location = new Point(0, 0);
            TabPage.Name = "TabPage";
            TabPage.SelectedIndex = 0;
            TabPage.Size = new Size(669, 373);
            TabPage.TabIndex = 1;
            // 
            // Müsteriler
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(669, 373);
            Controls.Add(TabPage);
            Name = "Müsteriler";
            Text = "Müsteriler";
            Load += Müsteriler_Load;
            Musteriler.ResumeLayout(false);
            Musteriler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            TabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage Musteriler;
        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnMusteriEkle;
        private ToolStripButton btnMusteriDuzenle;
        private ToolStripButton btnMusteriSil;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnMusteriBul;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripLabel toolStripLabel1;
        private TabControl TabPage;
        private Button btnOk;
        private Button btnCancel;
    }
}