namespace ShopManagement.Sell_Order
{
    partial class FormSellOrder
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.OperationType_grpbox = new System.Windows.Forms.GroupBox();
            this.Typecombo = new System.Windows.Forms.ComboBox();
            this.CustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.orderdate_grpbox = new System.Windows.Forms.GroupBox();
            this.orderdate_datetp = new System.Windows.Forms.DateTimePicker();
            this.Test_rdb = new System.Windows.Forms.RadioButton();
            this.idCustomer_rdb = new System.Windows.Forms.RadioButton();
            this.CustomerObject_rdb = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.namecustomer_grpbox = new System.Windows.Forms.GroupBox();
            this.Customername_combo = new System.Windows.Forms.ComboBox();
            this.idcustomer_grpbox = new System.Windows.Forms.GroupBox();
            this.idcustomer_label = new System.Windows.Forms.Label();
            this.Operations = new System.Windows.Forms.TableLayoutPanel();
            this.ArticleCategories_ListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Reference_GroupeBox = new System.Windows.Forms.GroupBox();
            this.Reference_TextBox = new System.Windows.Forms.TextBox();
            this.Articles_DataGridView = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedArticles_Listbox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Details_grpbox = new System.Windows.Forms.GroupBox();
            this.btn_result = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.OperationType_grpbox.SuspendLayout();
            this.CustomerGroupBox.SuspendLayout();
            this.orderdate_grpbox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.namecustomer_grpbox.SuspendLayout();
            this.idcustomer_grpbox.SuspendLayout();
            this.Operations.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.Reference_GroupeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Articles_DataGridView)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Operations, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1085, 495);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.21449F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.78551F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 357F));
            this.tableLayoutPanel2.Controls.Add(this.OperationType_grpbox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CustomerGroupBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1079, 213);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // OperationType_grpbox
            // 
            this.OperationType_grpbox.Controls.Add(this.btn_cancel);
            this.OperationType_grpbox.Controls.Add(this.Typecombo);
            this.OperationType_grpbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OperationType_grpbox.Location = new System.Drawing.Point(3, 3);
            this.OperationType_grpbox.Name = "OperationType_grpbox";
            this.OperationType_grpbox.Size = new System.Drawing.Size(471, 207);
            this.OperationType_grpbox.TabIndex = 6;
            this.OperationType_grpbox.TabStop = false;
            this.OperationType_grpbox.Text = "Operation Type : ";
            // 
            // Typecombo
            // 
            this.Typecombo.FormattingEnabled = true;
            this.Typecombo.Items.AddRange(new object[] {
            "Buy",
            "Order"});
            this.Typecombo.Location = new System.Drawing.Point(101, 83);
            this.Typecombo.Name = "Typecombo";
            this.Typecombo.Size = new System.Drawing.Size(247, 21);
            this.Typecombo.TabIndex = 0;
            this.Typecombo.SelectedValueChanged += new System.EventHandler(this.Typecombo_SelectedValueChanged_1);
            // 
            // CustomerGroupBox
            // 
            this.CustomerGroupBox.Controls.Add(this.orderdate_grpbox);
            this.CustomerGroupBox.Controls.Add(this.Test_rdb);
            this.CustomerGroupBox.Controls.Add(this.idCustomer_rdb);
            this.CustomerGroupBox.Controls.Add(this.CustomerObject_rdb);
            this.CustomerGroupBox.Controls.Add(this.tableLayoutPanel3);
            this.CustomerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerGroupBox.Location = new System.Drawing.Point(480, 3);
            this.CustomerGroupBox.Name = "CustomerGroupBox";
            this.CustomerGroupBox.Size = new System.Drawing.Size(596, 207);
            this.CustomerGroupBox.TabIndex = 5;
            this.CustomerGroupBox.TabStop = false;
            this.CustomerGroupBox.Text = "Customer : ";
            // 
            // orderdate_grpbox
            // 
            this.orderdate_grpbox.Controls.Add(this.orderdate_datetp);
            this.orderdate_grpbox.Location = new System.Drawing.Point(41, 151);
            this.orderdate_grpbox.Name = "orderdate_grpbox";
            this.orderdate_grpbox.Size = new System.Drawing.Size(443, 50);
            this.orderdate_grpbox.TabIndex = 7;
            this.orderdate_grpbox.TabStop = false;
            this.orderdate_grpbox.Text = "Order date : ";
            // 
            // orderdate_datetp
            // 
            this.orderdate_datetp.Location = new System.Drawing.Point(57, 19);
            this.orderdate_datetp.Name = "orderdate_datetp";
            this.orderdate_datetp.Size = new System.Drawing.Size(305, 20);
            this.orderdate_datetp.TabIndex = 0;
            this.orderdate_datetp.ValueChanged += new System.EventHandler(this.orderdate_datetp_ValueChanged);
            // 
            // Test_rdb
            // 
            this.Test_rdb.AutoSize = true;
            this.Test_rdb.Location = new System.Drawing.Point(98, 14);
            this.Test_rdb.Name = "Test_rdb";
            this.Test_rdb.Size = new System.Drawing.Size(14, 13);
            this.Test_rdb.TabIndex = 5;
            this.Test_rdb.TabStop = true;
            this.Test_rdb.UseVisualStyleBackColor = true;
            // 
            // idCustomer_rdb
            // 
            this.idCustomer_rdb.AutoSize = true;
            this.idCustomer_rdb.Location = new System.Drawing.Point(41, 94);
            this.idCustomer_rdb.Name = "idCustomer_rdb";
            this.idCustomer_rdb.Size = new System.Drawing.Size(14, 13);
            this.idCustomer_rdb.TabIndex = 4;
            this.idCustomer_rdb.TabStop = true;
            this.idCustomer_rdb.UseVisualStyleBackColor = true;
            // 
            // CustomerObject_rdb
            // 
            this.CustomerObject_rdb.AutoSize = true;
            this.CustomerObject_rdb.Location = new System.Drawing.Point(41, 50);
            this.CustomerObject_rdb.Name = "CustomerObject_rdb";
            this.CustomerObject_rdb.Size = new System.Drawing.Size(14, 13);
            this.CustomerObject_rdb.TabIndex = 3;
            this.CustomerObject_rdb.TabStop = true;
            this.CustomerObject_rdb.UseVisualStyleBackColor = true;
            this.CustomerObject_rdb.CheckedChanged += new System.EventHandler(this.CustomerObject_rdb_CheckedChanged_1);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.namecustomer_grpbox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.idcustomer_grpbox, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(98, 33);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.17241F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.82759F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(373, 87);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // namecustomer_grpbox
            // 
            this.namecustomer_grpbox.Controls.Add(this.Customername_combo);
            this.namecustomer_grpbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namecustomer_grpbox.Location = new System.Drawing.Point(3, 3);
            this.namecustomer_grpbox.Name = "namecustomer_grpbox";
            this.namecustomer_grpbox.Size = new System.Drawing.Size(367, 41);
            this.namecustomer_grpbox.TabIndex = 0;
            this.namecustomer_grpbox.TabStop = false;
            // 
            // Customername_combo
            // 
            this.Customername_combo.FormattingEnabled = true;
            this.Customername_combo.Items.AddRange(new object[] {
            ""});
            this.Customername_combo.Location = new System.Drawing.Point(6, 14);
            this.Customername_combo.Name = "Customername_combo";
            this.Customername_combo.Size = new System.Drawing.Size(348, 21);
            this.Customername_combo.TabIndex = 1;
            this.Customername_combo.SelectedValueChanged += new System.EventHandler(this.Customername_combo_SelectedValueChanged_1);
            // 
            // idcustomer_grpbox
            // 
            this.idcustomer_grpbox.Controls.Add(this.idcustomer_label);
            this.idcustomer_grpbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idcustomer_grpbox.Location = new System.Drawing.Point(3, 50);
            this.idcustomer_grpbox.Name = "idcustomer_grpbox";
            this.idcustomer_grpbox.Size = new System.Drawing.Size(367, 34);
            this.idcustomer_grpbox.TabIndex = 1;
            this.idcustomer_grpbox.TabStop = false;
            // 
            // idcustomer_label
            // 
            this.idcustomer_label.AutoSize = true;
            this.idcustomer_label.Location = new System.Drawing.Point(43, 11);
            this.idcustomer_label.Name = "idcustomer_label";
            this.idcustomer_label.Size = new System.Drawing.Size(28, 13);
            this.idcustomer_label.TabIndex = 0;
            this.idcustomer_label.Text = "-------";
            // 
            // Operations
            // 
            this.Operations.ColumnCount = 4;
            this.Operations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.93981F));
            this.Operations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.06019F));
            this.Operations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.Operations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.Operations.Controls.Add(this.ArticleCategories_ListBox, 0, 0);
            this.Operations.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.Operations.Controls.Add(this.SelectedArticles_Listbox, 2, 0);
            this.Operations.Controls.Add(this.tableLayoutPanel5, 3, 0);
            this.Operations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Operations.Location = new System.Drawing.Point(3, 222);
            this.Operations.Name = "Operations";
            this.Operations.RowCount = 1;
            this.Operations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Operations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Operations.Size = new System.Drawing.Size(1079, 270);
            this.Operations.TabIndex = 1;
            // 
            // ArticleCategories_ListBox
            // 
            this.ArticleCategories_ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArticleCategories_ListBox.FormattingEnabled = true;
            this.ArticleCategories_ListBox.Location = new System.Drawing.Point(3, 3);
            this.ArticleCategories_ListBox.Name = "ArticleCategories_ListBox";
            this.ArticleCategories_ListBox.Size = new System.Drawing.Size(169, 264);
            this.ArticleCategories_ListBox.TabIndex = 0;
            this.ArticleCategories_ListBox.Click += new System.EventHandler(this.ArticleCategories_ListBox_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.Reference_GroupeBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Articles_DataGridView, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(178, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.10606F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.89394F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(550, 264);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // Reference_GroupeBox
            // 
            this.Reference_GroupeBox.Controls.Add(this.Reference_TextBox);
            this.Reference_GroupeBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.Reference_GroupeBox.Location = new System.Drawing.Point(220, 3);
            this.Reference_GroupeBox.Name = "Reference_GroupeBox";
            this.Reference_GroupeBox.Size = new System.Drawing.Size(327, 54);
            this.Reference_GroupeBox.TabIndex = 0;
            this.Reference_GroupeBox.TabStop = false;
            // 
            // Reference_TextBox
            // 
            this.Reference_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Reference_TextBox.Location = new System.Drawing.Point(44, 19);
            this.Reference_TextBox.Name = "Reference_TextBox";
            this.Reference_TextBox.Size = new System.Drawing.Size(247, 20);
            this.Reference_TextBox.TabIndex = 1;
            this.Reference_TextBox.TextChanged += new System.EventHandler(this.Reference_TextBox_TextChanged);
            // 
            // Articles_DataGridView
            // 
            this.Articles_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Articles_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.Id,
            this.Reference,
            this.articleCategory,
            this.SellingPrice,
            this.Quantity});
            this.Articles_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Articles_DataGridView.Location = new System.Drawing.Point(3, 63);
            this.Articles_DataGridView.Name = "Articles_DataGridView";
            this.Articles_DataGridView.Size = new System.Drawing.Size(544, 198);
            this.Articles_DataGridView.TabIndex = 1;
            this.Articles_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Articles_DataGridView_CellContentClick_1);
            // 
            // Selected
            // 
            this.Selected.HeaderText = "";
            this.Selected.Name = "Selected";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Reference
            // 
            this.Reference.DataPropertyName = "Reference";
            this.Reference.HeaderText = "Reference";
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            // 
            // articleCategory
            // 
            this.articleCategory.DataPropertyName = "articleCategory";
            this.articleCategory.HeaderText = "articleCategory";
            this.articleCategory.Name = "articleCategory";
            this.articleCategory.ReadOnly = true;
            // 
            // SellingPrice
            // 
            this.SellingPrice.DataPropertyName = "SellingPrice";
            this.SellingPrice.HeaderText = "SellingPrice";
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // SelectedArticles_Listbox
            // 
            this.SelectedArticles_Listbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.SelectedArticles_Listbox.FormattingEnabled = true;
            this.SelectedArticles_Listbox.Location = new System.Drawing.Point(734, 3);
            this.SelectedArticles_Listbox.Name = "SelectedArticles_Listbox";
            this.SelectedArticles_Listbox.Size = new System.Drawing.Size(135, 264);
            this.SelectedArticles_Listbox.TabIndex = 2;
            this.SelectedArticles_Listbox.Click += new System.EventHandler(this.SelectedArticles_Listbox_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.Details_grpbox, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(875, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.60606F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.39394F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(201, 264);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // Details_grpbox
            // 
            this.Details_grpbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Details_grpbox.Location = new System.Drawing.Point(3, 3);
            this.Details_grpbox.Name = "Details_grpbox";
            this.Details_grpbox.Size = new System.Drawing.Size(195, 219);
            this.Details_grpbox.TabIndex = 1;
            this.Details_grpbox.TabStop = false;
            this.Details_grpbox.Text = "Details : ";
            // 
            // btn_result
            // 
            this.btn_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_result.Location = new System.Drawing.Point(3, 3);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(104, 27);
            this.btn_result.TabIndex = 0;
            this.btn_result.Text = "Result ";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.41026F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.58974F));
            this.tableLayoutPanel6.Controls.Add(this.btn_result, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 228);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(195, 33);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(293, 184);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(178, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel ";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // FormSellOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 495);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormSellOrder";
            this.Text = "Sell/Order";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.OperationType_grpbox.ResumeLayout(false);
            this.CustomerGroupBox.ResumeLayout(false);
            this.CustomerGroupBox.PerformLayout();
            this.orderdate_grpbox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.namecustomer_grpbox.ResumeLayout(false);
            this.idcustomer_grpbox.ResumeLayout(false);
            this.idcustomer_grpbox.PerformLayout();
            this.Operations.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.Reference_GroupeBox.ResumeLayout(false);
            this.Reference_GroupeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Articles_DataGridView)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox OperationType_grpbox;
        private System.Windows.Forms.ComboBox Typecombo;
        private System.Windows.Forms.GroupBox CustomerGroupBox;
        private System.Windows.Forms.RadioButton Test_rdb;
        private System.Windows.Forms.RadioButton idCustomer_rdb;
        private System.Windows.Forms.RadioButton CustomerObject_rdb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox namecustomer_grpbox;
        private System.Windows.Forms.ComboBox Customername_combo;
        private System.Windows.Forms.GroupBox idcustomer_grpbox;
        private System.Windows.Forms.Label idcustomer_label;
        private System.Windows.Forms.TableLayoutPanel Operations;
        private System.Windows.Forms.GroupBox orderdate_grpbox;
        private System.Windows.Forms.DateTimePicker orderdate_datetp;
        private System.Windows.Forms.ListBox ArticleCategories_ListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox Reference_GroupeBox;
        private System.Windows.Forms.TextBox Reference_TextBox;
        private System.Windows.Forms.DataGridView Articles_DataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.ListBox SelectedArticles_Listbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox Details_grpbox;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btn_result;
    }
}