
namespace SevkiyatTakipUI
{
    partial class SevkiyatHareketleri
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
            this.dgvSevkiyatHareketleri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSevkiyatHareketleri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSevkiyatHareketleri
            // 
            this.dgvSevkiyatHareketleri.AllowUserToAddRows = false;
            this.dgvSevkiyatHareketleri.AllowUserToDeleteRows = false;
            this.dgvSevkiyatHareketleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSevkiyatHareketleri.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSevkiyatHareketleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSevkiyatHareketleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSevkiyatHareketleri.Location = new System.Drawing.Point(0, 0);
            this.dgvSevkiyatHareketleri.Name = "dgvSevkiyatHareketleri";
            this.dgvSevkiyatHareketleri.ReadOnly = true;
            this.dgvSevkiyatHareketleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSevkiyatHareketleri.Size = new System.Drawing.Size(1028, 542);
            this.dgvSevkiyatHareketleri.TabIndex = 1;
            // 
            // SevkiyatHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 542);
            this.Controls.Add(this.dgvSevkiyatHareketleri);
            this.Name = "SevkiyatHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SevkiyatHareketleri";
            this.Load += new System.EventHandler(this.SevkiyatHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSevkiyatHareketleri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvSevkiyatHareketleri;
    }
}