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
    public partial class GuncellemeGir : Form
    {
        public GuncellemeGir()
        {
            InitializeComponent();
        }

        DurumManager durumManager = new DurumManager(new AdDurumDal());
        SevkiyatGuncellemeManager sevkiyatGuncellemeManager = new SevkiyatGuncellemeManager(new AdSevkiyatGuncellemeDal());
        SevkiyatManager sevkiyatManager = new SevkiyatManager(new AdSevkiyatDal());

        private void GuncellemeGir_Load(object sender, EventArgs e)
        {
            cmbDurum.DataSource = durumManager.Listele();
            cmbDurum.DisplayMember = "DurumAd";
            cmbDurum.ValueMember = "Id";

            lblSevkiyatId.Text = Parametre.sevkiyatId.ToString();
            SevkiyatGuncellemeListele();

          
            
                var result = sevkiyatManager.SevkiyatViewDeger(Parametre.sevkiyatId);
            
            

            lblMusteriAd.Text = result.MusteriAd.ToString();


        }

        private void SevkiyatGuncellemeListele()
        {
            dgvSevkiyatGuncellemeleri.DataSource = sevkiyatGuncellemeManager.ListeleBySevkiyatId(Parametre.sevkiyatId);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SevkiyatGuncellemeEkle();

            SevkiyatGuncellemeListele();

            DurumGuncelle();
        }

        private void DurumGuncelle()
        {
            sevkiyatManager.DurumGuncelle(new Sevkiyat
            {
                Id = Parametre.sevkiyatId,
                DurumId = (int)cmbDurum.SelectedValue
            });
        }

        private void SevkiyatGuncellemeEkle()
        {
            sevkiyatGuncellemeManager.Ekle(new SevkiyatGuncelleme
            {
                DurumId = (int)cmbDurum.SelectedValue,
                Aciklama = txtAciklama.Text,
                SevkiyatId = Parametre.sevkiyatId
            });
        }

        
    }
}
