namespace FDPSEditerFinal
{
    partial class FrmProcess
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
            this.listViewProcess = new System.Windows.Forms.ListView();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewProcess
            // 
            this.listViewProcess.Location = new System.Drawing.Point(4, 5);
            this.listViewProcess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewProcess.Name = "listViewProcess";
            this.listViewProcess.Size = new System.Drawing.Size(361, 271);
            this.listViewProcess.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewProcess.TabIndex = 0;
            this.listViewProcess.UseCompatibleStateImageBehavior = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(159, 284);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "确认";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(267, 284);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "取消";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.listViewProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProcess";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择游戏程序";
            this.Load += new System.EventHandler(this.FrmProcess_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewProcess;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnBack;
    }
}