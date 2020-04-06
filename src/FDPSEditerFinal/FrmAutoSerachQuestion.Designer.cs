namespace FDPSEditerFinal
{
    partial class FrmAutoSerachQuestion
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
            this.btnFight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFight
            // 
            this.btnFight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFight.Location = new System.Drawing.Point(11, 57);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(99, 67);
            this.btnFight.TabIndex = 0;
            this.btnFight.Text = "战场";
            this.btnFight.UseVisualStyleBackColor = true;
            this.btnFight.Click += new System.EventHandler(this.btnFight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "您现在在哪里？";
            // 
            // btnShop
            // 
            this.btnShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.Location = new System.Drawing.Point(116, 57);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(99, 67);
            this.btnShop.TabIndex = 2;
            this.btnShop.Text = "商店";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // FrmAutoSerachQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 139);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFight);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAutoSerachQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "问题";
            this.Load += new System.EventHandler(this.FrmAutoSerachQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShop;
    }
}