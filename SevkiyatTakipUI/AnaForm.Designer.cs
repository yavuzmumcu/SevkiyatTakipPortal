
namespace SevkiyatTakipUI
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnYeniSevkiyat = new System.Windows.Forms.Button();
            this.btnGunlukGorunum = new System.Windows.Forms.Button();
            this.btnHaftalikGorunum = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGun = new System.Windows.Forms.ComboBox();
            this.cmbHafta = new System.Windows.Forms.ComboBox();
            this.cmbYil = new System.Windows.Forms.ComboBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.icerikPanel = new System.Windows.Forms.Panel();
            this.tLPanelIcerik = new System.Windows.Forms.TableLayoutPanel();
            this.panelUst = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblYil = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHafta = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGun = new System.Windows.Forms.Label();
            this.panelAlt = new System.Windows.Forms.Panel();
            this.dgvSevkiyatlar = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.icerikPanel.SuspendLayout();
            this.tLPanelIcerik.SuspendLayout();
            this.panelUst.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSevkiyatlar)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.headerPanel.Controls.Add(this.btnDuzenle);
            this.headerPanel.Controls.Add(this.pictureBox1);
            this.headerPanel.Controls.Add(this.btnYeniSevkiyat);
            this.headerPanel.Controls.Add(this.btnGunlukGorunum);
            this.headerPanel.Controls.Add(this.btnHaftalikGorunum);
            this.headerPanel.Controls.Add(this.label3);
            this.headerPanel.Controls.Add(this.label2);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.cmbGun);
            this.headerPanel.Controls.Add(this.cmbHafta);
            this.headerPanel.Controls.Add(this.cmbYil);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(3, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1178, 94);
            this.headerPanel.TabIndex = 0;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(954, 50);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(100, 23);
            this.btnDuzenle.TabIndex = 10;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnYeniSevkiyat
            // 
            this.btnYeniSevkiyat.Location = new System.Drawing.Point(954, 12);
            this.btnYeniSevkiyat.Name = "btnYeniSevkiyat";
            this.btnYeniSevkiyat.Size = new System.Drawing.Size(100, 23);
            this.btnYeniSevkiyat.TabIndex = 8;
            this.btnYeniSevkiyat.Text = "YENİ SEVKİYAT";
            this.btnYeniSevkiyat.UseVisualStyleBackColor = true;
            this.btnYeniSevkiyat.Click += new System.EventHandler(this.btnYeniSevkiyat_Click);
            // 
            // btnGunlukGorunum
            // 
            this.btnGunlukGorunum.Location = new System.Drawing.Point(382, 59);
            this.btnGunlukGorunum.Name = "btnGunlukGorunum";
            this.btnGunlukGorunum.Size = new System.Drawing.Size(112, 23);
            this.btnGunlukGorunum.TabIndex = 7;
            this.btnGunlukGorunum.Text = "Günlük Görünüm";
            this.btnGunlukGorunum.UseVisualStyleBackColor = true;
            this.btnGunlukGorunum.Click += new System.EventHandler(this.btnGunlukGorunum_Click);
            // 
            // btnHaftalikGorunum
            // 
            this.btnHaftalikGorunum.Location = new System.Drawing.Point(263, 59);
            this.btnHaftalikGorunum.Name = "btnHaftalikGorunum";
            this.btnHaftalikGorunum.Size = new System.Drawing.Size(100, 23);
            this.btnHaftalikGorunum.TabIndex = 6;
            this.btnHaftalikGorunum.Text = "Haftalık Görünüm";
            this.btnHaftalikGorunum.UseVisualStyleBackColor = true;
            this.btnHaftalikGorunum.Click += new System.EventHandler(this.btnHaftalikGorunum_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hafta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yıl";
            // 
            // cmbGun
            // 
            this.cmbGun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGun.FormattingEnabled = true;
            this.cmbGun.Location = new System.Drawing.Point(521, 12);
            this.cmbGun.Name = "cmbGun";
            this.cmbGun.Size = new System.Drawing.Size(84, 21);
            this.cmbGun.TabIndex = 2;
            // 
            // cmbHafta
            // 
            this.cmbHafta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHafta.FormattingEnabled = true;
            this.cmbHafta.Location = new System.Drawing.Point(392, 14);
            this.cmbHafta.Name = "cmbHafta";
            this.cmbHafta.Size = new System.Drawing.Size(84, 21);
            this.cmbHafta.TabIndex = 1;
            // 
            // cmbYil
            // 
            this.cmbYil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYil.FormattingEnabled = true;
            this.cmbYil.Items.AddRange(new object[] {
            "2021"});
            this.cmbYil.Location = new System.Drawing.Point(263, 14);
            this.cmbYil.Name = "cmbYil";
            this.cmbYil.Size = new System.Drawing.Size(84, 21);
            this.cmbYil.TabIndex = 0;
            // 
            // btnExcel
            // 
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(435, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(71, 31);
            this.btnExcel.TabIndex = 10;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // icerikPanel
            // 
            this.icerikPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.icerikPanel.Controls.Add(this.tLPanelIcerik);
            this.icerikPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icerikPanel.Location = new System.Drawing.Point(3, 103);
            this.icerikPanel.Name = "icerikPanel";
            this.icerikPanel.Size = new System.Drawing.Size(1178, 556);
            this.icerikPanel.TabIndex = 1;
            // 
            // tLPanelIcerik
            // 
            this.tLPanelIcerik.BackColor = System.Drawing.Color.Silver;
            this.tLPanelIcerik.ColumnCount = 1;
            this.tLPanelIcerik.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanelIcerik.Controls.Add(this.panelUst, 0, 0);
            this.tLPanelIcerik.Controls.Add(this.panelAlt, 0, 2);
            this.tLPanelIcerik.Controls.Add(this.dgvSevkiyatlar, 0, 1);
            this.tLPanelIcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPanelIcerik.Location = new System.Drawing.Point(0, 0);
            this.tLPanelIcerik.Name = "tLPanelIcerik";
            this.tLPanelIcerik.RowCount = 3;
            this.tLPanelIcerik.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tLPanelIcerik.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanelIcerik.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tLPanelIcerik.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPanelIcerik.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPanelIcerik.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPanelIcerik.Size = new System.Drawing.Size(1178, 556);
            this.tLPanelIcerik.TabIndex = 1;
            // 
            // panelUst
            // 
            this.panelUst.BackColor = System.Drawing.Color.Moccasin;
            this.panelUst.Controls.Add(this.flowLayoutPanel1);
            this.panelUst.Controls.Add(this.btnExcel);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUst.Location = new System.Drawing.Point(3, 3);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(1172, 35);
            this.panelUst.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.lblYil);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.lblHafta);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.lblGun);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(414, 35);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yıl:";
            // 
            // lblYil
            // 
            this.lblYil.AutoSize = true;
            this.lblYil.BackColor = System.Drawing.Color.Transparent;
            this.lblYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYil.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblYil.Location = new System.Drawing.Point(44, 0);
            this.lblYil.Name = "lblYil";
            this.lblYil.Size = new System.Drawing.Size(60, 24);
            this.lblYil.TabIndex = 2;
            this.lblYil.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(110, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Hafta:";
            // 
            // lblHafta
            // 
            this.lblHafta.AutoSize = true;
            this.lblHafta.BackColor = System.Drawing.Color.Transparent;
            this.lblHafta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHafta.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblHafta.Location = new System.Drawing.Point(173, 0);
            this.lblHafta.Name = "lblHafta";
            this.lblHafta.Size = new System.Drawing.Size(52, 24);
            this.lblHafta.TabIndex = 4;
            this.lblHafta.Text = "Hafta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(231, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Gün:";
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.BackColor = System.Drawing.Color.Transparent;
            this.lblGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGun.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblGun.Location = new System.Drawing.Point(288, 0);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(52, 24);
            this.lblGun.TabIndex = 6;
            this.lblGun.Text = "Hafta";
            // 
            // panelAlt
            // 
            this.panelAlt.BackColor = System.Drawing.Color.Gainsboro;
            this.panelAlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlt.Location = new System.Drawing.Point(3, 504);
            this.panelAlt.Name = "panelAlt";
            this.panelAlt.Size = new System.Drawing.Size(1172, 49);
            this.panelAlt.TabIndex = 2;
            // 
            // dgvSevkiyatlar
            // 
            this.dgvSevkiyatlar.AllowUserToAddRows = false;
            this.dgvSevkiyatlar.AllowUserToDeleteRows = false;
            this.dgvSevkiyatlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSevkiyatlar.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSevkiyatlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSevkiyatlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSevkiyatlar.Location = new System.Drawing.Point(3, 44);
            this.dgvSevkiyatlar.Name = "dgvSevkiyatlar";
            this.dgvSevkiyatlar.ReadOnly = true;
            this.dgvSevkiyatlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSevkiyatlar.Size = new System.Drawing.Size(1172, 454);
            this.dgvSevkiyatlar.TabIndex = 0;
            this.dgvSevkiyatlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSevkiyatlar_CellClick);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.icerikPanel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.headerPanel, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1184, 662);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEVKİYAT TAKİP";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.icerikPanel.ResumeLayout(false);
            this.tLPanelIcerik.ResumeLayout(false);
            this.panelUst.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSevkiyatlar)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button btnGunlukGorunum;
        private System.Windows.Forms.Button btnHaftalikGorunum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGun;
        private System.Windows.Forms.ComboBox cmbHafta;
        private System.Windows.Forms.ComboBox cmbYil;
        private System.Windows.Forms.Panel icerikPanel;
        private System.Windows.Forms.TableLayoutPanel tLPanelIcerik;
        private System.Windows.Forms.Panel panelAlt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button btnYeniSevkiyat;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblYil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHafta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Panel panelUst;
        private System.Windows.Forms.Button btnDuzenle;
        public System.Windows.Forms.DataGridView dgvSevkiyatlar;
    }
}

