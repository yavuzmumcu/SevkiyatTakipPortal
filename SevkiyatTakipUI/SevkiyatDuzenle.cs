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
    public partial class SevkiyatDuzenle : Form
    {
        public SevkiyatDuzenle()
        {
            InitializeComponent();
        }
        MusteriManager musteriManager = new MusteriManager(new AdMusteriDal());
        AracManager aracManager = new AracManager(new AdAracDal());
        YuklemeTipManager yuklemeTipManager = new YuklemeTipManager(new AdYuklemeTipDal());
        SevkiyatManager sevkiyatManager = new SevkiyatManager(new AdSevkiyatDal());
        private void SevkiyatDuzenle_Load(object sender, EventArgs e)
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

            Sevkiyat sevkiyat = sevkiyatManager.SevkiyatDeger(Parametre.sevkiyatId);

            cmbMusteri.SelectedValue = sevkiyat.MusteriId;
            cmbYuklemeTip.SelectedValue = sevkiyat.YuklemeTipId;
            cmbArac.SelectedValue = sevkiyat.AracId;
            txtSiparisNo.Text = sevkiyat.SiparisNo;
            numAdet.Value = sevkiyat.Adet;
            txtAciklama.Text = sevkiyat.Aciklama;
            txtLojistikFirma.Text = sevkiyat.LojistikFirma;
            txtPlakaNo.Text = sevkiyat.PlakaNo;
            dateTimePicker1.Value = sevkiyat.TerminTarih;
            lblSevkiyatId.Text = sevkiyat.Id.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SevkiyatGuncelle();

            MessageBox.Show(Constants.BasariliGuncelleme, Constants.MesajBaslik);
        }

        private void SevkiyatGuncelle()
        {
            sevkiyatManager.Guncelle(new Sevkiyat
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
                Id = Parametre.sevkiyatId

            });
        }

        private void SevkiyatDuzenle_FormClosed(object sender, FormClosedEventArgs e)
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
                ((AnaForm)Application.OpenForms["anaForm"]).Sevkiyatlar = sevkiyatManager.GunlukSevkiyatlariListele(Parametre.currentYear, Parametre.currentWeek, Parametre.currentday);
                ((AnaForm)Application.OpenForms["anaForm"]).dgvSevkiyatlar.DataSource = ((AnaForm)Application.OpenForms["anaForm"]).Sevkiyatlar;
                ((AnaForm)Application.OpenForms["anaForm"]).lblGorunumAd.Text = "GÜNLÜK GÖRÜNÜM";


                ((AnaForm)Application.OpenForms["anaForm"]).cmbYil.Text = Parametre.currentYear.ToString();
                ((AnaForm)Application.OpenForms["anaForm"]).cmbHafta.Text = Parametre.currentWeek.ToString();
                ((AnaForm)Application.OpenForms["anaForm"]).cmbGun.SelectedIndex = Parametre.currentday - 1;

                ((AnaForm)Application.OpenForms["anaForm"]).lblYil.Text = ((AnaForm)Application.OpenForms["anaForm"]).cmbYil.Text + ",";
                ((AnaForm)Application.OpenForms["anaForm"]).lblHafta.Text = ((AnaForm)Application.OpenForms["anaForm"]).cmbHafta.Text + ",";
                ((AnaForm)Application.OpenForms["anaForm"]).lblGun.Text = ((AnaForm)Application.OpenForms["anaForm"]).cmbGun.Text;


            }
        }
    }
}
