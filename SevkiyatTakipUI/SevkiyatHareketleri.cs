using Business.Concrete;
using DataAccess.Concrete.AdoNET;
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
    public partial class SevkiyatHareketleri : Form
    {
        public SevkiyatHareketleri()
        {
            InitializeComponent();
        }
        SevkiyatGuncellemeManager sevkiyatGuncellemeManager = new SevkiyatGuncellemeManager(new AdSevkiyatGuncellemeDal());
        private void SevkiyatHareketleri_Load(object sender, EventArgs e)
        {
            dgvSevkiyatHareketleri.DataSource = sevkiyatGuncellemeManager.Listele();
        }
    }
}
