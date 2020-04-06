using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace FDPSEditerFinal
{
    public partial class FrmItemSelect : Form
    {
        public string SelectedItemCode = "";
        public string SelectedItemName = "";

        public FrmItemSelect()
        {
            InitializeComponent();
            dataGridViewItems.DoubleBuffered(true);
        }

        private void FrmItemSelect_Load(object sender, EventArgs e)
        {
            this.Icon = ComLib.GetIcon(Properties.Resources.Item);

            List<string> Category = new List<string>();
            Category.Add("全部");
            foreach (var item in SettingsLib.ItemInfoList)
            {
                if (!Category.Contains(item.Category))
                {
                    Category.Add(item.Category);
                }
            }

            comBoxCategory.Items.AddRange(Category.ToArray());
            comBoxCategory.SelectedIndex = 0;
        }

        private void comBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindSource(comBoxCategory.Text);
        }

        private void BindSource(string category)
        {
            if (category == "全部")
            {
                var viewData = SettingsLib.ItemInfoList.Select(item => new {
                    item.Name,
                    item.Code,
                    item.Category,
                    item.AP,
                    item.DP,
                    item.Hit,
                    item.EV,
                    item.Range,
                    item.Exist,
                    item.Price,
                    item.Special
                });
                dataGridViewItems.DataSource = viewData.ToList();
                dataGridViewItems.AutoResizeColumns();
            }
            else
            {
                var viewData = SettingsLib.ItemInfoList.Where(item => item.Category == category).Select(item => new {
                    item.Name,
                    item.Code,
                    item.Category,
                    item.AP,
                    item.DP,
                    item.Hit,
                    item.EV,
                    item.Range,
                    item.Exist,
                    item.Price,
                    item.Special
                });
                dataGridViewItems.DataSource = viewData.ToList();
                dataGridViewItems.AutoResizeColumns();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SelectedItemName = dataGridViewItems.SelectedRows[0].Cells[0].Value.ToString();
            SelectedItemCode = dataGridViewItems.SelectedRows[0].Cells[1].Value.ToString();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewItems_DoubleClick(object sender, EventArgs e)
        {
            SelectedItemName = dataGridViewItems.SelectedRows[0].Cells[0].Value.ToString();
            SelectedItemCode = dataGridViewItems.SelectedRows[0].Cells[1].Value.ToString();
            this.Close();
        }
    }
}
