namespace ShopManagement.Forms.Sell_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSellOrder));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.search_grpx = new System.Windows.Forms.GroupBox();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.articles_cat_lb = new System.Windows.Forms.ListBox();
            this.articles_dgv = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RequiredQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.op_type_grpx = new System.Windows.Forms.GroupBox();
            this.op_type_combo = new System.Windows.Forms.ComboBox();
            this.customer_grpx = new System.Windows.Forms.GroupBox();
            this.idcustomer_label = new System.Windows.Forms.Label();
            this.customer_combo = new System.Windows.Forms.ComboBox();
            this.id_rdb = new System.Windows.Forms.RadioButton();
            this.Object_rdb = new System.Windows.Forms.RadioButton();
            this.deliverydate_grpx = new System.Windows.Forms.GroupBox();
            this.deliverydateexpected_dtp = new System.Windows.Forms.DateTimePicker();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.Result_grpbx = new System.Windows.Forms.GroupBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.totalPrice_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.articles_count_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.search_grpx.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articles_dgv)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.op_type_grpx.SuspendLayout();
            this.customer_grpx.SuspendLayout();
            this.deliverydate_grpx.SuspendLayout();
            this.Result_grpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Result_grpbx, 3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.search_grpx, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // search_grpx
            // 
            resources.ApplyResources(this.search_grpx, "search_grpx");
            this.search_grpx.Controls.Add(this.search_tb);
            this.search_grpx.Name = "search_grpx";
            this.search_grpx.TabStop = false;
            // 
            // search_tb
            // 
            resources.ApplyResources(this.search_tb, "search_tb");
            this.search_tb.Name = "search_tb";
            this.search_tb.TextChanged += new System.EventHandler(this.search_tb_TextChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.articles_cat_lb);
            this.groupBox1.Controls.Add(this.articles_dgv);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // articles_cat_lb
            // 
            resources.ApplyResources(this.articles_cat_lb, "articles_cat_lb");
            this.articles_cat_lb.FormattingEnabled = true;
            this.articles_cat_lb.Name = "articles_cat_lb";
            // 
            // articles_dgv
            // 
            resources.ApplyResources(this.articles_dgv, "articles_dgv");
            this.articles_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articles_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.RequiredQuantity,
            this.Id,
            this.Reference,
            this.Quantity,
            this.SellingPrice});
            this.articles_dgv.Name = "articles_dgv";
            // 
            // Selected
            // 
            resources.ApplyResources(this.Selected, "Selected");
            this.Selected.Name = "Selected";
            // 
            // RequiredQuantity
            // 
            resources.ApplyResources(this.RequiredQuantity, "RequiredQuantity");
            this.RequiredQuantity.Name = "RequiredQuantity";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Reference
            // 
            this.Reference.DataPropertyName = "Reference";
            resources.ApplyResources(this.Reference, "Reference");
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            resources.ApplyResources(this.Quantity, "Quantity");
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // SellingPrice
            // 
            this.SellingPrice.DataPropertyName = "SellingPrice";
            resources.ApplyResources(this.SellingPrice, "SellingPrice");
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.ReadOnly = true;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.op_type_grpx, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.customer_grpx, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.deliverydate_grpx, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btn_confirm, 0, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // op_type_grpx
            // 
            resources.ApplyResources(this.op_type_grpx, "op_type_grpx");
            this.op_type_grpx.Controls.Add(this.op_type_combo);
            this.op_type_grpx.Name = "op_type_grpx";
            this.op_type_grpx.TabStop = false;
            // 
            // op_type_combo
            // 
            resources.ApplyResources(this.op_type_combo, "op_type_combo");
            this.op_type_combo.FormattingEnabled = true;
            this.op_type_combo.Name = "op_type_combo";
            this.op_type_combo.SelectedValueChanged += new System.EventHandler(this.op_type_combo_SelectedValueChanged);
            // 
            // customer_grpx
            // 
            resources.ApplyResources(this.customer_grpx, "customer_grpx");
            this.customer_grpx.Controls.Add(this.idcustomer_label);
            this.customer_grpx.Controls.Add(this.customer_combo);
            this.customer_grpx.Controls.Add(this.id_rdb);
            this.customer_grpx.Controls.Add(this.Object_rdb);
            this.customer_grpx.Name = "customer_grpx";
            this.customer_grpx.TabStop = false;
            // 
            // idcustomer_label
            // 
            resources.ApplyResources(this.idcustomer_label, "idcustomer_label");
            this.idcustomer_label.Name = "idcustomer_label";
            // 
            // customer_combo
            // 
            resources.ApplyResources(this.customer_combo, "customer_combo");
            this.customer_combo.FormattingEnabled = true;
            this.customer_combo.Name = "customer_combo";
            this.customer_combo.SelectedValueChanged += new System.EventHandler(this.customer_combo_SelectedValueChanged);
            // 
            // id_rdb
            // 
            resources.ApplyResources(this.id_rdb, "id_rdb");
            this.id_rdb.Name = "id_rdb";
            this.id_rdb.TabStop = true;
            this.id_rdb.UseVisualStyleBackColor = true;
            this.id_rdb.CheckedChanged += new System.EventHandler(this.id_rdb_CheckedChanged);
            // 
            // Object_rdb
            // 
            resources.ApplyResources(this.Object_rdb, "Object_rdb");
            this.Object_rdb.Name = "Object_rdb";
            this.Object_rdb.TabStop = true;
            this.Object_rdb.UseVisualStyleBackColor = true;
            this.Object_rdb.CheckedChanged += new System.EventHandler(this.Object_rdb_CheckedChanged);
            // 
            // deliverydate_grpx
            // 
            resources.ApplyResources(this.deliverydate_grpx, "deliverydate_grpx");
            this.deliverydate_grpx.Controls.Add(this.deliverydateexpected_dtp);
            this.deliverydate_grpx.Name = "deliverydate_grpx";
            this.deliverydate_grpx.TabStop = false;
            // 
            // deliverydateexpected_dtp
            // 
            resources.ApplyResources(this.deliverydateexpected_dtp, "deliverydateexpected_dtp");
            this.deliverydateexpected_dtp.Name = "deliverydateexpected_dtp";
            this.deliverydateexpected_dtp.ValueChanged += new System.EventHandler(this.deliverydateexpected_dtp_ValueChanged);
            // 
            // btn_confirm
            // 
            resources.ApplyResources(this.btn_confirm, "btn_confirm");
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // Result_grpbx
            // 
            resources.ApplyResources(this.Result_grpbx, "Result_grpbx");
            this.Result_grpbx.Controls.Add(this.btn_next);
            this.Result_grpbx.Controls.Add(this.totalPrice_tb);
            this.Result_grpbx.Controls.Add(this.label2);
            this.Result_grpbx.Controls.Add(this.articles_count_tb);
            this.Result_grpbx.Controls.Add(this.label1);
            this.Result_grpbx.Name = "Result_grpbx";
            this.Result_grpbx.TabStop = false;
            // 
            // btn_next
            // 
            resources.ApplyResources(this.btn_next, "btn_next");
            this.btn_next.Name = "btn_next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // totalPrice_tb
            // 
            resources.ApplyResources(this.totalPrice_tb, "totalPrice_tb");
            this.totalPrice_tb.Name = "totalPrice_tb";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // articles_count_tb
            // 
            resources.ApplyResources(this.articles_count_tb, "articles_count_tb");
            this.articles_count_tb.Name = "articles_count_tb";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // FormSellOrder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormSellOrder";
            this.Load += new System.EventHandler(this.FormSellOrder_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.search_grpx.ResumeLayout(false);
            this.search_grpx.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.articles_dgv)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.op_type_grpx.ResumeLayout(false);
            this.customer_grpx.ResumeLayout(false);
            this.customer_grpx.PerformLayout();
            this.deliverydate_grpx.ResumeLayout(false);
            this.Result_grpbx.ResumeLayout(false);
            this.Result_grpbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox op_type_grpx;
        private System.Windows.Forms.ComboBox op_type_combo;
        private System.Windows.Forms.GroupBox customer_grpx;
        private System.Windows.Forms.RadioButton Object_rdb;
        private System.Windows.Forms.Label idcustomer_label;
        private System.Windows.Forms.ComboBox customer_combo;
        private System.Windows.Forms.RadioButton id_rdb;
        private System.Windows.Forms.GroupBox deliverydate_grpx;
        private System.Windows.Forms.DateTimePicker deliverydateexpected_dtp;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.GroupBox search_grpx;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.GroupBox Result_grpbx;
        private System.Windows.Forms.TextBox articles_count_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalPrice_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView articles_dgv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequiredQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.ListBox articles_cat_lb;
    }
}