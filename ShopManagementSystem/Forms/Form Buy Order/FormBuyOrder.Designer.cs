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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OpType_combo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_pass = new System.Windows.Forms.Button();
            this.provider_combo = new System.Windows.Forms.ComboBox();
            this.Deliveryde_grpx = new System.Windows.Forms.GroupBox();
            this.dde_dtp = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Articles_dgv = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequieredQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference_textbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.slected_articles_grpbx = new System.Windows.Forms.GroupBox();
            this.articles_selected_lb = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_result = new System.Windows.Forms.Button();
            this.result_grpbx = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.total_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.delivery_tb = new System.Windows.Forms.TextBox();
            this.DeliveryDateExp_tb = new System.Windows.Forms.Label();
            this.articlescount_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.provider_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Deliveryde_grpx.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Articles_dgv)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.slected_articles_grpbx.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.result_grpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.71388F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.28612F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1252, 436);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Deliveryde_grpx, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.54983F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.45017F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(203, 430);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OpType_combo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation Type : ";
            // 
            // OpType_combo
            // 
            this.OpType_combo.FormattingEnabled = true;
            this.OpType_combo.Location = new System.Drawing.Point(20, 51);
            this.OpType_combo.Name = "OpType_combo";
            this.OpType_combo.Size = new System.Drawing.Size(138, 21);
            this.OpType_combo.TabIndex = 0;
            this.OpType_combo.SelectedValueChanged += new System.EventHandler(this.OpType_combo_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_pass);
            this.groupBox2.Controls.Add(this.provider_combo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 133);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Provider : ";
            // 
            // btn_pass
            // 
            this.btn_pass.Location = new System.Drawing.Point(83, 104);
            this.btn_pass.Name = "btn_pass";
            this.btn_pass.Size = new System.Drawing.Size(75, 23);
            this.btn_pass.TabIndex = 1;
            this.btn_pass.Text = "Pass";
            this.btn_pass.UseVisualStyleBackColor = true;
            this.btn_pass.Click += new System.EventHandler(this.btn_pass_Click);
            // 
            // provider_combo
            // 
            this.provider_combo.FormattingEnabled = true;
            this.provider_combo.Location = new System.Drawing.Point(20, 60);
            this.provider_combo.Name = "provider_combo";
            this.provider_combo.Size = new System.Drawing.Size(138, 21);
            this.provider_combo.TabIndex = 0;
            this.provider_combo.SelectedValueChanged += new System.EventHandler(this.provider_combo_SelectedValueChanged);
            // 
            // Deliveryde_grpx
            // 
            this.Deliveryde_grpx.Controls.Add(this.dde_dtp);
            this.Deliveryde_grpx.Location = new System.Drawing.Point(3, 121);
            this.Deliveryde_grpx.Name = "Deliveryde_grpx";
            this.Deliveryde_grpx.Size = new System.Drawing.Size(197, 167);
            this.Deliveryde_grpx.TabIndex = 4;
            this.Deliveryde_grpx.TabStop = false;
            this.Deliveryde_grpx.Text = "Delivery Date expected : ";
            // 
            // dde_dtp
            // 
            this.dde_dtp.Location = new System.Drawing.Point(20, 65);
            this.dde_dtp.Name = "dde_dtp";
            this.dde_dtp.Size = new System.Drawing.Size(138, 20);
            this.dde_dtp.TabIndex = 0;
            this.dde_dtp.ValueChanged += new System.EventHandler(this.dde_dtp_ValueChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.735776F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.26422F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(212, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1037, 430);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.77778F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.22222F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(21, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1013, 424);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.Articles_dgv, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.Reference_textbox, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67943F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.32057F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(721, 418);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // Articles_dgv
            // 
            this.Articles_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Articles_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.Id,
            this.RequieredQuantity,
            this.Reference,
            this.Quantity,
            this.BuyingPrice,
            this.articleCategory});
            this.Articles_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Articles_dgv.Location = new System.Drawing.Point(3, 56);
            this.Articles_dgv.Name = "Articles_dgv";
            this.Articles_dgv.Size = new System.Drawing.Size(715, 359);
            this.Articles_dgv.TabIndex = 0;
            this.Articles_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Articles_dgv_CellContentClick);
            // 
            // Selected
            // 
            this.Selected.HeaderText = "";
            this.Selected.Name = "Selected";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // RequieredQuantity
            // 
            this.RequieredQuantity.HeaderText = "Requiered Quantity (Fill this information )";
            this.RequieredQuantity.Name = "RequieredQuantity";
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
            // Reference_textbox
            // 
            this.Reference_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Reference_textbox.Location = new System.Drawing.Point(393, 30);
            this.Reference_textbox.Name = "Reference_textbox";
            this.Reference_textbox.Size = new System.Drawing.Size(325, 20);
            this.Reference_textbox.TabIndex = 1;
            this.Reference_textbox.TextChanged += new System.EventHandler(this.Reference_textbox_TextChanged);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel6.Controls.Add(this.slected_articles_grpbx, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(730, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(280, 418);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // slected_articles_grpbx
            // 
            this.slected_articles_grpbx.Controls.Add(this.articles_selected_lb);
            this.slected_articles_grpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slected_articles_grpbx.Location = new System.Drawing.Point(3, 3);
            this.slected_articles_grpbx.Name = "slected_articles_grpbx";
            this.slected_articles_grpbx.Size = new System.Drawing.Size(99, 412);
            this.slected_articles_grpbx.TabIndex = 0;
            this.slected_articles_grpbx.TabStop = false;
            this.slected_articles_grpbx.Text = "Selected Articles";
            // 
            // articles_selected_lb
            // 
            this.articles_selected_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.articles_selected_lb.FormattingEnabled = true;
            this.articles_selected_lb.Location = new System.Drawing.Point(3, 16);
            this.articles_selected_lb.Name = "articles_selected_lb";
            this.articles_selected_lb.Size = new System.Drawing.Size(93, 393);
            this.articles_selected_lb.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.btn_result, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.result_grpbx, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(108, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.65049F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.34952F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(169, 412);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // btn_result
            // 
            this.btn_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_result.Location = new System.Drawing.Point(91, 22);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(75, 23);
            this.btn_result.TabIndex = 0;
            this.btn_result.Text = "Pass";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // result_grpbx
            // 
            this.result_grpbx.Controls.Add(this.btn_cancel);
            this.result_grpbx.Controls.Add(this.total_tb);
            this.result_grpbx.Controls.Add(this.label3);
            this.result_grpbx.Controls.Add(this.delivery_tb);
            this.result_grpbx.Controls.Add(this.DeliveryDateExp_tb);
            this.result_grpbx.Controls.Add(this.articlescount_tb);
            this.result_grpbx.Controls.Add(this.label2);
            this.result_grpbx.Controls.Add(this.provider_tb);
            this.result_grpbx.Controls.Add(this.label1);
            this.result_grpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result_grpbx.Location = new System.Drawing.Point(3, 51);
            this.result_grpbx.Name = "result_grpbx";
            this.result_grpbx.Size = new System.Drawing.Size(163, 358);
            this.result_grpbx.TabIndex = 1;
            this.result_grpbx.TabStop = false;
            this.result_grpbx.Text = "Result : ";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(59, 338);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // total_tb
            // 
            this.total_tb.Enabled = false;
            this.total_tb.Location = new System.Drawing.Point(28, 285);
            this.total_tb.Name = "total_tb";
            this.total_tb.Size = new System.Drawing.Size(109, 20);
            this.total_tb.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Price : ";
            // 
            // delivery_tb
            // 
            this.delivery_tb.Enabled = false;
            this.delivery_tb.Location = new System.Drawing.Point(28, 235);
            this.delivery_tb.Name = "delivery_tb";
            this.delivery_tb.Size = new System.Drawing.Size(109, 20);
            this.delivery_tb.TabIndex = 5;
            // 
            // DeliveryDateExp_tb
            // 
            this.DeliveryDateExp_tb.AutoSize = true;
            this.DeliveryDateExp_tb.Location = new System.Drawing.Point(7, 207);
            this.DeliveryDateExp_tb.Name = "DeliveryDateExp_tb";
            this.DeliveryDateExp_tb.Size = new System.Drawing.Size(128, 13);
            this.DeliveryDateExp_tb.TabIndex = 4;
            this.DeliveryDateExp_tb.Text = "Delivery Date Expected : ";
            // 
            // articlescount_tb
            // 
            this.articlescount_tb.Enabled = false;
            this.articlescount_tb.Location = new System.Drawing.Point(28, 156);
            this.articlescount_tb.Name = "articlescount_tb";
            this.articlescount_tb.Size = new System.Drawing.Size(109, 20);
            this.articlescount_tb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Articles Count : ";
            // 
            // provider_tb
            // 
            this.provider_tb.Enabled = false;
            this.provider_tb.Location = new System.Drawing.Point(28, 71);
            this.provider_tb.Name = "provider_tb";
            this.provider_tb.Size = new System.Drawing.Size(109, 20);
            this.provider_tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provider : ";
            // 
            // FormBuyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 436);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormBuyOrder";
            this.Text = "FormBuyOrder";
            this.Load += new System.EventHandler(this.FormBuyOrder_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.Deliveryde_grpx.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Articles_dgv)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.slected_articles_grpbx.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.result_grpbx.ResumeLayout(false);
            this.result_grpbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox OpType_combo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox provider_combo;
        private System.Windows.Forms.GroupBox Deliveryde_grpx;
        private System.Windows.Forms.DateTimePicker dde_dtp;
        private System.Windows.Forms.Button btn_pass;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView Articles_dgv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequieredQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleCategory;
        private System.Windows.Forms.TextBox Reference_textbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox slected_articles_grpbx;
        private System.Windows.Forms.ListBox articles_selected_lb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.GroupBox result_grpbx;
        private System.Windows.Forms.TextBox provider_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox articlescount_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DeliveryDateExp_tb;
        private System.Windows.Forms.TextBox delivery_tb;
        private System.Windows.Forms.TextBox total_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancel;
    }
}