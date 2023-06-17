namespace can_hediyelik.UI
{
    partial class FrmOdeme
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
            components = new System.ComponentModel.Container();
            dtTarih = new DateTimePicker();
            nmTutar = new NumericUpDown();
            btnOk = new Button();
            btnCancel = new Button();
            txtUrunDetay = new Label();
            txtUrunStok = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            txtAciklama = new TextBox();
            label6 = new Label();
            label3 = new Label();
            cbOdemeTuru = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nmTutar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dtTarih
            // 
            dtTarih.Location = new Point(79, 70);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new Size(193, 23);
            dtTarih.TabIndex = 69;
            // 
            // nmTutar
            // 
            nmTutar.DecimalPlaces = 2;
            nmTutar.Location = new Point(79, 99);
            nmTutar.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmTutar.Name = "nmTutar";
            nmTutar.ReadOnly = true;
            nmTutar.Size = new Size(193, 23);
            nmTutar.TabIndex = 67;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(197, 253);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 66;
            btnOk.Text = "Tamam";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(116, 253);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 65;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtUrunDetay
            // 
            txtUrunDetay.AutoSize = true;
            txtUrunDetay.Location = new Point(44, 76);
            txtUrunDetay.Name = "txtUrunDetay";
            txtUrunDetay.Size = new Size(32, 15);
            txtUrunDetay.TabIndex = 64;
            txtUrunDetay.Text = "Tarih";
            // 
            // txtUrunStok
            // 
            txtUrunStok.AutoSize = true;
            txtUrunStok.Location = new Point(42, 102);
            txtUrunStok.Name = "txtUrunStok";
            txtUrunStok.Size = new Size(34, 15);
            txtUrunStok.TabIndex = 63;
            txtUrunStok.Text = "Tutar";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(79, 41);
            txtAd.Name = "txtAd";
            txtAd.ReadOnly = true;
            txtAd.Size = new Size(193, 23);
            txtAd.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 45);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 60;
            label2.Text = "Müsteri";
            // 
            // txtID
            // 
            txtID.Location = new Point(79, 12);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(193, 23);
            txtID.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 16);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 58;
            label1.Text = "ID";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(82, 161);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(190, 73);
            txtAciklama.TabIndex = 71;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 164);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 70;
            label6.Text = "Aciklama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 135);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 72;
            label3.Text = "Odeme Turu";
            // 
            // cbOdemeTuru
            // 
            cbOdemeTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOdemeTuru.FormattingEnabled = true;
            cbOdemeTuru.Items.AddRange(new object[] { "Nakit", "Kredi Karti", "Havale/EFT" });
            cbOdemeTuru.Location = new Point(79, 132);
            cbOdemeTuru.Name = "cbOdemeTuru";
            cbOdemeTuru.Size = new Size(193, 23);
            cbOdemeTuru.TabIndex = 73;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmOdeme
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(311, 325);
            Controls.Add(cbOdemeTuru);
            Controls.Add(label3);
            Controls.Add(txtAciklama);
            Controls.Add(label6);
            Controls.Add(dtTarih);
            Controls.Add(nmTutar);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Controls.Add(txtUrunDetay);
            Controls.Add(txtUrunStok);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmOdeme";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmOdeme";
            ((System.ComponentModel.ISupportInitialize)nmTutar).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtTarih;
        private NumericUpDown nmTutar;
        private Button btnOk;
        private Button btnCancel;
        private Label txtUrunDetay;
        private Label txtUrunStok;
        private TextBox txtAd;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private TextBox txtAciklama;
        private Label label6;
        private Label label3;
        private ComboBox cbOdemeTuru;
        private ErrorProvider errorProvider1;
    }
}