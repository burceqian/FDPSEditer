namespace FDPSEditerFinal
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.labAbout = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxThanks = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::FDPSEditerFinal.Properties.Resources.Logo;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(198, 118);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // labAbout
            // 
            this.labAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labAbout.BackColor = System.Drawing.SystemColors.Window;
            this.labAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labAbout.Font = new System.Drawing.Font("MS Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAbout.Location = new System.Drawing.Point(228, 39);
            this.labAbout.Name = "labAbout";
            this.labAbout.Size = new System.Drawing.Size(398, 91);
            this.labAbout.TabIndex = 1;
            this.labAbout.Text = " - 增加了自动查找功能(目前没问题，也不确定)\r\n - 因为查找方式变了，显示方式也做了调整\r\n - 优化了运行和显示速度\r\n - 使用Framework 4." +
    "0，方便xp用户使用\r\n - 由于修改游戏,需使用管理员权限\r\n";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "  本软件所有资源均来源于网络，仅供学习交流使用，不可用于任何商业用途。使用本软件产生的任何后果，也请由使用者自行承担。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "炎龙骑士团外传-风之纹章修改器 V2.01 简介:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "授权：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "鸣谢：";
            // 
            // richTextBoxThanks
            // 
            this.richTextBoxThanks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxThanks.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxThanks.Font = new System.Drawing.Font("MS Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxThanks.Location = new System.Drawing.Point(11, 250);
            this.richTextBoxThanks.Name = "richTextBoxThanks";
            this.richTextBoxThanks.ReadOnly = true;
            this.richTextBoxThanks.Size = new System.Drawing.Size(615, 257);
            this.richTextBoxThanks.TabIndex = 7;
            this.richTextBoxThanks.Text = resources.GetString("richTextBoxThanks.Text");
            this.richTextBoxThanks.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxThanks_LinkClicked);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(615, 96);
            this.label5.TabIndex = 8;
            this.label5.Text = "  本来早做这个版本，由于事情太多(懒)，一直耽误着。向还对我有所期待的朋友说声抱歉。\r\n  这个是专门给我这种虽然手残，但是还想体验游戏，还想一次得到全部物品的" +
    "人用的。大神估计用不着。\r\n  1.0版手动查找太麻烦，2.0版做了半自动查找，应该足够方便了。\r\n 这个版本有时候还是会错，各位多包涵。";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "最后的废话：";
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 639);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBoxThanks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labAbout);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label labAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxThanks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}