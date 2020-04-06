using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FDPSEditerFinal
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FrmProcess fp = new FrmProcess();
            if (fp.ShowDialog() == DialogResult.OK)
            {
                GlobalSpecs.FDPSProcess = fp.SelectProcess;
                Win32Lib.ProgramProcess = GlobalSpecs.FDPSProcess;
                gBoxProcess.Text = "进程   " + GlobalSpecs.FDPSProcess.ProcessName;
                gboxSearch.Enabled = true;
            }
        }

        private void FrmMain_Activated(object sender, EventArgs e)
        {
            if (GlobalSpecs.FDPSProcess == null)
            {
                gBoxProcess.Text = "进程   无";
                gboxSearch.Enabled = false;
                fLPanelFriend.Controls.Clear();
                fLPanelEnemy.Controls.Clear();
                fLPanelNPC.Controls.Clear();
                GlobalSpecs.NeedReSearch = false;
                return;
            }

            if (GlobalSpecs.FDPSProcess.HasExited)
            {
                gBoxProcess.Text = "进程   无";
                gboxSearch.Enabled = false;
                fLPanelFriend.Controls.Clear();
                fLPanelEnemy.Controls.Clear();
                fLPanelNPC.Controls.Clear();
                GlobalSpecs.NeedReSearch = false;
                return;
            }

            if (GlobalSpecs.NeedReSearch)
            {
                fLPanelFriend.Controls.Clear();
                fLPanelEnemy.Controls.Clear();
                fLPanelNPC.Controls.Clear();
                GlobalSpecs.NeedReSearch = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            AutoSearch();
            toolStripStatusLabelLocationValue.Text = GlobalSpecs.SearchStartAddress;
            this.Cursor = Cursors.Default;
        }

        private void btnSearchM_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SingleSearch();
            toolStripStatusLabelLocationValue.Text = GlobalSpecs.SearchStartAddress;
            this.Cursor = Cursors.Default;
        }

        private bool AutoSearch()
        {
            try
            {
                GlobalSpecs.NeedReSearch = false;
                GlobalSpecs.RoleStartAddress.Clear();

                if (GlobalSpecs.FDPSProcess.HasExited)
                {
                    gBoxProcess.Text = "进程   无";
                    gboxSearch.Enabled = false;
                    MessageBox.Show("游戏不存在!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                FrmAutoSerachQuestion fq = new FrmAutoSerachQuestion();
                if (fq.ShowDialog() == DialogResult.OK)
                {
                    GlobalSpecs.SearchType = fq.SearchType;
                }
                else
                {
                    return false;
                }

                int[] magicData;
                magicData = Win32Lib.MagicDataLandis;

                Win32Lib.ProgramProcess = GlobalSpecs.FDPSProcess;
                int baseAddress = Win32Lib.SearchMemory(magicData, 1, -40);
                if (baseAddress == -1)
                {
                    magicData = Win32Lib.MagicDataFalianNa;
                    baseAddress = Win32Lib.SearchMemory(magicData, 1, -40);
                }
                if (baseAddress == -1)
                {
                    MessageBox.Show("抱歉，没找到!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                string startAddress = Win32Lib.GetAddress(baseAddress);
                GlobalSpecs.SearchStartAddress = startAddress;
                GlobalSpecs.RoleStartAddress.AddRange(Win32Lib.GetAllRoleByStartAddress(startAddress));

                List<Role> friendsRoleList = new List<Role>();
                List<Role> enemyRoleList = new List<Role>();
                List<Role> NpcRoleList = new List<Role>();

                for (int i = 0; i < GlobalSpecs.RoleStartAddress.Count; i++)
                {
                    Role role = new Role(GlobalSpecs.RoleStartAddress[i]);
                    role.FillData();

                    if (role.M48_MaxHP.IntVal == 0 ||
                        role.M34_等级.IntVal == 0 ||
                        role.M44_移动.IntVal == 0 ||
                        role.M53_HIT.IntVal == 0 ||
                        role.M06_是否可动.IntVal == 1)
                    {
                        continue;
                    }

                    switch (role.M07_人物阵营.IntVal)
                    {
                        case 0:
                            enemyRoleList.Add(role);
                            break;
                        case 1:
                            NpcRoleList.Add(role);
                            break;
                        case 2:
                            friendsRoleList.Add(role);
                            break;
                        default:
                            break;
                    }
                }


                fLPanelFriend.Controls.Clear();
                fLPanelEnemy.Controls.Clear();
                fLPanelNPC.Controls.Clear();

                FillFlowLayoutPanel(fLPanelFriend, friendsRoleList);
                FillFlowLayoutPanel(fLPanelNPC, NpcRoleList);
                FillFlowLayoutPanel(fLPanelEnemy, enemyRoleList);

                MessageBox.Show("找到了！选角色开始改吧。", "好消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错啦！" + Environment.NewLine + "去贴吧找我。记得保留存档，以及出错情况介绍 。", "坏了", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return true;
        }

        private bool SingleSearch()
        {
            GlobalSpecs.NeedReSearch = false;
            if (GlobalSpecs.FDPSProcess.HasExited)
            {
                gBoxProcess.Text = "进程   无";
                gboxSearch.Enabled = false;
                MessageBox.Show("游戏不存在!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtSNowHP.Text == "" ||
                txtSMaxHP.Text == "" ||
                txtSNowMP.Text == "" ||
                txtSMaxMP.Text == "" ||
                txtSAP.Text == "" ||
                txtSDP.Text == "")
            {
                MessageBox.Show("所有条件必须都填!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            FrmAutoSerachQuestion fq = new FrmAutoSerachQuestion();
            if (fq.ShowDialog() == DialogResult.OK)
            {
                GlobalSpecs.SearchType = fq.SearchType;
            }
            else
            {
                return false;
            }

            //GlobalSpecs.SearchType = MemorySearchType.self;

            int lNowHP;
            int lMaxHP;
            int lNowMP;
            int lMaxMP;
            int lAP;
            int lDP;

            int.TryParse(txtSNowHP.Text, out lNowHP);
            int.TryParse(txtSMaxHP.Text, out lMaxHP);
            int.TryParse(txtSNowMP.Text, out lNowMP);
            int.TryParse(txtSMaxMP.Text, out lMaxMP);
            int.TryParse(txtSAP.Text, out lAP);
            int.TryParse(txtSDP.Text, out lDP);

            Win32Lib.ProgramProcess = GlobalSpecs.FDPSProcess;
            int[] sampleData = new int[6];
            sampleData[0] = lNowHP;
            sampleData[1] = lMaxHP;
            sampleData[2] = lNowMP;
            sampleData[3] = lMaxMP;
            sampleData[4] = lAP;
            sampleData[5] = lDP;

            int baseAddress = Win32Lib.SearchMemory(sampleData, 2, -64);
            if (baseAddress == -1)
            {
                MessageBox.Show("抱歉，没找到!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string startAddress = Win32Lib.GetAddress(baseAddress);

            if (!Win32Lib.IsCorrectStartAddress(startAddress))
            {
                MessageBox.Show("抱歉，没找到!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            GlobalSpecs.SearchStartAddress = startAddress;

            Role role = new Role(GlobalSpecs.SearchStartAddress);
            role.FillData();
            
            frmRoleInfo roleInfo = new frmRoleInfo(role);
            roleInfo.ShowDialog();

            return true;
        }

        private void FillFlowLayoutPanel(FlowLayoutPanel panel, List<Role> roleList)
        {
            for (int i = 0; i < roleList.Count; i++)
            {
                PictureBox facePic = new PictureBox();
                facePic.Image = RoleLib.GetFace(roleList[i].M08_人物肖像职业);
                facePic.Location = new Point(3, 3);
                facePic.Name = "face";
                facePic.Size = new Size(128, 100);
                facePic.Tag = roleList[i];
                facePic.TabIndex = 0;
                facePic.TabStop = false;
                facePic.DoubleClick += FacePic_DoubleClick;
                panel.Controls.Add(facePic);
            }
        }

        private void FacePic_DoubleClick(object sender, EventArgs e)
        {
            Role currentRole = (Role)((PictureBox)sender).Tag;

            if (!Win32Lib.IsCorrectStartAddress(currentRole.Address))
            {
                GlobalSpecs.NeedReSearch = true;
                MessageBox.Show("内存地址已变动，请重新查找。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                frmRoleInfo roleInfo = new frmRoleInfo(currentRole);
                roleInfo.ShowDialog();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Icon = ComLib.GetIcon(Properties.Resources.Main);
            toolStripStatusLabLocation.Alignment = ToolStripItemAlignment.Right;
            toolStripStatusLabelLocationValue.Alignment = ToolStripItemAlignment.Right;
            GlobalSpecs.MainForm = this;
            GlobalSpecs.Initialize();

            //DeveloperMode();
        }

        private void 除错ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebugForm df = new DebugForm(GlobalSpecs.FDPSProcess, GlobalSpecs.SearchStartAddress);
            df.Show();
        }

        private void listBoxFriend_DoubleClick(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedIndex >= 0)
            {
                Role currentRole = (Role)((ListBox)sender).SelectedValue;
                frmRoleInfo roleInfo = new frmRoleInfo(currentRole);
                roleInfo.Show();
            }
        }


        private void txtSearchCond_TextChanged(object sender, EventArgs e)
        {
            TextBox currenttxtBox = (TextBox)sender;

            if (currenttxtBox.Text == "")
            {
                return;
            }

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

        private void 总在最上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            总在最上ToolStripMenuItem.Checked = !总在最上ToolStripMenuItem.Checked;
            GlobalSpecs.TopMost = 总在最上ToolStripMenuItem.Checked;
            this.TopMost = GlobalSpecs.TopMost;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 版本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }

        private void UPdateState()
        {
            if (GlobalSpecs.FDPSProcess != null && !GlobalSpecs.FDPSProcess.HasExited)
            {
                Win32Lib.UpdateSearchType();
                if (GlobalSpecs.MagicLocationAddress != "")
                {
                    if (GlobalSpecs.SearchType == MemorySearchType.battle)
                    {
                        toolStripStatusLabLocation.Text = "战场";
                        toolStripStatusLabelLocationValue.Text = GlobalSpecs.MagicLocationAddress + " " + GlobalSpecs.RoundCount;
                    }
                    else
                    {
                        toolStripStatusLabLocation.Text = "商店";
                        toolStripStatusLabelLocationValue.Text = GlobalSpecs.MagicLocationAddress + " " + GlobalSpecs.RoundCount;
                    }
                    return;
                }
            }

            toolStripStatusLabLocation.Text = "";
            toolStripStatusLabelLocationValue.Text = "";
        }


        public void DeveloperMode()
        {
            除错ToolStripMenuItem.Visible = true;
            状态ToolStripMenuItem.Visible = true;
            toolStripStatusLabLocation.Visible = true;
            toolStripStatusLabelLocationValue.Visible = true;
        }

        private void 攻略ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string docfile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Doc\fdps.htm");
            if (File.Exists(docfile))
            {
                System.Diagnostics.Process.Start(docfile);
            }
            else
            {
                MessageBox.Show("攻略不见啦！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void 状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UPdateState();
        }
    }
}
