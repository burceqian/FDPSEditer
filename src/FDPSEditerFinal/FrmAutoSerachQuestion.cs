using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDPSEditerFinal
{
    public partial class FrmAutoSerachQuestion : Form
    {
        public MemorySearchType SearchType;

        public FrmAutoSerachQuestion()
        {
            InitializeComponent();
        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            SearchType = MemorySearchType.battle;
            this.DialogResult = DialogResult.OK;
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            SearchType = MemorySearchType.shop;
            this.DialogResult = DialogResult.OK;
        }

        private void FrmAutoSerachQuestion_Load(object sender, EventArgs e)
        {
            this.Icon = ComLib.GetIcon(Properties.Resources.Question);
        }
    }
}
