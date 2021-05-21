
namespace SevkiyatTakipUI
{
    partial class SevkiyatGiris
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
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.cmbArac = new System.Windows.Forms.ComboBox();
            this.cmbYuklemeTip = new System.Windows.Forms.ComboBox();
            this.txtSiparisNo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtLojistikFirma = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPlakaNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numAdet = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(100, 81);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(268, 21);
            this.cmbMusteri.TabIndex = 2;
            this.cmbMusteri.Leave += new System.EventHandler(this.cmbMusteri_Leave);
            // 
            // cmbArac
            // 
            this.cmbArac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArac.FormattingEnabled = true;
            this.cmbArac.Location = new System.Drawing.Point(100, 148);
            this.cmbArac.Name = "cmbArac";
            this.cmbArac.Size = new System.Drawing.Size(121, 21);
            this.cmbArac.TabIndex = 4;
            // 
            // cmbYuklemeTip
            // 
            this.cmbYuklemeTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYuklemeTip.FormattingEnabled = true;
            this.cmbYuklemeTip.Location = new System.Drawing.Point(100, 215);
            this.cmbYuklemeTip.Name = "cmbYuklemeTip";
            this.cmbYuklemeTip.Size = new System.Drawing.Size(121, 21);
            this.cmbYuklemeTip.TabIndex = 6;
            // 
            // txtSiparisNo
            // 
            this.txtSiparisNo.Location = new System.Drawing.Point(100, 48);
            this.txtSiparisNo.Name = "txtSiparisNo";
            this.txtSiparisNo.Size = new System.Drawing.Size(100, 20);
            this.txtSiparisNo.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(100, 282);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(240, 74);
            this.txtAciklama.TabIndex = 8;
            // 
            // txtLojistikFirma
            // 
            this.txtLojistikFirma.Location = new System.Drawing.Point(100, 249);
            this.txtLojistikFirma.Name = "txtLojistikFirma";
            this.txtLojistikFirma.Size = new System.Drawing.Size(178, 20);
            this.txtLojistikFirma.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(265, 371);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Termin Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sipariş No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Müşteri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Araç";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(8, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Yükleme Tip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lojistik";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(8, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Açıklama";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPlakaNo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.numAdet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbMusteri);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbArac);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbYuklemeTip);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSiparisNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAciklama);
            this.panel1.Controls.Add(this.txtLojistikFirma);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 423);
            this.panel1.TabIndex = 16;
            // 
            // txtPlakaNo
            // 
            this.txtPlakaNo.Location = new System.Drawing.Point(100, 182);
            this.txtPlakaNo.Name = "txtPlakaNo";
            this.txtPlakaNo.Size = new System.Drawing.Size(100, 20);
            this.txtPlakaNo.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(8, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Plaka No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(9, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Adet";
            // 
            // numAdet
            // 
            this.numAdet.Location = new System.Drawing.Point(100, 115);
            this.numAdet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAdet.Name = "numAdet";
            this.numAdet.Size = new System.Drawing.Size(120, 20);
            this.numAdet.TabIndex = 3;
            // 
            // SevkiyatGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 447);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SevkiyatGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SevkiyatGiris";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SevkiyatGiris_FormClosed);
            this.Load += new System.EventHandler(this.SevkiyatGiris_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox cmbArac;
        private System.Windows.Forms.ComboBox cmbYuklemeTip;
        private System.Windows.Forms.TextBox txtSiparisNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtLojistikFirma;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numAdet;
        private System.Windows.Forms.TextBox txtPlakaNo;
        private System.Windows.Forms.Label label10;
    }
}