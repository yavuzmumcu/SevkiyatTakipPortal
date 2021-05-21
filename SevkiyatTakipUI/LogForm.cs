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
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }
        SevkiyatManager sevkiyatManager = new SevkiyatManager(new AdSevkiyatDal());
        private void LogForm_Load(object sender, EventArgs e)
        {
            dgvLogs.DataSource = sevkiyatManager.LogListele();
        }
    }
}
