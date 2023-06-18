namespace can_hediyelik.UI
{
    partial class FrmSatis
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
            nmFiyat = new NumericUpDown();
            btnOk = new Button();
            btnCancel = new Button();
            txtUrunDetay = new Label();
            txtUrunStok = new Label();
            txtUrunFiyat = new Label();
            txtMusteri = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            dtTarih = new DateTimePicker();
            errorProvider1 = new ErrorProvider(components);
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)nmFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // nmFiyat
            // 
            nmFiyat.DecimalPlaces = 2;
            nmFiyat.Location = new Point(62, 100);
            nmFiyat.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmFiyat.Name = "nmFiyat";
            nmFiyat.Size = new Size(193, 23);
            nmFiyat.TabIndex = 55;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(180, 168);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 54;
            btnOk.Text = "Tamam";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(99, 168);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 53;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtUrunDetay
            // 
            txtUrunDetay.AutoSize = true;
            txtUrunDetay.Location = new Point(24, 135);
            txtUrunDetay.Name = "txtUrunDetay";
            txtUrunDetay.Size = new Size(32, 15);
            txtUrunDetay.TabIndex = 51;
            txtUrunDetay.Text = "Tarih";
            // 
            // txtUrunStok
            // 
            txtUrunStok.AutoSize = true;
            txtUrunStok.Location = new Point(24, 103);
            txtUrunStok.Name = "txtUrunStok";
            txtUrunStok.Size = new Size(32, 15);
            txtUrunStok.TabIndex = 50;
            txtUrunStok.Text = "Fiyat";
            // 
            // txtUrunFiyat
            // 
            txtUrunFiyat.AutoSize = true;
            txtUrunFiyat.Location = new Point(23, 75);
            txtUrunFiyat.Name = "txtUrunFiyat";
            txtUrunFiyat.Size = new Size(33, 15);
            txtUrunFiyat.TabIndex = 49;
            txtUrunFiyat.Text = "Ürün";
            // 
            // txtMusteri
            // 
            txtMusteri.Location = new Point(62, 42);
            txtMusteri.Name = "txtMusteri";
            txtMusteri.ReadOnly = true;
            txtMusteri.Size = new Size(193, 23);
            txtMusteri.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 46);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 47;
            label2.Text = "Müsteri";
            // 
            // txtID
            // 
            txtID.Location = new Point(62, 13);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(193, 23);
            txtID.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 17);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 45;
            label1.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 71);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 56;
            // 
            // dtTarih
            // 
            dtTarih.Location = new Point(62, 129);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new Size(193, 23);
            dtTarih.TabIndex = 57;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            button1.Location = new Point(261, 42);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 58;
            button1.Text = "Müşteri Seç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(261, 71);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 59;
            button2.Text = "Ürün Seç";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmSatis
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(389, 214);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtTarih);
            Controls.Add(textBox1);
            Controls.Add(nmFiyat);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Controls.Add(txtUrunDetay);
            Controls.Add(txtUrunStok);
            Controls.Add(txtUrunFiyat);
            Controls.Add(txtMusteri);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmSatis";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmSatis";
            Load += FrmSatis_Load;
            ((System.ComponentModel.ISupportInitialize)nmFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown nmFiyat;
        private Button btnOk;
        private Button btnCancel;
        private Label txtUrunDetay;
        private Label txtUrunStok;
        private Label txtUrunFiyat;
        private TextBox txtMusteri;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private TextBox textBox1;
        private DateTimePicker dtTarih;
        private ErrorProvider errorProvider1;
        private Button button2;
        private Button button1;
    }
}