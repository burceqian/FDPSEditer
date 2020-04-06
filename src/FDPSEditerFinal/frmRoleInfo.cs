using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FDPSEditerFinal
{
    public partial class frmRoleInfo : Form
    {
        Role _RoleInfo = null;

        List<Image> IconList = new List<Image>();
        Bitmap MiniIcon;
        int IconCount = 0;
        bool isACE = true;

        public frmRoleInfo(Role role)
        {
            InitializeComponent();
            _RoleInfo = role;
        }

        private void frmRoleInfo_Load(object sender, EventArgs e)
        {
            this.Icon = ComLib.GetIcon(Properties.Resources.Role);

            this.TopMost = GlobalSpecs.TopMost;

            _RoleInfo.FillData();

            LoadBigFace(RoleLib.GetFace(_RoleInfo.M08_人物肖像职业));

            LoadMiniFace(RoleLib.GetMiniFace(_RoleInfo.M08_人物肖像职业, _RoleInfo.M04_人物方向));

            SetFormValue();
        }

        #region windows evnent
        private void chkState_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox stateChkBox = (CheckBox)sender;
            TextBox stateTxtBox = null;

            if (stateChkBox == chkPoison)
            {
                stateTxtBox = txtPoison;
            }
            else if (stateChkBox == chkParalysis)
            {
                stateTxtBox = txtParalysis;
            }
            else
            {
                stateTxtBox = txtCurse;
            }

            if (stateChkBox.Checked)
            {
                if (stateTxtBox.Text == "")
                {
                    stateTxtBox.Text = "9";
                }
            }
            else
            {
                stateTxtBox.Text = "";
            }
        }
        private void txtState_TextChanged(object sender, EventArgs e)
        {
            TextBox currenttxtBox = (TextBox)sender;

            #region Null
            if (currenttxtBox.Text == "")
            {
                currenttxtBox.Tag = null;
                CheckBox stateChkBox = null;
                if (currenttxtBox == txtPoison)
                {
                    stateChkBox = chkPoison;
                }
                else if (currenttxtBox == txtParalysis)
                {
                    stateChkBox = chkParalysis;
                }
                else if (currenttxtBox == txtCurse)
                {
                    stateChkBox = chkCurse;
                }

                stateChkBox.Checked = false;
                return;
            }
            #endregion

            int val = 0;
            if (int.TryParse(currenttxtBox.Text, out val))
            {
                currenttxtBox.Tag = currenttxtBox.Text;

                CheckBox stateChkBox = null;
                if (currenttxtBox == txtPoison)
                {
                    stateChkBox = chkPoison;
                }
                else if (currenttxtBox == txtParalysis)
                {
                    stateChkBox = chkParalysis;
                }
                else if (currenttxtBox == txtCurse)
                {
                    stateChkBox = chkCurse;
                }

                stateChkBox.Checked = val > 0;

            }
            else
            {
                currenttxtBox.Text = currenttxtBox.Tag == null?"": currenttxtBox.Tag.ToString();
            }
        }
        private void Item_DoubleClick(object sender, EventArgs e)
        {
            FrmItemSelect itemSelectForm = new FrmItemSelect();
            this.Activated -= frmRoleInfo_Activated;
            itemSelectForm.ShowDialog();
            if (itemSelectForm.SelectedItemName != "")
            {
                ((TextBox)sender).Text = itemSelectForm.SelectedItemName;
                ((TextBox)sender).Tag = itemSelectForm.SelectedItemCode;
            }

            this.Activated += frmRoleInfo_Activated;
        }
        private void Magic_DoubleClick(object sender, EventArgs e)
        {
            FrmItemSelect itemSelectForm = new FrmItemSelect();
            itemSelectForm.ShowDialog();
            if (itemSelectForm.SelectedItemName != "")
            {
                ((TextBox)sender).Text = itemSelectForm.SelectedItemName;
                ((TextBox)sender).Tag = itemSelectForm.SelectedItemCode;
            }
        }
        private void listBoxMagic_DoubleClick(object sender, EventArgs e)
        {
            List<string> magicList = new List<string>();
            foreach (var item in listBoxMagic.Items)
            {
                magicList.Add(((dynamic)item).Name);
            }
            this.Activated -= frmRoleInfo_Activated;
            FrmMagicSelect magicSelectForm = new FrmMagicSelect(magicList);
            magicSelectForm.ShowDialog();
            if (magicSelectForm.SelectedMagicList.Count != 0)
            {
                listBoxMagic.DataSource = magicSelectForm.SelectedMagicList.Select(item => new { Name = item }).ToList();
            }
            this.Activated += frmRoleInfo_Activated;
        }
        private void btnChgMagic_Click(object sender, EventArgs e)
        {
            List<string> tMagicList = new List<string>();

            for (int i = 0; i < listBoxMagic.Items.Count; i++)
            {
                tMagicList.Add(((dynamic)listBoxMagic.Items[i]).Name);
            }

            string[] tMagic = MagicLib.GetMagicCode(tMagicList);

            MagicLib.WriteOneMagic(tMagic, _RoleInfo);

            MessageBox.Show("改好了！快吧^-^", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnChgItem_Click(object sender, EventArgs e)
        {
            SaveItem();
            MessageBox.Show("改好了！快吧^-^", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void timerRoleMove_Tick(object sender, EventArgs e)
        {
            if (IconList.Count == 0)
            {
                return;
            }

            if (IconCount == 0 || IconCount == 2)
            {
                pBox.Image = MergeBmp(MiniIcon, (Bitmap)IconList[1]);
                IconCount = 1;
            }
            else
            {
                if (isACE)
                {
                    pBox.Image = MergeBmp(MiniIcon, (Bitmap)IconList[2]);
                    IconCount = 2;
                    isACE = false;
                }
                else
                {
                    pBox.Image = MergeBmp(MiniIcon, (Bitmap)IconList[0]);
                    IconCount = 0;
                    isACE = true;
                }
            }
        }
        private void txtBaseInfo_TextChanged(object sender, EventArgs e)
        {
            TextBox currenttxtBox = (TextBox)sender;
            int val = 0;
            if (int.TryParse(currenttxtBox.Text, out val))
            {
                currenttxtBox.Tag = currenttxtBox.Text;
            }
            else
            {
                currenttxtBox.Text = currenttxtBox.Tag == null ? "" : currenttxtBox.Tag.ToString();
            }
        }
        private void btnChgProperty_Click(object sender, EventArgs e)
        {
            if (!PreCheck())
            {
                return;
            }

            SaveBaseInfo();

            MessageBox.Show("改好了！快吧^-^", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void frmRoleInfo_Activated(object sender, EventArgs e)
        {
            if (!Win32Lib.IsCorrectStartAddress(_RoleInfo.Address))
            {
                GlobalSpecs.NeedReSearch = true;
                this.Activated -= frmRoleInfo_Activated;
                MessageBox.Show("内存地址已变动，请重新查找。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                _RoleInfo.FillData();
                SetFormValue();
            }
        }
        private void txtItem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back ||
                e.KeyCode == Keys.Delete)
            {
                ((TextBox)sender).Text = "";
            }

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Display
        private void LoadBigFace(Bitmap roleFace)
        {
            Bitmap pic = roleFace;
            pic.MakeTransparent(Color.Black);
            Bitmap pic2 = Properties.Resources._178_1;
            Bitmap picmereg = new Bitmap(pic2.Width, pic2.Height);
            Graphics g = Graphics.FromImage(picmereg);
            g.DrawImage(pic2, new Rectangle(50, 0, 200, 200), new Rectangle(30, 10, 230, 210), GraphicsUnit.Pixel);
            g.DrawImage(pic, 98, 55);
            g.Dispose();
            pBoxBigFace.Image = picmereg;
        }
        private Bitmap MergeBmp(Bitmap bmpBack, Bitmap bmpFront)
        {
            Bitmap picmereg = new Bitmap(bmpBack.Width, bmpBack.Height);
            Graphics g = Graphics.FromImage(picmereg);
            g.DrawImage(bmpBack, 0, 0);
            g.DrawImage(bmpFront, 0, 0);
            g.Dispose();
            return picmereg;
        }
        private void LoadMiniFace(Bitmap[] miniFace)
        {
            MiniIcon = Properties.Resources._182_4;

            Bitmap pic1 = miniFace[0];
            pic1.MakeTransparent(Color.Black);
            Bitmap pic2 = miniFace[1];
            pic2.MakeTransparent(Color.Black);
            Bitmap pic3 = miniFace[2];
            pic3.MakeTransparent(Color.Black);
            IconList.Add(pic1);
            IconList.Add(pic2);
            IconList.Add(pic3);

            timerRoleMove.Enabled = true;
        }
        private void SetFormValue()
        {
            #region title Info
            txtX.Text = _RoleInfo.M01_X.Value;
            txtY.Text = _RoleInfo.M02_Y.Value;
            labJob.Text = RoleLib.GetJob(_RoleInfo.M33_职业).Name;
            labRace.Text = RoleLib.GetRace(_RoleInfo.M32_人种).Name;
            RoleNameInfo roleName = RoleLib.GetRoleName(_RoleInfo.M08_人物肖像职业);
            labName.Text = roleName == null? _RoleInfo.M08_人物肖像职业.HexVal: roleName.Name;
            labRoleJob.Text = roleName == null ? _RoleInfo.M08_人物肖像职业.Value : roleName.Job;
            switch (RoleLib.GetCamp(_RoleInfo.M07_人物阵营))
            {
                case RoleCamp.Enemy:
                    labCamp.Text = "(敌人)";
                    break;
                case RoleCamp.NPC:
                    labCamp.Text = "(NPC)";
                    break;
                case RoleCamp.Ally:
                    labCamp.Text = "(己方)";
                    break;
                default:
                    break;
            }

            //txtM03.Text = _RoleInfo.M03_人物图形.Value;
            //txtM04.Text = _RoleInfo.M04_人物方向.Value;
            //txtM07.Text = _RoleInfo.M07_人物阵营.Value;
            //txtM08.Text = _RoleInfo.M08_人物肖像职业.Value;
            //txtM09.Text = _RoleInfo.M09_人物名字.Value;
            #endregion

            #region basic info
            SetOneTxtItem(txtNowHP, _RoleInfo.M47_HP);
            SetOneTxtItem(txtMaxHP, _RoleInfo.M48_MaxHP);
            SetOneTxtItem(txtNowMP, _RoleInfo.M49_MP);
            SetOneTxtItem(txtMaxMP, _RoleInfo.M50_MaxMp);
            SetOneTxtItem(txtLV, _RoleInfo.M34_等级);
            SetOneTxtItem(txtMV, _RoleInfo.M44_移动);
            SetOneTxtItem(txtEx, _RoleInfo.M45_经验);
            SetOneTxtItem(txtBaseAP, _RoleInfo.M42_基本AP);
            SetOneTxtItem(txtBaseDP, _RoleInfo.M43_基本DP);
            SetOneTxtItem(txtDx, _RoleInfo.M46_DX);
            SetOneTxtItem(txtEv, _RoleInfo.M54_EV);
            SetOneTxtItem(txtAP, _RoleInfo.M51_AP);
            SetOneTxtItem(txtHit, _RoleInfo.M53_HIT);
            SetOneTxtItem(txtDP, _RoleInfo.M52_DP);

            txtPoison.Text = _RoleInfo.M38_中毒.IntVal == 0 ? "" : _RoleInfo.M38_中毒.Value;
            txtParalysis.Text = _RoleInfo.M39_麻痹.IntVal == 0 ? "" : _RoleInfo.M39_麻痹.Value;
            txtCurse.Text = _RoleInfo.M40_禁咒.IntVal == 0 ? "" : _RoleInfo.M40_禁咒.Value;
            chkAction.Checked = ComLib.GetAction(int.Parse(_RoleInfo.M06_是否可动.Value));
            #endregion

            #region Items
            SetItem(chkItem1, txtItem1, _RoleInfo.M11_物品1状态, _RoleInfo.M12_物品1);
            SetItem(chkItem2, txtItem2, _RoleInfo.M13_物品2状态, _RoleInfo.M14_物品2);
            SetItem(chkItem3, txtItem3, _RoleInfo.M15_物品3状态, _RoleInfo.M16_物品3);
            SetItem(chkItem4, txtItem4, _RoleInfo.M17_物品4状态, _RoleInfo.M18_物品4);
            SetItem(chkItem5, txtItem5, _RoleInfo.M19_物品5状态, _RoleInfo.M20_物品5);
            SetItem(chkItem6, txtItem6, _RoleInfo.M21_物品6状态, _RoleInfo.M22_物品6);
            SetItem(chkItem7, txtItem7, _RoleInfo.M23_物品7状态, _RoleInfo.M24_物品7);
            SetItem(chkItem8, txtItem8, _RoleInfo.M25_物品8状态, _RoleInfo.M26_物品8);
            #endregion

            #region Magic
            List<string> tMagicList;
            int[] pMagicCode = { _RoleInfo.M27_法术1.IntVal ,
                _RoleInfo.M28_法术2.IntVal,
                _RoleInfo.M29_法术3.IntVal,
                _RoleInfo.M30_法术4.IntVal,
                _RoleInfo.M31_法术5.IntVal
            };
            tMagicList = MagicLib.GetMagicName(pMagicCode);
            listBoxMagic.DataSource = tMagicList.Select(item => new { Name = item }).ToList();
            #endregion
        }

        private void SetOneTxtItem(TextBox displayTextBox, MemoryData memoryData)
        {
            displayTextBox.Text = memoryData.Value;
            displayTextBox.Tag = memoryData;
        }

        private void SetItem(CheckBox stateChkBox, TextBox itemTextBox, MemoryData stateMemory, MemoryData itemMemory)
        {
            ItemEquip equip = RoleLib.GetEquip(stateMemory);
            stateChkBox.Checked = equip == ItemEquip.Equip;
            if (equip != ItemEquip.Non)
            {
                itemTextBox.Text = RoleLib.GetItem(itemMemory).Name;
                itemTextBox.Tag = itemMemory.HexVal;
            }
            else
            {
                itemTextBox.Text = "";
                itemTextBox.Tag = null;
            }
        }
        #endregion
        private bool PreCheck()
        {
            if (!PrecheckOneItem(txtX, _RoleInfo.M01_X)) return false;
            if (!PrecheckOneItem(txtY, _RoleInfo.M02_Y)) return false;
            if (!PrecheckOneItem(txtNowHP, _RoleInfo.M47_HP)) return false;
            if (!PrecheckOneItem(txtMaxHP, _RoleInfo.M48_MaxHP)) return false;
            if (!PrecheckOneItem(txtNowMP, _RoleInfo.M49_MP)) return false;
            if (!PrecheckOneItem(txtMaxMP, _RoleInfo.M50_MaxMp)) return false;
            if (!PrecheckOneItem(txtLV, _RoleInfo.M34_等级)) return false;
            if (!PrecheckOneItem(txtMV, _RoleInfo.M44_移动)) return false;
            if (!PrecheckOneItem(txtEx, _RoleInfo.M45_经验)) return false;
            if (!PrecheckOneItem(txtDx, _RoleInfo.M46_DX)) return false;
            if (!PrecheckOneItem(txtEv, _RoleInfo.M54_EV)) return false;
            if (!PrecheckOneItem(txtAP, _RoleInfo.M51_AP)) return false;
            if (!PrecheckOneItem(txtHit, _RoleInfo.M53_HIT)) return false;
            if (!PrecheckOneItem(txtDP, _RoleInfo.M52_DP)) return false;
            if (!PrecheckOneItem(txtBaseAP, _RoleInfo.M42_基本AP)) return false;
            if (!PrecheckOneItem(txtBaseDP, _RoleInfo.M43_基本DP)) return false;
            if (!PrecheckOneItem(txtPoison, _RoleInfo.M38_中毒)) return false;
            if (!PrecheckOneItem(txtParalysis, _RoleInfo.M39_麻痹)) return false;
            if (!PrecheckOneItem(txtCurse, _RoleInfo.M40_禁咒)) return false;

            return true;
        }

        private bool PrecheckOneItem(TextBox txtbox,MemoryData memoryData)
        {
            if (txtbox.Text == "")
            {
                return true;
            }

            int val = int.Parse(txtbox.Text);
            int maxValue = memoryData.ByteCount == 1 ? 255 : 65535;

            if (val > maxValue)
            {
                MessageBox.Show("数字太大了，不能超过" + maxValue+ "哦", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbox.Focus();
                return false;
            }
            return true;
        }

        #region Save To Memory
        private void SaveBaseInfo()
        {
            WriteOneProperty(txtX, _RoleInfo.M01_X);
            WriteOneProperty(txtY, _RoleInfo.M02_Y);
            WriteOneProperty(txtNowHP, _RoleInfo.M47_HP);
            WriteOneProperty(txtMaxHP, _RoleInfo.M48_MaxHP);
            WriteOneProperty(txtNowMP, _RoleInfo.M49_MP);
            WriteOneProperty(txtMaxMP, _RoleInfo.M50_MaxMp);
            WriteOneProperty(txtLV, _RoleInfo.M34_等级);
            WriteOneProperty(txtMV, _RoleInfo.M44_移动);
            WriteOneProperty(txtEx, _RoleInfo.M45_经验);
            WriteOneProperty(txtDx, _RoleInfo.M46_DX);
            WriteOneProperty(txtEv, _RoleInfo.M54_EV);
            WriteOneProperty(txtAP, _RoleInfo.M51_AP);
            WriteOneProperty(txtHit, _RoleInfo.M53_HIT);
            WriteOneProperty(txtDP, _RoleInfo.M52_DP);
            WriteOneProperty(txtBaseAP, _RoleInfo.M42_基本AP);
            WriteOneProperty(txtBaseDP, _RoleInfo.M43_基本DP);
            WriteOneState(txtPoison, _RoleInfo.M38_中毒);
            WriteOneState(txtParalysis, _RoleInfo.M39_麻痹);
            WriteOneState(txtCurse, _RoleInfo.M40_禁咒);
            WriteAction(chkAction, _RoleInfo.M06_是否可动);
        }
        private void SaveItem()
        {
            SaveOneItem(chkItem1, txtItem1, _RoleInfo.M11_物品1状态, _RoleInfo.M12_物品1);
            SaveOneItem(chkItem2, txtItem2, _RoleInfo.M13_物品2状态, _RoleInfo.M14_物品2);
            SaveOneItem(chkItem3, txtItem3, _RoleInfo.M15_物品3状态, _RoleInfo.M16_物品3);
            SaveOneItem(chkItem4, txtItem4, _RoleInfo.M17_物品4状态, _RoleInfo.M18_物品4);
            SaveOneItem(chkItem5, txtItem5, _RoleInfo.M19_物品5状态, _RoleInfo.M20_物品5);
            SaveOneItem(chkItem6, txtItem6, _RoleInfo.M21_物品6状态, _RoleInfo.M22_物品6);
            SaveOneItem(chkItem7, txtItem7, _RoleInfo.M23_物品7状态, _RoleInfo.M24_物品7);
            SaveOneItem(chkItem8, txtItem8, _RoleInfo.M25_物品8状态, _RoleInfo.M26_物品8);
        }
        private void SaveOneItem(CheckBox pUsed, TextBox pItem, MemoryData pMemoryUsed, MemoryData pMemoryItem)
        {
            if (pItem.Text == "")
            {
                Win32Lib.WriteMemory(pMemoryUsed.Address, GlobalConst.Item_nonState, 1);
                Win32Lib.WriteMemory(pMemoryItem.Address, GlobalConst.Item_nonItem, 1);
            }
            else
            {
                ItemInfo item = RoleLib.GetItem(pItem.Text);
                Win32Lib.WriteMemory(pMemoryItem.Address, Convert.ToInt32(item.Code, 16), 1);
                if (pUsed.Checked)
                {
                    Win32Lib.WriteMemory(pMemoryUsed.Address, GlobalConst.Item_Equiped, 1);
                }
                else
                {
                    Win32Lib.WriteMemory(pMemoryUsed.Address, GlobalConst.Item_nonEquiped, 1);
                }
            }
        }
        private bool WriteOneProperty(TextBox pData, MemoryData pMemory)
        {
            bool WriteSuccess = false;
            if (pData.Text != pMemory.Value)
            {
                WriteSuccess = Win32Lib.WriteMemory(pMemory.Address, int.Parse(pData.Text), pMemory.ByteCount);
                if (WriteSuccess == false)
                {
                    MessageBox.Show("写入失败");
                    return false;
                }
            }
            return true;
        }
        private bool WriteOneState(TextBox pData, MemoryData pMemory)
        {
            bool WriteSuccess = false;
            int formVal = 0;
            if (!int.TryParse(pData.Text,out formVal))
            {
                formVal = 0;
            }
            if(formVal != pMemory.IntVal)
            {
                WriteSuccess = Win32Lib.WriteMemory(pMemory.Address, formVal, 1);
                if (WriteSuccess == false)
                {
                    MessageBox.Show("写入失败");
                    return false;
                }
            }
            return true;
        }
        private bool WriteAction(CheckBox pData, MemoryData pMemory)
        {
            bool WriteSuccess = false;
            if (pData.Checked != (RoleLib.GetState(pMemory) == RoleState.has))
            {
                int lState = pData.Checked ? GlobalConst.Acion_Moved : GlobalConst.Acion_nonMoved;
                WriteSuccess = Win32Lib.WriteMemory(pMemory.Address, lState, 1);
                if (WriteSuccess == false)
                {
                    MessageBox.Show("写入失败");
                    return false;
                }
            }
            return true;
        }
        #endregion


    }
}
