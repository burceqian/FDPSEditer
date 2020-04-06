using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FDPSEditerFinal
{
    public partial class FrmMagicSelect : Form
    {
        public List<string> SelectedMagicList = new List<string>();

        List<string> _ExistMagicList = null;

        public FrmMagicSelect(List<string> ExistMagicList)
        {
            InitializeComponent();
            _ExistMagicList = ExistMagicList;
        }

        private void FrmMagicSelect_Load(object sender, EventArgs e)
        {
            this.Icon = ComLib.GetIcon(Properties.Resources.Magic);

            #region Maigc List
            listBoxMagic1.Items.Clear();
            listBoxMagic2.Items.Clear();
            listBoxMagic3.Items.Clear();
            listBoxMagic4.Items.Clear();
            listBoxMagic5.Items.Clear();

            var list1 = MagicLib.MagicList1.Where(item => item.Column == "1").Select(item => new { item.Column, item.Code, item.Name });
            listBoxMagic1.DataSource = list1.ToList();
            listBoxMagic1.SelectedItem = null;
            var list2 = MagicLib.MagicList2.Where(item => item.Column == "2").Select(item => new { item.Column, item.Code, item.Name });
            listBoxMagic2.DataSource = list2.ToList();
            listBoxMagic2.SelectedItem = null;
            var list3 = MagicLib.MagicList3.Where(item => item.Column == "3").Select(item => new { item.Column, item.Code, item.Name });
            listBoxMagic3.DataSource = list3.ToList();
            listBoxMagic3.SelectedItem = null;
            var list4 = MagicLib.MagicList4.Where(item => item.Column == "4").Select(item => new { item.Column, item.Code, item.Name });
            listBoxMagic4.DataSource = list4.ToList();
            listBoxMagic4.SelectedItem = null;
            var list5 = MagicLib.MagicList5.Where(item => item.Column == "5").Select(item => new { item.Column, item.Code, item.Name });
            listBoxMagic5.DataSource = list5.ToList();
            listBoxMagic5.SelectedItem = null;
            #endregion
            #region Magic And Job
            listBoxMagicRole.Items.Clear();
            var roleLIst = SettingsLib.MagicAndJobInfoList.Where(item=>item.Role != "").Select(item => new { item.Role });
            comBoxRole.DataSource = roleLIst.ToList();
            #endregion

            if (_ExistMagicList != null)
            {
                foreach (var magic in _ExistMagicList)
                {
                    SetExistMagic(magic);
                }
            }
        }

        private void SetExistMagic(string magic)
        {
            MagicInfo existMagicInfo = MagicLib.MagicList1.FirstOrDefault(item => item.Name == magic);
            if (existMagicInfo == null)
            {
                existMagicInfo = MagicLib.MagicList2.FirstOrDefault(item => item.Name == magic);
                if (existMagicInfo == null)
                {
                    existMagicInfo = MagicLib.MagicList3.FirstOrDefault(item => item.Name == magic);
                    if (existMagicInfo == null)
                    {
                        existMagicInfo = MagicLib.MagicList4.FirstOrDefault(item => item.Name == magic);
                        if (existMagicInfo == null)
                        {
                            existMagicInfo = MagicLib.MagicList5.FirstOrDefault(item => item.Name == magic);
                        }
                    }
                }
            }

            if (existMagicInfo != null)
            {
                ListBox currntListBox = null;
                switch (existMagicInfo.Column)
                {
                    case "1":
                        currntListBox = listBoxMagic1;
                        break;
                    case "2":
                        currntListBox = listBoxMagic2;
                        break;
                    case "3":
                        currntListBox = listBoxMagic3;
                        break;
                    case "4":
                        currntListBox = listBoxMagic4;
                        break;
                    case "5":
                        currntListBox = listBoxMagic5;
                        break;
                    default:
                        break;
                }

                foreach (var item  in currntListBox.Items)
                {
                    if (((dynamic)item).Name == magic)
                    {
                        currntListBox.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void comBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = comBoxRole.Text;

            bool dataStart = false;
            List<MagicAndJob> roleMagicAndJob = new List<MagicAndJob>();
            for (int i = 0; i < SettingsLib.MagicAndJobInfoList.Count; i++)
            {
                if (SettingsLib.MagicAndJobInfoList[i].Role == "")
                {
                    if (dataStart == true)
                    {
                        roleMagicAndJob.Add(SettingsLib.MagicAndJobInfoList[i]);
                    }
                    continue;
                }

                if (SettingsLib.MagicAndJobInfoList[i].Role == selectedRole)
                {
                    dataStart = true;
                    roleMagicAndJob.Add(SettingsLib.MagicAndJobInfoList[i]);
                }
                else
                {
                    dataStart = false;
                }
            }

            var CurrentJobItemList = roleMagicAndJob.Select(item => new { Data = item, DisplayName = item.Type });
            comJob.DataSource = CurrentJobItemList.ToList();
        }

        private void comJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            MagicAndJob data = ((dynamic)comJob.SelectedItem).Data;
            labJob.Text = data.Job;
            listBoxMagicRole.DataSource = data.Magic.Split(',');
            listBoxMagicRole.ClearSelected();
        }

        private void listBoxMagic_Click(object sender, EventArgs e)
        {
            ListBox currentListBox = (ListBox)sender;
            if (currentListBox.Tag == currentListBox.SelectedValue)
            {
                currentListBox.ClearSelected();
                currentListBox.Tag = null;
            }
            else
            {
                currentListBox.Tag = currentListBox.SelectedValue;
                if (currentListBox == listBoxMagicRole)
                {
                    SetExistMagic(listBoxMagicRole.SelectedValue.ToString());
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            foreach (var item in listBoxMagic1.SelectedItems)
            {
                SelectedMagicList.Add(((dynamic)item).Name);
            }
            foreach (var item in listBoxMagic2.SelectedItems)
            {
                SelectedMagicList.Add(((dynamic)item).Name);
            }
            foreach (var item in listBoxMagic3.SelectedItems)
            {
                SelectedMagicList.Add(((dynamic)item).Name);
            }
            foreach (var item in listBoxMagic4.SelectedItems)
            {
                SelectedMagicList.Add(((dynamic)item).Name);
            }
            foreach (var item in listBoxMagic5.SelectedItems)
            {
                SelectedMagicList.Add(((dynamic)item).Name);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
