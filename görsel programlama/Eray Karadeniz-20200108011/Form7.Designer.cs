﻿
namespace Eray_Karadeniz_20200108011
{
    partial class Form7
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtÖgrAd = new System.Windows.Forms.TextBox();
            this.mskÖgrNo = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnÖgrGüncelle = new System.Windows.Forms.Button();
            this.btnÖgrSil = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnÖgrKaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.kytTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbBölüm = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Aqua;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dTarih, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtÖgrAd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mskÖgrNo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.kytTarih, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbBölüm, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblId, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 461);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dTarih
            // 
            this.dTarih.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTarih.Location = new System.Drawing.Point(398, 233);
            this.dTarih.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dTarih.Name = "dTarih";
            this.dTarih.Size = new System.Drawing.Size(380, 32);
            this.dTarih.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ad ve Soyad:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kayıt Tarihi:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrenci No:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 330);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bölüm:";
            // 
            // txtÖgrAd
            // 
            this.txtÖgrAd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtÖgrAd.Location = new System.Drawing.Point(398, 5);
            this.txtÖgrAd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtÖgrAd.Name = "txtÖgrAd";
            this.txtÖgrAd.Size = new System.Drawing.Size(380, 32);
            this.txtÖgrAd.TabIndex = 5;
            // 
            // mskÖgrNo
            // 
            this.mskÖgrNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mskÖgrNo.Location = new System.Drawing.Point(398, 157);
            this.mskÖgrNo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.mskÖgrNo.Mask = "00000000000";
            this.mskÖgrNo.Name = "mskÖgrNo";
            this.mskÖgrNo.Size = new System.Drawing.Size(380, 32);
            this.mskÖgrNo.TabIndex = 7;
            this.mskÖgrNo.ValidatingType = typeof(int);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnÖgrGüncelle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnÖgrSil, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(398, 385);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(380, 66);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // btnÖgrGüncelle
            // 
            this.btnÖgrGüncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnÖgrGüncelle.Location = new System.Drawing.Point(6, 5);
            this.btnÖgrGüncelle.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnÖgrGüncelle.Name = "btnÖgrGüncelle";
            this.btnÖgrGüncelle.Size = new System.Drawing.Size(178, 56);
            this.btnÖgrGüncelle.TabIndex = 0;
            this.btnÖgrGüncelle.Text = "Güncelle";
            this.btnÖgrGüncelle.UseVisualStyleBackColor = true;
            this.btnÖgrGüncelle.Click += new System.EventHandler(this.btnÖgrGüncelle_Click);
            // 
            // btnÖgrSil
            // 
            this.btnÖgrSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnÖgrSil.Location = new System.Drawing.Point(196, 5);
            this.btnÖgrSil.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnÖgrSil.Name = "btnÖgrSil";
            this.btnÖgrSil.Size = new System.Drawing.Size(178, 56);
            this.btnÖgrSil.TabIndex = 1;
            this.btnÖgrSil.Text = "Sil";
            this.btnÖgrSil.UseVisualStyleBackColor = true;
            this.btnÖgrSil.Click += new System.EventHandler(this.btnÖgrSil_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnÖgrKaydet, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 385);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(380, 66);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // btnÖgrKaydet
            // 
            this.btnÖgrKaydet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnÖgrKaydet.Location = new System.Drawing.Point(196, 5);
            this.btnÖgrKaydet.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnÖgrKaydet.Name = "btnÖgrKaydet";
            this.btnÖgrKaydet.Size = new System.Drawing.Size(178, 56);
            this.btnÖgrKaydet.TabIndex = 0;
            this.btnÖgrKaydet.Text = "Kaydet";
            this.btnÖgrKaydet.UseVisualStyleBackColor = true;
            this.btnÖgrKaydet.Click += new System.EventHandler(this.btnÖgrKaydet_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "İşlemler:";
            // 
            // kytTarih
            // 
            this.kytTarih.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kytTarih.Enabled = false;
            this.kytTarih.Location = new System.Drawing.Point(398, 81);
            this.kytTarih.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.kytTarih.Name = "kytTarih";
            this.kytTarih.Size = new System.Drawing.Size(380, 32);
            this.kytTarih.TabIndex = 12;
            // 
            // cmbBölüm
            // 
            this.cmbBölüm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBölüm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBölüm.FormattingEnabled = true;
            this.cmbBölüm.Location = new System.Drawing.Point(398, 309);
            this.cmbBölüm.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbBölüm.Name = "cmbBölüm";
            this.cmbBölüm.Size = new System.Drawing.Size(380, 31);
            this.cmbBölüm.TabIndex = 14;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.Location = new System.Drawing.Point(6, 456);
            this.lblId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 5);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "0";
            this.lblId.Visible = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.DateTimePicker dTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtÖgrAd;
        public System.Windows.Forms.MaskedTextBox mskÖgrNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnÖgrGüncelle;
        private System.Windows.Forms.Button btnÖgrSil;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnÖgrKaydet;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker kytTarih;
        public System.Windows.Forms.ComboBox cmbBölüm;
        public System.Windows.Forms.Label lblId;
    }
}