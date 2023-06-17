﻿namespace can_hediyelik.UI
{
    partial class FrmUrun
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
            txtdetay = new TextBox();
            txtUrunDetay = new Label();
            txtUrunStok = new Label();
            txtUrunFiyat = new Label();
            txtUrun = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            nmfiyat = new NumericUpDown();
            nmStok = new NumericUpDown();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nmfiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(262, 268);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 42;
            btnOk.Text = "Tamam";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(181, 268);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtdetay
            // 
            txtdetay.Location = new Point(63, 136);
            txtdetay.Multiline = true;
            txtdetay.Name = "txtdetay";
            txtdetay.Size = new Size(274, 126);
            txtdetay.TabIndex = 39;
            // 
            // txtUrunDetay
            // 
            txtUrunDetay.AutoSize = true;
            txtUrunDetay.Location = new Point(10, 139);
            txtUrunDetay.Name = "txtUrunDetay";
            txtUrunDetay.Size = new Size(37, 15);
            txtUrunDetay.TabIndex = 38;
            txtUrunDetay.Text = "Detay";
            // 
            // txtUrunStok
            // 
            txtUrunStok.AutoSize = true;
            txtUrunStok.Location = new Point(17, 107);
            txtUrunStok.Name = "txtUrunStok";
            txtUrunStok.Size = new Size(30, 15);
            txtUrunStok.TabIndex = 35;
            txtUrunStok.Text = "Stok";
            // 
            // txtUrunFiyat
            // 
            txtUrunFiyat.AutoSize = true;
            txtUrunFiyat.Location = new Point(15, 79);
            txtUrunFiyat.Name = "txtUrunFiyat";
            txtUrunFiyat.Size = new Size(32, 15);
            txtUrunFiyat.TabIndex = 33;
            txtUrunFiyat.Text = "Fiyat";
            // 
            // txtUrun
            // 
            txtUrun.Location = new Point(63, 47);
            txtUrun.Name = "txtUrun";
            txtUrun.Size = new Size(274, 23);
            txtUrun.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 50);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 31;
            label2.Text = "Ad";
            // 
            // txtID
            // 
            txtID.Location = new Point(63, 18);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(274, 23);
            txtID.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 21);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 29;
            label1.Text = "ID";
            // 
            // nmfiyat
            // 
            nmfiyat.DecimalPlaces = 2;
            nmfiyat.Location = new Point(63, 77);
            nmfiyat.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmfiyat.Name = "nmfiyat";
            nmfiyat.Size = new Size(274, 23);
            nmfiyat.TabIndex = 43;
            // 
            // nmStok
            // 
            nmStok.Location = new Point(63, 107);
            nmStok.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmStok.Name = "nmStok";
            nmStok.Size = new Size(274, 23);
            nmStok.TabIndex = 44;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmUrun
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(355, 308);
            Controls.Add(nmStok);
            Controls.Add(nmfiyat);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Controls.Add(txtdetay);
            Controls.Add(txtUrunDetay);
            Controls.Add(txtUrunStok);
            Controls.Add(txtUrunFiyat);
            Controls.Add(txtUrun);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmUrun";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmUrun";
            ((System.ComponentModel.ISupportInitialize)nmfiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Button btnCancel;
        private TextBox txtdetay;
        private Label txtUrunDetay;
        private Label txtUrunStok;
        private Label txtUrunFiyat;
        private TextBox txtUrun;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private NumericUpDown nmfiyat;
        private NumericUpDown nmStok;
        private ErrorProvider errorProvider1;
    }
}