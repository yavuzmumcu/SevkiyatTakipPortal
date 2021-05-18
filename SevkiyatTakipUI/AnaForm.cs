using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.AdoNET;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using System.Net;
using System.Security.Principal;
using Business;
using Entities;

namespace SevkiyatTakipUI
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }


        SevkiyatManager sevkiyatManager = new SevkiyatManager(new AdSevkiyatDal());
        public List<SevkiyatView> Sevkiyatlar;
        public int listeGorunum;

        
        private void AnaForm_Load(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;
            int currentWeek = Parametre.HaftaNo(DateTime.Now);
            int currentday = (int)DateTime.Now.DayOfWeek;
            


            

            List<int> Haftalar = new List<int>();
            for (int i = 1; i <= 54; i++)
            {
                Haftalar.Add(i);
            }

            List<string> Gunler = new List<string>();
            Gunler.Add("Pazartesi");
            Gunler.Add("Salı");
            Gunler.Add("Çarşamba");
            Gunler.Add("Perşembe");
            Gunler.Add("Cuma");
            Gunler.Add("Cumartesi");
            Gunler.Add("Pazar");

            cmbHafta.DataSource = Haftalar;
            cmbGun.DataSource = Gunler;

            cmbYil.Text = currentYear.ToString();
            cmbHafta.Text = currentWeek.ToString();
            cmbGun.SelectedIndex = currentday - 1;

            GunlukSevkListele();

            
        }

        void SevkListele()
        {
            if (listeGorunum==1)
            {
                Sevkiyatlar = sevkiyatManager.GunlukSevkiyatlariListele(Convert.ToInt32(cmbYil.Text), Convert.ToInt32(cmbHafta.Text), Gun());
                dgvSevkiyatlar.DataSource = Sevkiyatlar;

                lblYil.Text = cmbYil.Text + ",";
                lblHafta.Text = cmbHafta.Text + ",";
                lblGun.Text = cmbGun.Text;

                lblGorunumAd.Text = "GÜNLÜK GÖRÜNÜM";
                Parametre.sevkiyatId = 0;
            }
            else if (listeGorunum==2)
            {
                Sevkiyatlar = sevkiyatManager.HaftalikSevkiyatlar(Convert.ToInt32(cmbYil.Text), Convert.ToInt32(cmbHafta.Text));
                dgvSevkiyatlar.DataSource = Sevkiyatlar;

                lblYil.Text = cmbYil.Text + ",";
                lblHafta.Text = cmbHafta.Text + ",";
                lblGun.Text = cmbGun.Text;

                lblGorunumAd.Text = "HAFTALIK GÖRÜNÜM";
                Parametre.sevkiyatId = 0;
            }
        }

        private void GunlukSevkListele()
        {
            listeGorunum = 1;

            SevkListele();
        }

        private void HafalikSevkListele()
        {
            listeGorunum = 2;

            SevkListele();
        }

        private void btnYeniSevkiyat_Click(object sender, EventArgs e)
        {
            new SevkiyatGiris().ShowDialog();
        }

        private void btnGunlukGorunum_Click(object sender, EventArgs e)
        {
            GunlukSevkListele();
            
        }

        int Gun()
        {
            if (cmbGun.Text == "Pazartesi")
            {
                return 1;
            }
            else if (cmbGun.Text == "Salı")
            {
                return 2;
            }
            else if (cmbGun.Text == "Çarşamba")
            {
                return 3;
            }
            else if (cmbGun.Text == "Perşembe")
            {
                return 4;
            }
            else if (cmbGun.Text == "Cuma")
            {
                return 5;
            }
            else if (cmbGun.Text == "Cumartesi")
            {
                return 6;
            }
            else
            {
                return 7;
            }
        }
      
        private void btnHaftalikGorunum_Click(object sender, EventArgs e)
        {
            HafalikSevkListele();

           
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvSevkiyatlar.RowCount > 0)
            {
                try
                {
                    string bilgisayarAdi = System.Windows.Forms.SystemInformation.UserName;

                    string fileName = DateTime.Now.ToShortDateString() + " Sevkiyatlar.xlsx";

                    string customExcelSavingPath = @"C:\Users\" + bilgisayarAdi + @"\Documents" + "\\" + fileName;
                    ExportToExcel.GenerateExcel(ExportToExcel.ConvertToDataTable(Sevkiyatlar), customExcelSavingPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(Constants.ExcelAktar, Constants.MesajBaslik);
            }

        }

        private void dgvSevkiyatlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Parametre.sevkiyatId = (int)dgvSevkiyatlar.CurrentRow.Cells["SevkiyatId"].Value;
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (Parametre.sevkiyatId == 0)
            {
                MessageBox.Show(Constants.SevkiyatBos, Constants.MesajBaslik);
            }
            else
            {
                Parametre.currentday = cmbGun.SelectedIndex + 1;
                Parametre.currentWeek = Convert.ToInt32(cmbHafta.Text);
                Parametre.currentYear = Convert.ToInt32(cmbYil.Text);

                new SevkiyatDuzenle().ShowDialog();
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Parametre.sevkiyatId==0)
            {
                MessageBox.Show(Constants.SevkiyatBos, Constants.MesajBaslik);
            }
            else
            {
                DialogResult silinsinMi = MessageBox.Show(Constants.SevkiyatSil, Constants.MesajBaslik, MessageBoxButtons.YesNo);
                if (silinsinMi==DialogResult.Yes)
                {
                    sevkiyatManager.Sil(new Sevkiyat
                    {
                        Id = Parametre.sevkiyatId
                    });

                    SevkListele();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int currentYear = dateTimePicker1.Value.Year;
            int currentWeek = Parametre.HaftaNo(dateTimePicker1.Value);
            int currentday = (int)dateTimePicker1.Value.DayOfWeek;

            cmbYil.Text = currentYear.ToString();
            cmbHafta.Text = currentWeek.ToString();
            cmbGun.SelectedIndex = currentday - 1;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (Parametre.sevkiyatId == 0)
            {
                MessageBox.Show(Constants.SevkiyatBos, Constants.MesajBaslik);
            }
            else
            {
                new GuncellemeGir().ShowDialog();
            }
               
        }
    }
}
