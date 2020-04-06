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
    public partial class DebugForm : Form
    {
        private Process NowProcess;
        private string Address;
        private DataTable data = new DataTable();

        private int NowStep = 0;
        private int MoveStep = 480;
        private int OneMoveStep = 80;

        public DebugForm(Process pNowProcess, string pAddress)
        {
            InitializeComponent();
            NowProcess = pNowProcess;
            Address = pAddress;
        }

        private string Read(Process pProcess, string pAddress)
        {
            string lResult = "";

            int searchBytes = 1;
            int numBytesRead = 0;
            byte[] byRead = new byte[searchBytes];
            long num;
            if (Win32Lib.ReadProcessMemory(pProcess.Handle, (IntPtr)Convert.ToInt32(pAddress, 16), byRead, searchBytes, out numBytesRead))
            {
                if (numBytesRead == searchBytes)
                {
                    num = byRead[searchBytes - 1];
                    for (int j = searchBytes, k = 2; j > 1; j--, k++)
                    {
                        num = num << 8;
                        num = num | byRead[searchBytes - k];
                    }

                    lResult = num.ToString();
                }
            }

            if (_ShowHX)
            {
                lResult = int.Parse(lResult).ToString("x8");
                lResult = lResult.Substring(lResult.Length - 2, 2);
            }

            return lResult;
        }

        public string GetMoveAddress(string pAddress, int pMove)
        {
            int x = Convert.ToInt32(pAddress, 16) + pMove;
            string lChangeAddress = x.ToString("x").PadLeft(8,'0');

            return lChangeAddress;
        }

        private void DebugForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DoubleBuffered(true);

            if (string.IsNullOrEmpty(Address))
            {
                return;
            }
            NowStep = MoveStep;

            MoveAndShow(NowStep);
        }

        private void MoveAndShow(int step)
        {
            data = new DataTable();

            for (int i = 0; i < OneMoveStep; i++)
            {
                data.Columns.Add(i.ToString());
            }
            string moveAddress = Address;
            DataRow dr = data.NewRow();
            DataRow dr2 = data.NewRow();


            for (int i = step - MoveStep; i < step; i += OneMoveStep)
            {
                dr = data.NewRow();
                dr2 = data.NewRow();
                moveAddress = Address;
                for (int j = i; j < i + OneMoveStep; j++)
                {
                    moveAddress = GetMoveAddress(Address, j);
                    dr[j - i] = moveAddress + ":" + j.ToString();
                    dr2[j - i] = Read(NowProcess, moveAddress);
                }
                if (data.Rows.Count == 0 || _ShowHeader)
                {
                    data.Rows.Add(dr);
                }
                data.Rows.Add(dr2);
            }

            data.Columns[0].ColumnName = "X";
            data.Columns[1].ColumnName = "Y";
            data.Columns[2].ColumnName = "人物图形";
            data.Columns[3].ColumnName = "人物图形方向";
            data.Columns[4].ColumnName = "人物跑步动作";
            data.Columns[5].ColumnName = "是否可动 00 01 80";
            data.Columns[6].ColumnName = "人物阵营 0 敌人 1 NPC 2 我方";
            data.Columns[7].ColumnName = "人物肖像职业";
            data.Columns[8].ColumnName = "人物名字 不准";
            data.Columns[9].ColumnName = "未知";
            data.Columns[10].ColumnName = "状态1";
            data.Columns[11].ColumnName = "武器1";
            data.Columns[12].ColumnName = "状态2";
            data.Columns[13].ColumnName = "武器2";
            data.Columns[14].ColumnName = "状态3";
            data.Columns[15].ColumnName = "武器3";
            data.Columns[16].ColumnName = "状态4";
            data.Columns[17].ColumnName = "武器4";
            data.Columns[18].ColumnName = "状态5";
            data.Columns[19].ColumnName = "武器5";
            data.Columns[20].ColumnName = "状态6";
            data.Columns[21].ColumnName = "武器6";
            data.Columns[22].ColumnName = "状态7";
            data.Columns[23].ColumnName = "武器7";
            data.Columns[24].ColumnName = "状态8";
            data.Columns[25].ColumnName = "武器8";
            data.Columns[26].ColumnName = "法术1";
            data.Columns[27].ColumnName = "法术2";
            data.Columns[28].ColumnName = "法术3";
            data.Columns[29].ColumnName = "法术4";
            data.Columns[30].ColumnName = "法术5";
            data.Columns[31].ColumnName = "人种";
            data.Columns[32].ColumnName = "职业";
            data.Columns[33].ColumnName = "等级";
            data.Columns[34].ColumnName = "增强AP";
            data.Columns[35].ColumnName = "增强DP";
            data.Columns[36].ColumnName = "增强HIT&EV";
            data.Columns[37].ColumnName = "中毒";
            data.Columns[38].ColumnName = "麻痹";
            data.Columns[39].ColumnName = "禁咒";
            data.Columns[40].ColumnName = "未知1";
            data.Columns[41].ColumnName = "未知2";
            data.Columns[42].ColumnName = "未知3";
            data.Columns[43].ColumnName = "未知4";
            data.Columns[44].ColumnName = "未知5";
            data.Columns[45].ColumnName = "未知6";
            data.Columns[46].ColumnName = "未知7";
            data.Columns[47].ColumnName = "未知8";
            data.Columns[48].ColumnName = "未知9";
            data.Columns[49].ColumnName = "未知10";
            data.Columns[50].ColumnName = "未知11";
            data.Columns[51].ColumnName = "未知12";
            data.Columns[52].ColumnName = "未知13";
            data.Columns[53].ColumnName = "未知14";
            data.Columns[54].ColumnName = "未知15";
            data.Columns[55].ColumnName = "基本AP1";
            data.Columns[56].ColumnName = "基本AP2";
            data.Columns[57].ColumnName = "基本DP1";
            data.Columns[58].ColumnName = "基本DP2";
            data.Columns[59].ColumnName = "移动";
            data.Columns[60].ColumnName = "经验1";
            data.Columns[61].ColumnName = "经验2";
            data.Columns[62].ColumnName = "DX1";
            data.Columns[63].ColumnName = "DX2";
            data.Columns[64].ColumnName = "NHP1";
            data.Columns[65].ColumnName = "NHP2";
            data.Columns[66].ColumnName = "MHP1";
            data.Columns[67].ColumnName = "MHP2";
            data.Columns[68].ColumnName = "NMP1";
            data.Columns[69].ColumnName = "NMP2";
            data.Columns[70].ColumnName = "MMP1";
            data.Columns[71].ColumnName = "MMP2";
            data.Columns[72].ColumnName = "AP1";
            data.Columns[73].ColumnName = "AP2";
            data.Columns[74].ColumnName = "DP1";
            data.Columns[75].ColumnName = "DP2";
            data.Columns[76].ColumnName = "HIT1";
            data.Columns[77].ColumnName = "HIT2";
            data.Columns[78].ColumnName = "EV1";
            data.Columns[79].ColumnName = "EV2";

            dataGridView1.DataSource = data.DefaultView;
        }

        private bool _ShowHeader = true;
        private bool _ShowHX = false;

        private void button1_Click(object sender, EventArgs e)
        {
            int i1 = 0;
            int i2 = 0;
            int.TryParse(textBox1.Text,out i1);
            int.TryParse(textBox2.Text, out i2);

            string adstr = i2.ToString("x").PadLeft(2, '0') + i1.ToString("x").PadLeft(2, '0');

            textBox3.Text = Convert.ToInt32(adstr, 16).ToString();
        }

        private void buttonpreview_Click(object sender, EventArgs e)
        {
            NowStep -= MoveStep;
            MoveAndShow(NowStep);
        }

        private void buttonAfter_Click(object sender, EventArgs e)
        {
            NowStep += MoveStep;
            MoveAndShow(NowStep);
        }

        private void checkBoxHX_CheckedChanged(object sender, EventArgs e)
        {
            _ShowHX = checkBoxHX.Checked;
            MoveAndShow(NowStep);
        }

        private void checkBoxHeader_CheckedChanged(object sender, EventArgs e)
        {
            _ShowHeader = checkBoxHeader.Checked;
            MoveAndShow(NowStep);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Address = txtFixAddress.Text;
            NowStep = 0;
            MoveAndShow(NowStep);
        }
    }
}
