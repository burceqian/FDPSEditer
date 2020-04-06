namespace FDPSEditerFinal
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gBoxProcess = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gboxSearch = new System.Windows.Forms.GroupBox();
            this.tabControlSearch = new System.Windows.Forms.TabControl();
            this.tabPageAutoSearch = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabPageManualSearch = new System.Windows.Forms.TabPage();
            this.btnSearchM = new System.Windows.Forms.Button();
            this.txtSMaxHP = new System.Windows.Forms.TextBox();
            this.txtSDP = new System.Windows.Forms.TextBox();
            this.txtSNowHP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSAP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSNowMP = new System.Windows.Forms.TextBox();
            this.txtSMaxMP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFriend = new System.Windows.Forms.TabPage();
            this.fLPanelFriend = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageEnemy = new System.Windows.Forms.TabPage();
            this.fLPanelEnemy = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageNPC = new System.Windows.Forms.TabPage();
            this.fLPanelNPC = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.攻略ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.总在最上ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.攻略ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.除错ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripFoot = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLocationValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.gBoxProcess.SuspendLayout();
            this.gboxSearch.SuspendLayout();
            this.tabControlSearch.SuspendLayout();
            this.tabPageAutoSearch.SuspendLayout();
            this.tabPageManualSearch.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageFriend.SuspendLayout();
            this.tabPageEnemy.SuspendLayout();
            this.tabPageNPC.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStripFoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxProcess
            // 
            this.gBoxProcess.Controls.Add(this.btnRefresh);
            this.gBoxProcess.Location = new System.Drawing.Point(13, 32);
            this.gBoxProcess.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxProcess.Name = "gBoxProcess";
            this.gBoxProcess.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxProcess.Size = new System.Drawing.Size(139, 137);
            this.gBoxProcess.TabIndex = 1;
            this.gBoxProcess.TabStop = false;
            this.gBoxProcess.Text = "进程   无";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(8, 22);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(123, 105);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "选择游戏";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gboxSearch
            // 
            this.gboxSearch.Controls.Add(this.tabControlSearch);
            this.gboxSearch.Enabled = false;
            this.gboxSearch.Location = new System.Drawing.Point(160, 32);
            this.gboxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.gboxSearch.Name = "gboxSearch";
            this.gboxSearch.Padding = new System.Windows.Forms.Padding(4);
            this.gboxSearch.Size = new System.Drawing.Size(342, 137);
            this.gboxSearch.TabIndex = 4;
            this.gboxSearch.TabStop = false;
            this.gboxSearch.Text = "检索";
            // 
            // tabControlSearch
            // 
            this.tabControlSearch.Controls.Add(this.tabPageAutoSearch);
            this.tabControlSearch.Controls.Add(this.tabPageManualSearch);
            this.tabControlSearch.Location = new System.Drawing.Point(15, 22);
            this.tabControlSearch.Name = "tabControlSearch";
            this.tabControlSearch.SelectedIndex = 0;
            this.tabControlSearch.Size = new System.Drawing.Size(319, 102);
            this.tabControlSearch.TabIndex = 0;
            // 
            // tabPageAutoSearch
            // 
            this.tabPageAutoSearch.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAutoSearch.Controls.Add(this.btnSearch);
            this.tabPageAutoSearch.Location = new System.Drawing.Point(4, 25);
            this.tabPageAutoSearch.Name = "tabPageAutoSearch";
            this.tabPageAutoSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAutoSearch.Size = new System.Drawing.Size(311, 73);
            this.tabPageAutoSearch.TabIndex = 0;
            this.tabPageAutoSearch.Text = "自动";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(7, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(292, 55);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "自动查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabPageManualSearch
            // 
            this.tabPageManualSearch.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageManualSearch.Controls.Add(this.btnSearchM);
            this.tabPageManualSearch.Controls.Add(this.txtSMaxHP);
            this.tabPageManualSearch.Controls.Add(this.txtSDP);
            this.tabPageManualSearch.Controls.Add(this.txtSNowHP);
            this.tabPageManualSearch.Controls.Add(this.label1);
            this.tabPageManualSearch.Controls.Add(this.label6);
            this.tabPageManualSearch.Controls.Add(this.label2);
            this.tabPageManualSearch.Controls.Add(this.txtSAP);
            this.tabPageManualSearch.Controls.Add(this.label3);
            this.tabPageManualSearch.Controls.Add(this.label5);
            this.tabPageManualSearch.Controls.Add(this.txtSNowMP);
            this.tabPageManualSearch.Controls.Add(this.txtSMaxMP);
            this.tabPageManualSearch.Controls.Add(this.label4);
            this.tabPageManualSearch.Location = new System.Drawing.Point(4, 25);
            this.tabPageManualSearch.Name = "tabPageManualSearch";
            this.tabPageManualSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManualSearch.Size = new System.Drawing.Size(311, 73);
            this.tabPageManualSearch.TabIndex = 1;
            this.tabPageManualSearch.Text = "手动";
            // 
            // btnSearchM
            // 
            this.btnSearchM.Location = new System.Drawing.Point(210, 13);
            this.btnSearchM.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchM.Name = "btnSearchM";
            this.btnSearchM.Size = new System.Drawing.Size(93, 54);
            this.btnSearchM.TabIndex = 25;
            this.btnSearchM.Text = "查找";
            this.btnSearchM.UseVisualStyleBackColor = true;
            this.btnSearchM.Click += new System.EventHandler(this.btnSearchM_Click);
            // 
            // txtSMaxHP
            // 
            this.txtSMaxHP.Location = new System.Drawing.Point(92, 13);
            this.txtSMaxHP.Margin = new System.Windows.Forms.Padding(4);
            this.txtSMaxHP.MaxLength = 5;
            this.txtSMaxHP.Name = "txtSMaxHP";
            this.txtSMaxHP.Size = new System.Drawing.Size(41, 22);
            this.txtSMaxHP.TabIndex = 14;
            this.txtSMaxHP.TextChanged += new System.EventHandler(this.txtSearchCond_TextChanged);
            // 
            // txtSDP
            // 
            this.txtSDP.Location = new System.Drawing.Point(163, 44);
            this.txtSDP.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDP.MaxLength = 5;
            this.txtSDP.Name = "txtSDP";
            this.txtSDP.Size = new System.Drawing.Size(41, 22);
            this.txtSDP.TabIndex = 20;
            this.txtSDP.TextChanged += new System.EventHandler(this.txtSearchCond_TextChanged);
            // 
            // txtSNowHP
            // 
            this.txtSNowHP.Location = new System.Drawing.Point(32, 12);
            this.txtSNowHP.Margin = new System.Windows.Forms.Padding(4);
            this.txtSNowHP.MaxLength = 5;
            this.txtSNowHP.Name = "txtSNowHP";
            this.txtSNowHP.Size = new System.Drawing.Size(41, 22);
            this.txtSNowHP.TabIndex = 13;
            this.txtSNowHP.TextChanged += new System.EventHandler(this.txtSearchCond_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "DP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "/";
            // 
            // txtSAP
            // 
            this.txtSAP.Location = new System.Drawing.Point(163, 16);
            this.txtSAP.Margin = new System.Windows.Forms.Padding(4);
            this.txtSAP.MaxLength = 5;
            this.txtSAP.Name = "txtSAP";
            this.txtSAP.Size = new System.Drawing.Size(41, 22);
            this.txtSAP.TabIndex = 19;
            this.txtSAP.TextChanged += new System.EventHandler(this.txtSearchCond_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "MP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "AP";
            // 
            // txtSNowMP
            // 
            this.txtSNowMP.Location = new System.Drawing.Point(32, 46);
            this.txtSNowMP.Margin = new System.Windows.Forms.Padding(4);
            this.txtSNowMP.MaxLength = 5;
            this.txtSNowMP.Name = "txtSNowMP";
            this.txtSNowMP.Size = new System.Drawing.Size(41, 22);
            this.txtSNowMP.TabIndex = 16;
            this.txtSNowMP.TextChanged += new System.EventHandler(this.txtSearchCond_TextChanged);
            // 
            // txtSMaxMP
            // 
            this.txtSMaxMP.Location = new System.Drawing.Point(92, 44);
            this.txtSMaxMP.Margin = new System.Windows.Forms.Padding(4);
            this.txtSMaxMP.MaxLength = 5;
            this.txtSMaxMP.Name = "txtSMaxMP";
            this.txtSMaxMP.Size = new System.Drawing.Size(41, 22);
            this.txtSMaxMP.TabIndex = 17;
            this.txtSMaxMP.TextChanged += new System.EventHandler(this.txtSearchCond_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "/";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageFriend);
            this.tabControl1.Controls.Add(this.tabPageEnemy);
            this.tabControl1.Controls.Add(this.tabPageNPC);
            this.tabControl1.Location = new System.Drawing.Point(13, 176);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(489, 349);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPageFriend
            // 
            this.tabPageFriend.Controls.Add(this.fLPanelFriend);
            this.tabPageFriend.Location = new System.Drawing.Point(4, 25);
            this.tabPageFriend.Name = "tabPageFriend";
            this.tabPageFriend.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFriend.Size = new System.Drawing.Size(481, 320);
            this.tabPageFriend.TabIndex = 0;
            this.tabPageFriend.Text = "己方";
            this.tabPageFriend.UseVisualStyleBackColor = true;
            // 
            // fLPanelFriend
            // 
            this.fLPanelFriend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fLPanelFriend.AutoScroll = true;
            this.fLPanelFriend.Location = new System.Drawing.Point(9, 6);
            this.fLPanelFriend.Name = "fLPanelFriend";
            this.fLPanelFriend.Size = new System.Drawing.Size(464, 308);
            this.fLPanelFriend.TabIndex = 0;
            // 
            // tabPageEnemy
            // 
            this.tabPageEnemy.Controls.Add(this.fLPanelEnemy);
            this.tabPageEnemy.Location = new System.Drawing.Point(4, 25);
            this.tabPageEnemy.Name = "tabPageEnemy";
            this.tabPageEnemy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEnemy.Size = new System.Drawing.Size(481, 320);
            this.tabPageEnemy.TabIndex = 1;
            this.tabPageEnemy.Text = "敌方";
            this.tabPageEnemy.UseVisualStyleBackColor = true;
            // 
            // fLPanelEnemy
            // 
            this.fLPanelEnemy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fLPanelEnemy.AutoScroll = true;
            this.fLPanelEnemy.Location = new System.Drawing.Point(9, 6);
            this.fLPanelEnemy.Name = "fLPanelEnemy";
            this.fLPanelEnemy.Size = new System.Drawing.Size(464, 308);
            this.fLPanelEnemy.TabIndex = 1;
            // 
            // tabPageNPC
            // 
            this.tabPageNPC.Controls.Add(this.fLPanelNPC);
            this.tabPageNPC.Location = new System.Drawing.Point(4, 25);
            this.tabPageNPC.Name = "tabPageNPC";
            this.tabPageNPC.Size = new System.Drawing.Size(481, 320);
            this.tabPageNPC.TabIndex = 2;
            this.tabPageNPC.Text = "NPC";
            this.tabPageNPC.UseVisualStyleBackColor = true;
            // 
            // fLPanelNPC
            // 
            this.fLPanelNPC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fLPanelNPC.AutoScroll = true;
            this.fLPanelNPC.Location = new System.Drawing.Point(8, 6);
            this.fLPanelNPC.Name = "fLPanelNPC";
            this.fLPanelNPC.Size = new System.Drawing.Size(464, 311);
            this.fLPanelNPC.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.攻略ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(509, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 攻略ToolStripMenuItem
            // 
            this.攻略ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.总在最上ToolStripMenuItem,
            this.攻略ToolStripMenuItem1,
            this.除错ToolStripMenuItem,
            this.状态ToolStripMenuItem});
            this.攻略ToolStripMenuItem.Name = "攻略ToolStripMenuItem";
            this.攻略ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.攻略ToolStripMenuItem.Text = "功能";
            // 
            // 总在最上ToolStripMenuItem
            // 
            this.总在最上ToolStripMenuItem.Name = "总在最上ToolStripMenuItem";
            this.总在最上ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.总在最上ToolStripMenuItem.Text = "总在最上";
            this.总在最上ToolStripMenuItem.Visible = false;
            this.总在最上ToolStripMenuItem.Click += new System.EventHandler(this.总在最上ToolStripMenuItem_Click);
            // 
            // 攻略ToolStripMenuItem1
            // 
            this.攻略ToolStripMenuItem1.Name = "攻略ToolStripMenuItem1";
            this.攻略ToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.攻略ToolStripMenuItem1.Text = "攻略";
            this.攻略ToolStripMenuItem1.Click += new System.EventHandler(this.攻略ToolStripMenuItem1_Click);
            // 
            // 除错ToolStripMenuItem
            // 
            this.除错ToolStripMenuItem.Name = "除错ToolStripMenuItem";
            this.除错ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.除错ToolStripMenuItem.Text = "除错";
            this.除错ToolStripMenuItem.Visible = false;
            this.除错ToolStripMenuItem.Click += new System.EventHandler(this.除错ToolStripMenuItem_Click);
            // 
            // 状态ToolStripMenuItem
            // 
            this.状态ToolStripMenuItem.Name = "状态ToolStripMenuItem";
            this.状态ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.状态ToolStripMenuItem.Text = "状态";
            this.状态ToolStripMenuItem.Visible = false;
            this.状态ToolStripMenuItem.Click += new System.EventHandler(this.状态ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.版本ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 版本ToolStripMenuItem
            // 
            this.版本ToolStripMenuItem.Name = "版本ToolStripMenuItem";
            this.版本ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.版本ToolStripMenuItem.Text = "版本";
            this.版本ToolStripMenuItem.Click += new System.EventHandler(this.版本ToolStripMenuItem_Click);
            // 
            // statusStripFoot
            // 
            this.statusStripFoot.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripFoot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabLocation,
            this.toolStripStatusLabelLocationValue});
            this.statusStripFoot.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStripFoot.Location = new System.Drawing.Point(0, 531);
            this.statusStripFoot.Name = "statusStripFoot";
            this.statusStripFoot.Size = new System.Drawing.Size(509, 22);
            this.statusStripFoot.TabIndex = 10;
            this.statusStripFoot.Text = "statusStrip1";
            // 
            // toolStripStatusLabLocation
            // 
            this.toolStripStatusLabLocation.Name = "toolStripStatusLabLocation";
            this.toolStripStatusLabLocation.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabLocation.Text = " ";
            this.toolStripStatusLabLocation.Visible = false;
            // 
            // toolStripStatusLabelLocationValue
            // 
            this.toolStripStatusLabelLocationValue.Name = "toolStripStatusLabelLocationValue";
            this.toolStripStatusLabelLocationValue.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabelLocationValue.Text = " ";
            this.toolStripStatusLabelLocationValue.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 553);
            this.Controls.Add(this.statusStripFoot);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gboxSearch);
            this.Controls.Add(this.gBoxProcess);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "炎龙风纹修改器 V2.01 (by 龙口袋)";
            this.Activated += new System.EventHandler(this.FrmMain_Activated);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gBoxProcess.ResumeLayout(false);
            this.gboxSearch.ResumeLayout(false);
            this.tabControlSearch.ResumeLayout(false);
            this.tabPageAutoSearch.ResumeLayout(false);
            this.tabPageManualSearch.ResumeLayout(false);
            this.tabPageManualSearch.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageFriend.ResumeLayout(false);
            this.tabPageEnemy.ResumeLayout(false);
            this.tabPageNPC.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStripFoot.ResumeLayout(false);
            this.statusStripFoot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxProcess;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox gboxSearch;
        private System.Windows.Forms.TabControl tabControlSearch;
        private System.Windows.Forms.TabPage tabPageAutoSearch;
        private System.Windows.Forms.TabPage tabPageManualSearch;
        private System.Windows.Forms.Button btnSearchM;
        private System.Windows.Forms.TextBox txtSDP;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSAP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSMaxMP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSNowMP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSMaxHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSNowHP;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFriend;
        private System.Windows.Forms.TabPage tabPageEnemy;
        private System.Windows.Forms.FlowLayoutPanel fLPanelFriend;
        private System.Windows.Forms.FlowLayoutPanel fLPanelEnemy;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 攻略ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 总在最上ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 攻略ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 除错ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripFoot;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabLocation;
        private System.Windows.Forms.TabPage tabPageNPC;
        private System.Windows.Forms.FlowLayoutPanel fLPanelNPC;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLocationValue;
        private System.Windows.Forms.ToolStripMenuItem 状态ToolStripMenuItem;
    }
}