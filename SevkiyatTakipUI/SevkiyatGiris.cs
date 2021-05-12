using Business;
using Business.Concrete;
using DataAccess.Concrete.AdoNET;
using Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SevkiyatTakipUI
{
    public partial class SevkiyatGiris : Form
    {
        public SevkiyatGiris()
        {
            InitializeComponent();
        }
        MusteriManager musteriManager = new MusteriManager(new AdMusteriDal());
        AracManager aracManager = new AracManager(new AdAracDal());
        YuklemeTipManager yuklemeTipManager = new YuklemeTipManager(new AdYuklemeTipDal());
        SevkiyatManager sevkiyatManager = new SevkiyatManager(new AdSevkiyatDal());


        private void SevkiyatGiris_Load(object sender, EventArgs e)
        {
            cmbMusteri.DataSource = musteriManager.MusteriListele();
            cmbMusteri.DisplayMember = "MusteriAd";
            cmbMusteri.ValueMember = "Id";

            cmbArac.DataSource = aracManager.SevkAracListele();
            cmbArac.DisplayMember = "AracAd";
            cmbArac.ValueMember = "Id";

            cmbYuklemeTip.DataSource = yuklemeTipManager.YuklemeTipListele();
            cmbYuklemeTip.DisplayMember = "YuklemeTipAd";
            cmbYuklemeTip.ValueMember = "Id";

            Araclar.AutoComplete(cmbMusteri);
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSiparisNo.Text))
            {
                MessageBox.Show(Constants.SiparisNoBos, Constants.MesajBaslik);
            }
            else if ((int)cmbMusteri.SelectedValue == 0)
            {
                MessageBox.Show(Constants.MusteriIdBos, Constants.MesajBaslik);
            }
            else if (numAdet.Value == 0)
            {
                MessageBox.Show(Constants.AdetBos, Constants.MesajBaslik);
            }
            else if ((int)cmbArac.SelectedValue == 0)
            {
                MessageBox.Show(Constants.AracIdBos, Constants.MesajBaslik);
            }
            else if (string.IsNullOrEmpty(txtPlakaNo.Text))
            {
                MessageBox.Show(Constants.PlakaNoBos, Constants.MesajBaslik);
            }
            else if ((int)cmbYuklemeTip.SelectedValue == 0)
            {
                MessageBox.Show(Constants.YuklemeTipIdBos, Constants.MesajBaslik);
            }                    
            else
            {
                SevkiyatEkle();
                MessageBox.Show(Constants.Basarili, Constants.MesajBaslik);
            }
            
        }

        private void SevkiyatEkle()
        {
            sevkiyatManager.Ekle(new Sevkiyat
            {
                MusteriId = (int)cmbMusteri.SelectedValue,
                AracId = (int)cmbArac.SelectedValue,
                YuklemeTipId = (int)cmbYuklemeTip.SelectedValue,
                PlakaNo = txtPlakaNo.Text.ToUpper(),
                Adet = (int)numAdet.Value,
                LojistikFirma = txtLojistikFirma.Text,
                Aciklama = txtAciklama.Text,
                SiparisNo = txtSiparisNo.Text,
                TerminTarih = dateTimePicker1.Value,
                DurumId = 1
            });
        }

        private void SevkiyatGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parametre.currentday = (int)dateTimePicker1.Value.DayOfWeek;
            Parametre.currentYear = dateTimePicker1.Value.Year;
            Parametre.currentWeek = Parametre.HaftaNo(dateTimePicker1.Value);


            AnaForm anaForm = new AnaForm();
            anaForm.Name = "anaForm";
            if (Application.OpenForms["anaForm"] == null)
            {

            }
            else
            {
                ((AnaForm)Application.OpenForms["anaForm"]).dgvSevkiyatlar.DataSource = sevkiyatManager.GunlukSevkiyatlariListele(Parametre.currentYear, Parametre.currentWeek, Parametre.currentday);

                ((AnaForm)Application.OpenForms["anaForm"]).cmbYil.Text= Parametre.currentYear.ToString();
                ((AnaForm)Application.OpenForms["anaForm"]). cmbHafta.Text = Parametre.currentWeek.ToString();
                ((AnaForm)Application.OpenForms["anaForm"]).cmbGun.SelectedIndex= Parametre.currentday-1;

                ((AnaForm)Application.OpenForms["anaForm"]).lblYil.Text = ((AnaForm)Application.OpenForms["anaForm"]).cmbYil.Text + ",";
                ((AnaForm)Application.OpenForms["anaForm"]).lblHafta.Text = ((AnaForm)Application.OpenForms["anaForm"]).cmbHafta.Text + ",";
                ((AnaForm)Application.OpenForms["anaForm"]).lblGun.Text = ((AnaForm)Application.OpenForms["anaForm"]).cmbGun.Text;


            }
        }
    }
}
