namespace FDPSEditerFinal
{
    partial class FrmMagicSelect
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
            this.listBoxMagic1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labJob = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxMagicRole = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.comJob = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comBoxRole = new System.Windows.Forms.ComboBox();
            this.listBoxMagic2 = new System.Windows.Forms.ListBox();
            this.listBoxMagic3 = new System.Windows.Forms.ListBox();
            this.listBoxMagic4 = new System.Windows.Forms.ListBox();
            this.listBoxMagic5 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxMagic1
            // 
            this.listBoxMagic1.DisplayMember = "Name";
            this.listBoxMagic1.FormattingEnabled = true;
            this.listBoxMagic1.ItemHeight = 16;
            this.listBoxMagic1.Items.AddRange(new object[] {
            "暴雷绝击",
            "奔雷弹",
            "落雷术",
            "圣光柱",
            "光之箭",
            "烈狱之火",
            "狂暴巨焰",
            "业火"});
            this.listBoxMagic1.Location = new System.Drawing.Point(12, 12);
            this.listBoxMagic1.Name = "listBoxMagic1";
            this.listBoxMagic1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxMagic1.Size = new System.Drawing.Size(88, 132);
            this.listBoxMagic1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labJob);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listBoxMagicRole);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.comJob);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comBoxRole);
            this.groupBox1.Location = new System.Drawing.Point(12, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 199);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参考";
            // 
            // labJob
            // 
            this.labJob.AutoSize = true;
            this.labJob.Location = new System.Drawing.Point(337, 31);
            this.labJob.Name = "labJob";
            this.labJob.Size = new System.Drawing.Size(0, 17);
            this.labJob.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "职业";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "请不要选择非本角色之外的魔法。\r\n有可能使游戏崩溃！";
            // 
            // listBoxMagicRole
            // 
            this.listBoxMagicRole.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBoxMagicRole.FormattingEnabled = true;
            this.listBoxMagicRole.ItemHeight = 16;
            this.listBoxMagicRole.Items.AddRange(new object[] {
            "万神降临",
            "极度冰冻",
            "冰魔超速弹",
            "暴炎狂龙",
            "圣龙烈霸斩",
            "超重力黑洞",
            "镇魂之歌",
            "审判之雷"});
            this.listBoxMagicRole.Location = new System.Drawing.Point(19, 58);
            this.listBoxMagicRole.Name = "listBoxMagicRole";
            this.listBoxMagicRole.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxMagicRole.Size = new System.Drawing.Size(169, 132);
            this.listBoxMagicRole.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(352, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 43);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(226, 128);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(89, 43);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确认";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // comJob
            // 
            this.comJob.DisplayMember = "DisplayName";
            this.comJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comJob.FormattingEnabled = true;
            this.comJob.Location = new System.Drawing.Point(199, 28);
            this.comJob.Name = "comJob";
            this.comJob.Size = new System.Drawing.Size(77, 24);
            this.comJob.TabIndex = 3;
            this.comJob.SelectedIndexChanged += new System.EventHandler(this.comJob_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "类型";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "角色";
            // 
            // comBoxRole
            // 
            this.comBoxRole.DisplayMember = "Role";
            this.comBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxRole.FormattingEnabled = true;
            this.comBoxRole.Location = new System.Drawing.Point(58, 28);
            this.comBoxRole.Name = "comBoxRole";
            this.comBoxRole.Size = new System.Drawing.Size(80, 24);
            this.comBoxRole.TabIndex = 0;
            this.comBoxRole.SelectedIndexChanged += new System.EventHandler(this.comBoxRole_SelectedIndexChanged);
            // 
            // listBoxMagic2
            // 
            this.listBoxMagic2.DisplayMember = "Name";
            this.listBoxMagic2.FormattingEnabled = true;
            this.listBoxMagic2.ItemHeight = 16;
            this.listBoxMagic2.Items.AddRange(new object[] {
            "治愈之风",
            "恢复之光",
            "鬼动死灵阵",
            "震空重力弹",
            "封神裂震",
            "裂地术",
            "绝杀冰封",
            "冰暴术"});
            this.listBoxMagic2.Location = new System.Drawing.Point(106, 12);
            this.listBoxMagic2.Name = "listBoxMagic2";
            this.listBoxMagic2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxMagic2.Size = new System.Drawing.Size(88, 132);
            this.listBoxMagic2.TabIndex = 5;
            // 
            // listBoxMagic3
            // 
            this.listBoxMagic3.DisplayMember = "Name";
            this.listBoxMagic3.FormattingEnabled = true;
            this.listBoxMagic3.ItemHeight = 16;
            this.listBoxMagic3.Items.AddRange(new object[] {
            "咒杀术",
            "神行术",
            "传送术",
            "神之祝福",
            "麻痹术",
            "腐毒术",
            "封魔咒术",
            "痊愈之泉"});
            this.listBoxMagic3.Location = new System.Drawing.Point(200, 12);
            this.listBoxMagic3.Name = "listBoxMagic3";
            this.listBoxMagic3.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxMagic3.Size = new System.Drawing.Size(88, 132);
            this.listBoxMagic3.TabIndex = 6;
            // 
            // listBoxMagic4
            // 
            this.listBoxMagic4.DisplayMember = "Name";
            this.listBoxMagic4.FormattingEnabled = true;
            this.listBoxMagic4.ItemHeight = 16;
            this.listBoxMagic4.Items.AddRange(new object[] {
            "灵弹超必杀",
            "流星箭",
            "轰神炮",
            "狱炎烈破弹",
            "金刚斩",
            "强力冲击",
            "魔龙霸炎",
            "苏愈术"});
            this.listBoxMagic4.Location = new System.Drawing.Point(294, 12);
            this.listBoxMagic4.Name = "listBoxMagic4";
            this.listBoxMagic4.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxMagic4.Size = new System.Drawing.Size(88, 132);
            this.listBoxMagic4.TabIndex = 7;
            // 
            // listBoxMagic5
            // 
            this.listBoxMagic5.DisplayMember = "Name";
            this.listBoxMagic5.FormattingEnabled = true;
            this.listBoxMagic5.ItemHeight = 16;
            this.listBoxMagic5.Items.AddRange(new object[] {
            "万神降临",
            "极度冰冻",
            "冰魔超速弹",
            "暴炎狂龙",
            "圣龙烈霸斩",
            "超重力黑洞",
            "镇魂之歌",
            "审判之雷"});
            this.listBoxMagic5.Location = new System.Drawing.Point(388, 12);
            this.listBoxMagic5.Name = "listBoxMagic5";
            this.listBoxMagic5.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxMagic5.Size = new System.Drawing.Size(88, 132);
            this.listBoxMagic5.TabIndex = 8;
            // 
            // FrmMagicSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 360);
            this.Controls.Add(this.listBoxMagic5);
            this.Controls.Add(this.listBoxMagic4);
            this.Controls.Add(this.listBoxMagic3);
            this.Controls.Add(this.listBoxMagic2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxMagic1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMagicSelect";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "魔法选择";
            this.Load += new System.EventHandler(this.FrmMagicSelect_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxMagic1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxMagicRole;
        private System.Windows.Forms.ComboBox comJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBoxRole;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ListBox listBoxMagic2;
        private System.Windows.Forms.ListBox listBoxMagic3;
        private System.Windows.Forms.ListBox listBoxMagic4;
        private System.Windows.Forms.ListBox listBoxMagic5;
        private System.Windows.Forms.Label labJob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}