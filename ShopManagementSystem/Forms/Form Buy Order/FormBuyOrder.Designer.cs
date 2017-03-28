namespace ShopManagement.Forms.Form_Buy_Order
{
    partial class FormBuyOrder
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.provider_grpbox = new System.Windows.Forms.GroupBox();
            this.prov_combo = new System.Windows.Forms.ComboBox();
            this.Articles_Category_grpbox = new System.Windows.Forms.GroupBox();
            this.ArtC_listbox = new System.Windows.Forms.ListBox();
            this.Articles_dgv = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DateExpected_grpbx = new System.Windows.Forms.GroupBox();
            this.ArrivalDateExpected_dtp = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Search_tb = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.provider_grpbox.SuspendLayout();
            this.Articles_Category_grpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Articles_dgv)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.DateExpected_grpbx.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.89142F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.10858F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.tableLayoutPanel1.Controls.Add(this.provider_grpbox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Articles_Category_grpbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Articles_dgv, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1168, 408);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // provider_grpbox
            // 
            this.provider_grpbox.Controls.Add(this.prov_combo);
            this.provider_grpbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.provider_grpbox.Location = new System.Drawing.Point(3, 3);
            this.provider_grpbox.Name = "provider_grpbox";
            this.provider_grpbox.Size = new System.Drawing.Size(148, 45);
            this.provider_grpbox.TabIndex = 0;
            this.provider_grpbox.TabStop = false;
            this.provider_grpbox.Text = "Provider : ";
            // 
            // prov_combo
            // 
            this.prov_combo.FormattingEnabled = true;
            this.prov_combo.Location = new System.Drawing.Point(6, 19);
            this.prov_combo.Name = "prov_combo";
            this.prov_combo.Size = new System.Drawing.Size(107, 21);
            this.prov_combo.TabIndex = 0;
            this.prov_combo.SelectedValueChanged += new System.EventHandler(this.prov_combo_SelectedValueChanged);
            // 
            // Articles_Category_grpbox
            // 
            this.Articles_Category_grpbox.Controls.Add(this.ArtC_listbox);
            this.Articles_Category_grpbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Articles_Category_grpbox.Location = new System.Drawing.Point(3, 54);
            this.Articles_Category_grpbox.Name = "Articles_Category_grpbox";
            this.Articles_Category_grpbox.Size = new System.Drawing.Size(148, 351);
            this.Articles_Category_grpbox.TabIndex = 1;
            this.Articles_Category_grpbox.TabStop = false;
            this.Articles_Category_grpbox.Text = "Articles Category";
            // 
            // ArtC_listbox
            // 
            this.ArtC_listbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArtC_listbox.FormattingEnabled = true;
            this.ArtC_listbox.Location = new System.Drawing.Point(3, 16);
            this.ArtC_listbox.Name = "ArtC_listbox";
            this.ArtC_listbox.Size = new System.Drawing.Size(142, 332);
            this.ArtC_listbox.TabIndex = 0;
            this.ArtC_listbox.Click += new System.EventHandler(this.ArtC_listbox_Click);
            // 
            // Articles_dgv
            // 
            this.Articles_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Articles_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.RQuantity,
            this.Reference,
            this.Quantity,
            this.BuyingPrice,
            this.articleCategory});
            this.Articles_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Articles_dgv.Location = new System.Drawing.Point(157, 54);
            this.Articles_dgv.Name = "Articles_dgv";
            this.Articles_dgv.Size = new System.Drawing.Size(544, 351);
            this.Articles_dgv.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.DateExpected_grpbx, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(157, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(544, 45);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // DateExpected_grpbx
            // 
            this.DateExpected_grpbx.Controls.Add(this.ArrivalDateExpected_dtp);
            this.DateExpected_grpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateExpected_grpbx.Location = new System.Drawing.Point(3, 3);
            this.DateExpected_grpbx.Name = "DateExpected_grpbx";
            this.DateExpected_grpbx.Size = new System.Drawing.Size(266, 39);
            this.DateExpected_grpbx.TabIndex = 7;
            this.DateExpected_grpbx.TabStop = false;
            this.DateExpected_grpbx.Text = "Arrival Date Expected : ";
            // 
            // ArrivalDateExpected_dtp
            // 
            this.ArrivalDateExpected_dtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ArrivalDateExpected_dtp.Location = new System.Drawing.Point(48, 16);
            this.ArrivalDateExpected_dtp.Name = "ArrivalDateExpected_dtp";
            this.ArrivalDateExpected_dtp.Size = new System.Drawing.Size(212, 20);
            this.ArrivalDateExpected_dtp.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Search_tb);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(275, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 39);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By Reference : ";
            // 
            // Search_tb
            // 
            this.Search_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_tb.Location = new System.Drawing.Point(46, 16);
            this.Search_tb.Name = "Search_tb";
            this.Search_tb.Size = new System.Drawing.Size(214, 20);
            this.Search_tb.TabIndex = 7;
            this.Search_tb.TextChanged += new System.EventHandler(this.Search_tb_TextChanged_1);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // RQuantity
            // 
            this.RQuantity.HeaderText = "Required Quantity";
            this.RQuantity.Name = "RQuantity";
            // 
            // Reference
            // 
            this.Reference.DataPropertyName = "Reference";
            this.Reference.HeaderText = "Reference";
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // BuyingPrice
            // 
            this.BuyingPrice.DataPropertyName = "BuyingPrice";
            this.BuyingPrice.HeaderText = "BuyingPrice";
            this.BuyingPrice.Name = "BuyingPrice";
            this.BuyingPrice.ReadOnly = true;
            // 
            // articleCategory
            // 
            this.articleCategory.DataPropertyName = "articleCategory";
            this.articleCategory.HeaderText = "articleCategory";
            this.articleCategory.Name = "articleCategory";
            this.articleCategory.ReadOnly = true;
            // 
            // FormBuyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 408);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormBuyOrder";
            this.Text = "Buy Order ";
            this.Load += new System.EventHandler(this.FormBuyOrder_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.provider_grpbox.ResumeLayout(false);
            this.Articles_Category_grpbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Articles_dgv)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.DateExpected_grpbx.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox provider_grpbox;
        private System.Windows.Forms.ComboBox prov_combo;
        private System.Windows.Forms.GroupBox Articles_Category_grpbox;
        private System.Windows.Forms.ListBox ArtC_listbox;
        private System.Windows.Forms.DataGridView Articles_dgv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox DateExpected_grpbx;
        private System.Windows.Forms.DateTimePicker ArrivalDateExpected_dtp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Search_tb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleCategory;
    }
}