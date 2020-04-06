namespace FDPSEditerFinal
{
    partial class FrmItemSelect
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
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exist = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Special = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comBoxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Code,
            this.Category,
            this.AP,
            this.DP,
            this.HIT,
            this.EV,
            this.Range,
            this.Exist,
            this.Price,
            this.Special});
            this.dataGridViewItems.Location = new System.Drawing.Point(12, 48);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.RowTemplate.Height = 24;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(1163, 513);
            this.dataGridViewItems.TabIndex = 0;
            this.dataGridViewItems.DoubleClick += new System.EventHandler(this.dataGridViewItems_DoubleClick);
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "Name";
            this.ItemName.HeaderText = "名称";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 102;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "物品代码";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 102;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "分类";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 101;
            // 
            // AP
            // 
            this.AP.DataPropertyName = "AP";
            this.AP.HeaderText = "AP";
            this.AP.Name = "AP";
            this.AP.ReadOnly = true;
            this.AP.Width = 102;
            // 
            // DP
            // 
            this.DP.DataPropertyName = "DP";
            this.DP.HeaderText = "DP";
            this.DP.Name = "DP";
            this.DP.ReadOnly = true;
            this.DP.Width = 102;
            // 
            // HIT
            // 
            this.HIT.DataPropertyName = "HIT";
            this.HIT.HeaderText = "HIT";
            this.HIT.Name = "HIT";
            this.HIT.ReadOnly = true;
            this.HIT.Width = 102;
            // 
            // EV
            // 
            this.EV.DataPropertyName = "EV";
            this.EV.HeaderText = "EV";
            this.EV.Name = "EV";
            this.EV.ReadOnly = true;
            this.EV.Width = 102;
            // 
            // Range
            // 
            this.Range.DataPropertyName = "Range";
            this.Range.HeaderText = "射程";
            this.Range.Name = "Range";
            this.Range.ReadOnly = true;
            this.Range.Width = 102;
            // 
            // Exist
            // 
            this.Exist.DataPropertyName = "Exist";
            this.Exist.HeaderText = "可否获得";
            this.Exist.Name = "Exist";
            this.Exist.ReadOnly = true;
            this.Exist.Width = 101;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "价格";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 102;
            // 
            // Special
            // 
            this.Special.DataPropertyName = "Special";
            this.Special.HeaderText = "特效";
            this.Special.Name = "Special";
            this.Special.ReadOnly = true;
            this.Special.Width = 102;
            // 
            // comBoxCategory
            // 
            this.comBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxCategory.FormattingEnabled = true;
            this.comBoxCategory.Location = new System.Drawing.Point(54, 11);
            this.comBoxCategory.Name = "comBoxCategory";
            this.comBoxCategory.Size = new System.Drawing.Size(121, 24);
            this.comBoxCategory.TabIndex = 1;
            this.comBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comBoxCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "分类";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(949, 567);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(105, 55);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确认";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(1070, 567);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 55);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmItemSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 634);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comBoxCategory);
            this.Controls.Add(this.dataGridViewItems);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmItemSelect";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物品选择";
            this.Load += new System.EventHandler(this.FrmItemSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.ComboBox comBoxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn AP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DP;
        private System.Windows.Forms.DataGridViewTextBoxColumn HIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn EV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Range;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Exist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Special;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}