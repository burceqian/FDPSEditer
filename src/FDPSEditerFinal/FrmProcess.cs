using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FDPSEditerFinal
{
    public partial class FrmProcess : Form
    {
        public Process SelectProcess;
        public FrmProcess()
        {
            InitializeComponent();
        }

        Process[] _ProcessList;
        private void FrmProcess_Load(object sender, EventArgs e)
        {
            this.Icon = ComLib.GetIcon(Properties.Resources.Program);

            _ProcessList = Process.GetProcesses();

            listViewProcess.View = View.Details;
            listViewProcess.Columns.Add("PID");
            listViewProcess.Columns.Add("进程名",180);
            listViewProcess.FullRowSelect = true;

            for (int i = 0; i < _ProcessList.Length; i++) 
            {
                ListViewItem item = new ListViewItem(_ProcessList[i].Id.ToString());
                item.SubItems.Add(_ProcessList[i].ProcessName);
                listViewProcess.Items.Add(item);
            }

            for (int i = 0; i < listViewProcess.Items.Count; i++)
            {
                if (listViewProcess.Items[i].SubItems[1].Text.ToUpper() == "FDPS")
                {
                    listViewProcess.Items[i].Selected = true;
                    listViewProcess.EnsureVisible(i);
                    break;
                }
                if (listViewProcess.Items[i].SubItems[1].Text.ToUpper() == "DOSBOX")
                {
                    listViewProcess.Items[i].Selected = true;
                    listViewProcess.EnsureVisible(i);
                    break;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (listViewProcess.SelectedItems.Count <= 0)
            {
                MessageBox.Show("没有选择进程!");
                return;
            }
            string tID = listViewProcess.SelectedItems[0].SubItems[0].Text;

            for (int i = 0; i < _ProcessList.Length;i++)
            {
                if (_ProcessList[i].Id.ToString() == tID)
                {
                    SelectProcess = _ProcessList[i];
                    break;
                }
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
