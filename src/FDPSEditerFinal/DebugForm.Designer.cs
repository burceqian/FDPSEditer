namespace FDPSEditerFinal
{
    partial class DebugForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnpreview = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBoxHX = new System.Windows.Forms.CheckBox();
            this.checkBoxHeader = new System.Windows.Forms.CheckBox();
            this.txtFixAddress = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 103);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1011, 495);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 15);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(299, 16);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 22);
            this.textBox3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "计算16进制";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnpreview
            // 
            this.btnpreview.Location = new System.Drawing.Point(819, 12);
            this.btnpreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(100, 28);
            this.btnpreview.TabIndex = 5;
            this.btnpreview.Text = "向前";
            this.btnpreview.UseVisualStyleBackColor = true;
            this.btnpreview.Click += new System.EventHandler(this.buttonpreview_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(927, 12);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "向后";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonAfter_Click);
            // 
            // checkBoxHX
            // 
            this.checkBoxHX.AutoSize = true;
            this.checkBoxHX.Location = new System.Drawing.Point(384, 18);
            this.checkBoxHX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxHX.Name = "checkBoxHX";
            this.checkBoxHX.Size = new System.Drawing.Size(83, 21);
            this.checkBoxHX.TabIndex = 7;
            this.checkBoxHX.Text = "ShowHX";
            this.checkBoxHX.UseVisualStyleBackColor = true;
            this.checkBoxHX.CheckedChanged += new System.EventHandler(this.checkBoxHX_CheckedChanged);
            // 
            // checkBoxHeader
            // 
            this.checkBoxHeader.AutoSize = true;
            this.checkBoxHeader.Checked = true;
            this.checkBoxHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHeader.Location = new System.Drawing.Point(483, 17);
            this.checkBoxHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxHeader.Name = "checkBoxHeader";
            this.checkBoxHeader.Size = new System.Drawing.Size(112, 21);
            this.checkBoxHeader.TabIndex = 8;
            this.checkBoxHeader.Text = "ShowHEader";
            this.checkBoxHeader.UseVisualStyleBackColor = true;
            this.checkBoxHeader.CheckedChanged += new System.EventHandler(this.checkBoxHeader_CheckedChanged);
            // 
            // txtFixAddress
            // 
            this.txtFixAddress.Location = new System.Drawing.Point(16, 58);
            this.txtFixAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtFixAddress.Name = "txtFixAddress";
            this.txtFixAddress.Size = new System.Drawing.Size(80, 22);
            this.txtFixAddress.TabIndex = 9;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(105, 55);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 28);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "查看";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 624);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtFixAddress);
            this.Controls.Add(this.checkBoxHeader);
            this.Controls.Add(this.checkBoxHX);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DebugForm";
            this.Text = "DebugForm";
            this.Load += new System.EventHandler(this.DebugForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnpreview;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBoxHX;
        private System.Windows.Forms.CheckBox checkBoxHeader;
        private System.Windows.Forms.TextBox txtFixAddress;
        private System.Windows.Forms.Button btnShow;
    }
}