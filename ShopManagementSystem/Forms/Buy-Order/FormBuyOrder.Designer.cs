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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuyOrder));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.OperationType_grpbx = new System.Windows.Forms.GroupBox();
            this.OpType_combo = new System.Windows.Forms.ComboBox();
            this.prov_grpx = new System.Windows.Forms.GroupBox();
            this.id_pro_label = new System.Windows.Forms.RadioButton();
            this.pro_rdb = new System.Windows.Forms.RadioButton();
            this.providerId_label = new System.Windows.Forms.Label();
            this.id_provider_label = new System.Windows.Forms.Label();
            this.pro_combo = new System.Windows.Forms.ComboBox();
            this.dde_grpx = new System.Windows.Forms.GroupBox();
            this.dd_dtp = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.search_grpbx = new System.Windows.Forms.GroupBox();
            this.Articles_dgv = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequiredQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articles_Category_lb = new System.Windows.Forms.ListBox();
            this.get_grpbx = new System.Windows.Forms.GroupBox();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.result_grpx = new System.Windows.Forms.GroupBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.totalp_tb = new System.Windows.Forms.TextBox();
            this.Totel_Price_tb = new System.Windows.Forms.Label();
            this.articlesCount_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.OperationType_grpbx.SuspendLayout();
            this.prov_grpx.SuspendLayout();
            this.dde_grpx.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.search_grpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Articles_dgv)).BeginInit();
            this.get_grpbx.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.result_grpx.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.OperationType_grpbx, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.prov_grpx, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dde_grpx, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // OperationType_grpbx
            // 
            resources.ApplyResources(this.OperationType_grpbx, "OperationType_grpbx");
            this.OperationType_grpbx.Controls.Add(this.OpType_combo);
            this.OperationType_grpbx.Name = "OperationType_grpbx";
            this.OperationType_grpbx.TabStop = false;
            // 
            // OpType_combo
            // 
            resources.ApplyResources(this.OpType_combo, "OpType_combo");
            this.OpType_combo.FormattingEnabled = true;
            this.OpType_combo.Name = "OpType_combo";
            this.OpType_combo.SelectedValueChanged += new System.EventHandler(this.OpType_combo_SelectedValueChanged);
            // 
            // prov_grpx
            // 
            resources.ApplyResources(this.prov_grpx, "prov_grpx");
            this.prov_grpx.Controls.Add(this.id_pro_label);
            this.prov_grpx.Controls.Add(this.pro_rdb);
            this.prov_grpx.Controls.Add(this.providerId_label);
            this.prov_grpx.Controls.Add(this.id_provider_label);
            this.prov_grpx.Controls.Add(this.pro_combo);
            this.prov_grpx.Name = "prov_grpx";
            this.prov_grpx.TabStop = false;
            // 
            // id_pro_label
            // 
            resources.ApplyResources(this.id_pro_label, "id_pro_label");
            this.id_pro_label.Name = "id_pro_label";
            this.id_pro_label.TabStop = true;
            this.id_pro_label.UseVisualStyleBackColor = true;
            this.id_pro_label.CheckedChanged += new System.EventHandler(this.id_pro_label_CheckedChanged);
            // 
            // pro_rdb
            // 
            resources.ApplyResources(this.pro_rdb, "pro_rdb");
            this.pro_rdb.Name = "pro_rdb";
            this.pro_rdb.TabStop = true;
            this.pro_rdb.UseVisualStyleBackColor = true;
            this.pro_rdb.CheckedChanged += new System.EventHandler(this.pro_rdb_CheckedChanged);
            // 
            // providerId_label
            // 
            resources.ApplyResources(this.providerId_label, "providerId_label");
            this.providerId_label.Name = "providerId_label";
            // 
            // id_provider_label
            // 
            resources.ApplyResources(this.id_provider_label, "id_provider_label");
            this.id_provider_label.Name = "id_provider_label";
            // 
            // pro_combo
            // 
            resources.ApplyResources(this.pro_combo, "pro_combo");
            this.pro_combo.FormattingEnabled = true;
            this.pro_combo.Name = "pro_combo";
            this.pro_combo.SelectedValueChanged += new System.EventHandler(this.pro_combo_SelectedValueChanged);
            // 
            // dde_grpx
            // 
            resources.ApplyResources(this.dde_grpx, "dde_grpx");
            this.dde_grpx.Controls.Add(this.dd_dtp);
            this.dde_grpx.Name = "dde_grpx";
            this.dde_grpx.TabStop = false;
            // 
            // dd_dtp
            // 
            resources.ApplyResources(this.dd_dtp, "dd_dtp");
            this.dd_dtp.Name = "dd_dtp";
            this.dd_dtp.ValueChanged += new System.EventHandler(this.dd_dtp_ValueChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.btn_confirm);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btn_confirm
            // 
            resources.ApplyResources(this.btn_confirm, "btn_confirm");
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.search_grpbx, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.get_grpbx, 0, 1);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // search_grpbx
            // 
            resources.ApplyResources(this.search_grpbx, "search_grpbx");
            this.search_grpbx.Controls.Add(this.Articles_dgv);
            this.search_grpbx.Controls.Add(this.Articles_Category_lb);
            this.search_grpbx.Name = "search_grpbx";
            this.search_grpbx.TabStop = false;
            // 
            // Articles_dgv
            // 
            resources.ApplyResources(this.Articles_dgv, "Articles_dgv");
            this.Articles_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Articles_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.Id,
            this.RequiredQuantity,
            this.BuyingPrice,
            this.Reference,
            this.Quantity});
            this.Articles_dgv.Name = "Articles_dgv";
            // 
            // Selected
            // 
            resources.ApplyResources(this.Selected, "Selected");
            this.Selected.Name = "Selected";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            // 
            // RequiredQuantity
            // 
            resources.ApplyResources(this.RequiredQuantity, "RequiredQuantity");
            this.RequiredQuantity.Name = "RequiredQuantity";
            // 
            // BuyingPrice
            // 
            this.BuyingPrice.DataPropertyName = "BuyingPrice";
            resources.ApplyResources(this.BuyingPrice, "BuyingPrice");
            this.BuyingPrice.Name = "BuyingPrice";
            this.BuyingPrice.ReadOnly = true;
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
            // Articles_Category_lb
            // 
            resources.ApplyResources(this.Articles_Category_lb, "Articles_Category_lb");
            this.Articles_Category_lb.FormattingEnabled = true;
            this.Articles_Category_lb.Name = "Articles_Category_lb";
            // 
            // get_grpbx
            // 
            resources.ApplyResources(this.get_grpbx, "get_grpbx");
            this.get_grpbx.Controls.Add(this.search_tb);
            this.get_grpbx.Name = "get_grpbx";
            this.get_grpbx.TabStop = false;
            // 
            // search_tb
            // 
            resources.ApplyResources(this.search_tb, "search_tb");
            this.search_tb.Name = "search_tb";
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.result_grpx, 0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // result_grpx
            // 
            resources.ApplyResources(this.result_grpx, "result_grpx");
            this.result_grpx.Controls.Add(this.btn_next);
            this.result_grpx.Controls.Add(this.totalp_tb);
            this.result_grpx.Controls.Add(this.Totel_Price_tb);
            this.result_grpx.Controls.Add(this.articlesCount_tb);
            this.result_grpx.Controls.Add(this.label1);
            this.result_grpx.Name = "result_grpx";
            this.result_grpx.TabStop = false;
            // 
            // btn_next
            // 
            resources.ApplyResources(this.btn_next, "btn_next");
            this.btn_next.Name = "btn_next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // totalp_tb
            // 
            resources.ApplyResources(this.totalp_tb, "totalp_tb");
            this.totalp_tb.Name = "totalp_tb";
            // 
            // Totel_Price_tb
            // 
            resources.ApplyResources(this.Totel_Price_tb, "Totel_Price_tb");
            this.Totel_Price_tb.Name = "Totel_Price_tb";
            // 
            // articlesCount_tb
            // 
            resources.ApplyResources(this.articlesCount_tb, "articlesCount_tb");
            this.articlesCount_tb.Name = "articlesCount_tb";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // FormBuyOrder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormBuyOrder";
            this.Load += new System.EventHandler(this.FormBuyOrder_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.OperationType_grpbx.ResumeLayout(false);
            this.prov_grpx.ResumeLayout(false);
            this.prov_grpx.PerformLayout();
            this.dde_grpx.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.search_grpbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Articles_dgv)).EndInit();
            this.get_grpbx.ResumeLayout(false);
            this.get_grpbx.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.result_grpx.ResumeLayout(false);
            this.result_grpx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox OperationType_grpbx;
        private System.Windows.Forms.ComboBox OpType_combo;
        private System.Windows.Forms.GroupBox prov_grpx;
        private System.Windows.Forms.ComboBox pro_combo;
        private System.Windows.Forms.GroupBox dde_grpx;
        private System.Windows.Forms.DateTimePicker dd_dtp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label providerId_label;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton prov_rdb;
        private System.Windows.Forms.Label id_provider_label;
        private System.Windows.Forms.GroupBox search_grpbx;
        private System.Windows.Forms.RadioButton id_pro_label;
        private System.Windows.Forms.RadioButton pro_rdb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox result_grpx;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.TextBox totalp_tb;
        private System.Windows.Forms.Label Totel_Price_tb;
        private System.Windows.Forms.TextBox articlesCount_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Articles_Category_lb;
        private System.Windows.Forms.DataGridView Articles_dgv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequiredQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.GroupBox get_grpbx;
        private System.Windows.Forms.TextBox search_tb;
    }
}