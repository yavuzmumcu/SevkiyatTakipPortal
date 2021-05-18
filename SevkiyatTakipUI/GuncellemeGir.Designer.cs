
namespace SevkiyatTakipUI
{
    partial class GuncellemeGir
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
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.lblSevkiyatId = new System.Windows.Forms.Label();
            this.dgvSevkiyatGuncellemeleri = new System.Windows.Forms.DataGridView();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSevkiyatGuncellemeleri)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(77, 128);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(288, 112);
            this.txtAciklama.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(290, 294);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(77, 246);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(121, 21);
            this.cmbDurum.TabIndex = 2;
            // 
            // lblSevkiyatId
            // 
            this.lblSevkiyatId.AutoSize = true;
            this.lblSevkiyatId.Location = new System.Drawing.Point(152, 27);
            this.lblSevkiyatId.Name = "lblSevkiyatId";
            this.lblSevkiyatId.Size = new System.Drawing.Size(35, 13);
            this.lblSevkiyatId.TabIndex = 3;
            this.lblSevkiyatId.Text = "label1";
            // 
            // dgvSevkiyatGuncellemeleri
            // 
            this.dgvSevkiyatGuncellemeleri.AllowUserToAddRows = false;
            this.dgvSevkiyatGuncellemeleri.AllowUserToDeleteRows = false;
            this.dgvSevkiyatGuncellemeleri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSevkiyatGuncellemeleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSevkiyatGuncellemeleri.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSevkiyatGuncellemeleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSevkiyatGuncellemeleri.Location = new System.Drawing.Point(439, 13);
            this.dgvSevkiyatGuncellemeleri.Name = "dgvSevkiyatGuncellemeleri";
            this.dgvSevkiyatGuncellemeleri.ReadOnly = true;
            this.dgvSevkiyatGuncellemeleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSevkiyatGuncellemeleri.Size = new System.Drawing.Size(633, 338);
            this.dgvSevkiyatGuncellemeleri.TabIndex = 4;
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Location = new System.Drawing.Point(152, 58);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(64, 13);
            this.lblMusteriAd.TabIndex = 5;
            this.lblMusteriAd.Text = "lblMusteriAd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Müşteri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sevkiyat ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Durum";
            // 
            // GuncellemeGir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 363);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMusteriAd);
            this.Controls.Add(this.dgvSevkiyatGuncellemeleri);
            this.Controls.Add(this.lblSevkiyatId);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAciklama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuncellemeGir";
            this.Text = "GuncellemeGir";
            this.Load += new System.EventHandler(this.GuncellemeGir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSevkiyatGuncellemeleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Label lblSevkiyatId;
        private System.Windows.Forms.DataGridView dgvSevkiyatGuncellemeleri;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}