namespace can_hediyelik.UI
{
    partial class FrmMusteri
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
            btnOk = new Button();
            btnCancel = new Button();
            txtTel = new MaskedTextBox();
            txtAdres = new TextBox();
            label6 = new Label();
            txtMail = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtSoyad = new TextBox();
            label3 = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(267, 306);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 28;
            btnOk.Text = "Tamam";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(186, 306);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(68, 101);
            txtTel.Mask = "(999) 000-0000";
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(274, 23);
            txtTel.TabIndex = 26;
            txtTel.MaskInputRejected += txtTel_MaskInputRejected;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(68, 159);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(274, 126);
            txtAdres.TabIndex = 25;
            txtAdres.TextChanged += txtAdres_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 162);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 24;
            label6.Text = "Adres";
            label6.Click += label6_Click;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(68, 130);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(274, 23);
            txtMail.TabIndex = 23;
            txtMail.TextChanged += txtMail_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 133);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 22;
            label4.Text = "Mail";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 103);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 21;
            label5.Text = "Telefon";
            label5.Click += label5_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(68, 72);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(274, 23);
            txtSoyad.TabIndex = 20;
            txtSoyad.TextChanged += txtSoyad_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 75);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 19;
            label3.Text = "Soyad";
            label3.Click += label3_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(68, 43);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(274, 23);
            txtAd.TabIndex = 18;
            txtAd.TextChanged += txtAd_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 46);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 17;
            label2.Text = "Ad";
            label2.Click += label2_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(68, 14);
            txtID.Name = "txtID";
            txtID.Size = new Size(274, 23);
            txtID.TabIndex = 16;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 17);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 15;
            label1.Text = "TC. NO";
            label1.Click += label1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmMusteri
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(365, 354);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Controls.Add(txtTel);
            Controls.Add(txtAdres);
            Controls.Add(label6);
            Controls.Add(txtMail);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtSoyad);
            Controls.Add(label3);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmMusteri";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmUrun";
            Load += FrmMusteri_Load_1;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Button btnCancel;
        private MaskedTextBox txtTel;
        private TextBox txtAdres;
        private Label label6;
        private TextBox txtMail;
        private Label label4;
        private Label label5;
        private TextBox txtSoyad;
        private Label label3;
        private TextBox txtAd;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}