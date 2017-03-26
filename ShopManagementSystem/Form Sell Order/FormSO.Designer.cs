namespace ShopManagement.Test
{
    partial class FormSO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSO));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.OperationType_groupbox = new System.Windows.Forms.GroupBox();
            this.OperationType_Combobox = new System.Windows.Forms.ComboBox();
            this.Customer_groupbox = new System.Windows.Forms.GroupBox();
            this.idCustomer_groupebox = new System.Windows.Forms.GroupBox();
            this.idCustomer_label = new System.Windows.Forms.Label();
            this.IdCustomer_rdb = new System.Windows.Forms.RadioButton();
            this.ObjectCustomer_rdb = new System.Windows.Forms.RadioButton();
            this.ObjectCustomer_groupebox = new System.Windows.Forms.GroupBox();
            this.ObjectCustomer_combo = new System.Windows.Forms.ComboBox();
            this.OrderDate_groupebox = new System.Windows.Forms.GroupBox();
            this.orderdate_dtp = new System.Windows.Forms.DateTimePicker();
            this.DeliveryDate_dtp = new System.Windows.Forms.GroupBox();
            this.deliverydatep = new System.Windows.Forms.DateTimePicker();
            this.Operations = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ArticlesCategory_listbox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Articles_datagridview = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticlesSelected_grpbx = new System.Windows.Forms.GroupBox();
            this.btn_pass_grpbx = new System.Windows.Forms.GroupBox();
            this.btn_pass = new System.Windows.Forms.Button();
            this.Liste_grpbx = new System.Windows.Forms.GroupBox();
            this.ListeArticles_selected_listbox = new System.Windows.Forms.ListBox();
            this.Result_grpbox = new System.Windows.Forms.GroupBox();
            this.Total_price_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Articles_count_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.Reference_textbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.OperationType_groupbox.SuspendLayout();
            this.Customer_groupbox.SuspendLayout();
            this.idCustomer_groupebox.SuspendLayout();
            this.ObjectCustomer_groupebox.SuspendLayout();
            this.OrderDate_groupebox.SuspendLayout();
            this.DeliveryDate_dtp.SuspendLayout();
            this.Operations.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Articles_datagridview)).BeginInit();
            this.ArticlesSelected_grpbx.SuspendLayout();
            this.btn_pass_grpbx.SuspendLayout();
            this.Liste_grpbx.SuspendLayout();
            this.Result_grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Customer_groupbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OrderDate_groupebox, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.OperationType_groupbox, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // OperationType_groupbox
            // 
            this.OperationType_groupbox.Controls.Add(this.OperationType_Combobox);
            resources.ApplyResources(this.OperationType_groupbox, "OperationType_groupbox");
            this.OperationType_groupbox.Name = "OperationType_groupbox";
            this.OperationType_groupbox.TabStop = false;
            // 
            // OperationType_Combobox
            // 
            this.OperationType_Combobox.FormattingEnabled = true;
            this.OperationType_Combobox.Items.AddRange(new object[] {
            resources.GetString("OperationType_Combobox.Items"),
            resources.GetString("OperationType_Combobox.Items1")});
            resources.ApplyResources(this.OperationType_Combobox, "OperationType_Combobox");
            this.OperationType_Combobox.Name = "OperationType_Combobox";
            this.OperationType_Combobox.SelectedIndexChanged += new System.EventHandler(this.OperationType_Combobox_SelectedIndexChanged);
            // 
            // Customer_groupbox
            // 
            this.Customer_groupbox.Controls.Add(this.idCustomer_groupebox);
            this.Customer_groupbox.Controls.Add(this.IdCustomer_rdb);
            this.Customer_groupbox.Controls.Add(this.ObjectCustomer_rdb);
            this.Customer_groupbox.Controls.Add(this.ObjectCustomer_groupebox);
            resources.ApplyResources(this.Customer_groupbox, "Customer_groupbox");
            this.Customer_groupbox.Name = "Customer_groupbox";
            this.Customer_groupbox.TabStop = false;
            // 
            // idCustomer_groupebox
            // 
            this.idCustomer_groupebox.Controls.Add(this.idCustomer_label);
            resources.ApplyResources(this.idCustomer_groupebox, "idCustomer_groupebox");
            this.idCustomer_groupebox.Name = "idCustomer_groupebox";
            this.idCustomer_groupebox.TabStop = false;
            // 
            // idCustomer_label
            // 
            resources.ApplyResources(this.idCustomer_label, "idCustomer_label");
            this.idCustomer_label.Name = "idCustomer_label";
            // 
            // IdCustomer_rdb
            // 
            resources.ApplyResources(this.IdCustomer_rdb, "IdCustomer_rdb");
            this.IdCustomer_rdb.Name = "IdCustomer_rdb";
            this.IdCustomer_rdb.TabStop = true;
            this.IdCustomer_rdb.UseVisualStyleBackColor = true;
            this.IdCustomer_rdb.CheckedChanged += new System.EventHandler(this.IdCustomer_rdb_CheckedChanged);
            // 
            // ObjectCustomer_rdb
            // 
            resources.ApplyResources(this.ObjectCustomer_rdb, "ObjectCustomer_rdb");
            this.ObjectCustomer_rdb.Name = "ObjectCustomer_rdb";
            this.ObjectCustomer_rdb.TabStop = true;
            this.ObjectCustomer_rdb.UseVisualStyleBackColor = true;
            this.ObjectCustomer_rdb.CheckedChanged += new System.EventHandler(this.ObjectCustomer_rdb_CheckedChanged);
            // 
            // ObjectCustomer_groupebox
            // 
            this.ObjectCustomer_groupebox.Controls.Add(this.ObjectCustomer_combo);
            resources.ApplyResources(this.ObjectCustomer_groupebox, "ObjectCustomer_groupebox");
            this.ObjectCustomer_groupebox.Name = "ObjectCustomer_groupebox";
            this.ObjectCustomer_groupebox.TabStop = false;
            // 
            // ObjectCustomer_combo
            // 
            this.ObjectCustomer_combo.FormattingEnabled = true;
            resources.ApplyResources(this.ObjectCustomer_combo, "ObjectCustomer_combo");
            this.ObjectCustomer_combo.Name = "ObjectCustomer_combo";
            this.ObjectCustomer_combo.SelectedValueChanged += new System.EventHandler(this.ObjectCustomer_combo_SelectedValueChanged);
            // 
            // OrderDate_groupebox
            // 
            this.OrderDate_groupebox.Controls.Add(this.orderdate_dtp);
            this.OrderDate_groupebox.Controls.Add(this.DeliveryDate_dtp);
            resources.ApplyResources(this.OrderDate_groupebox, "OrderDate_groupebox");
            this.OrderDate_groupebox.Name = "OrderDate_groupebox";
            this.OrderDate_groupebox.TabStop = false;
            // 
            // orderdate_dtp
            // 
            resources.ApplyResources(this.orderdate_dtp, "orderdate_dtp");
            this.orderdate_dtp.Name = "orderdate_dtp";
            // 
            // DeliveryDate_dtp
            // 
            this.DeliveryDate_dtp.Controls.Add(this.deliverydatep);
            resources.ApplyResources(this.DeliveryDate_dtp, "DeliveryDate_dtp");
            this.DeliveryDate_dtp.Name = "DeliveryDate_dtp";
            this.DeliveryDate_dtp.TabStop = false;
            // 
            // deliverydatep
            // 
            resources.ApplyResources(this.deliverydatep, "deliverydatep");
            this.deliverydatep.Name = "deliverydatep";
            this.deliverydatep.ValueChanged += new System.EventHandler(this.deliverydatep_ValueChanged);
            // 
            // Operations
            // 
            resources.ApplyResources(this.Operations, "Operations");
            this.Operations.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.Operations.Name = "Operations";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.ArticlesCategory_listbox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ArticlesSelected_grpbx, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.Result_grpbox, 3, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // ArticlesCategory_listbox
            // 
            resources.ApplyResources(this.ArticlesCategory_listbox, "ArticlesCategory_listbox");
            this.ArticlesCategory_listbox.FormattingEnabled = true;
            this.ArticlesCategory_listbox.Name = "ArticlesCategory_listbox";
            this.ArticlesCategory_listbox.Click += new System.EventHandler(this.ArticlesCategory_listbox_Click);
            this.ArticlesCategory_listbox.SelectedValueChanged += new System.EventHandler(this.ArticlesCategory_listbox_SelectedValueChanged);
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.Reference_textbox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Articles_datagridview, 0, 1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // Articles_datagridview
            // 
            this.Articles_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Articles_datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Id,
            this.Reference,
            this.articleCategory,
            this.SellingPrice,
            this.Quantity});
            resources.ApplyResources(this.Articles_datagridview, "Articles_datagridview");
            this.Articles_datagridview.Name = "Articles_datagridview";
            this.Articles_datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Articles_datagridview_CellContentClick);
            // 
            // Select
            // 
            resources.ApplyResources(this.Select, "Select");
            this.Select.Name = "Select";
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
            // articleCategory
            // 
            this.articleCategory.DataPropertyName = "articleCategory";
            resources.ApplyResources(this.articleCategory, "articleCategory");
            this.articleCategory.Name = "articleCategory";
            this.articleCategory.ReadOnly = true;
            // 
            // SellingPrice
            // 
            this.SellingPrice.DataPropertyName = "SellingPrice";
            resources.ApplyResources(this.SellingPrice, "SellingPrice");
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.ReadOnly = true;
            // 
            // Quantity
            // 
            resources.ApplyResources(this.Quantity, "Quantity");
            this.Quantity.Name = "Quantity";
            // 
            // ArticlesSelected_grpbx
            // 
            this.ArticlesSelected_grpbx.Controls.Add(this.btn_pass_grpbx);
            this.ArticlesSelected_grpbx.Controls.Add(this.Liste_grpbx);
            resources.ApplyResources(this.ArticlesSelected_grpbx, "ArticlesSelected_grpbx");
            this.ArticlesSelected_grpbx.Name = "ArticlesSelected_grpbx";
            this.ArticlesSelected_grpbx.TabStop = false;
            // 
            // btn_pass_grpbx
            // 
            this.btn_pass_grpbx.Controls.Add(this.btn_pass);
            resources.ApplyResources(this.btn_pass_grpbx, "btn_pass_grpbx");
            this.btn_pass_grpbx.Name = "btn_pass_grpbx";
            this.btn_pass_grpbx.TabStop = false;
            // 
            // btn_pass
            // 
            resources.ApplyResources(this.btn_pass, "btn_pass");
            this.btn_pass.Name = "btn_pass";
            this.btn_pass.UseVisualStyleBackColor = true;
            this.btn_pass.Click += new System.EventHandler(this.btn_pass_Click);
            // 
            // Liste_grpbx
            // 
            this.Liste_grpbx.Controls.Add(this.ListeArticles_selected_listbox);
            resources.ApplyResources(this.Liste_grpbx, "Liste_grpbx");
            this.Liste_grpbx.Name = "Liste_grpbx";
            this.Liste_grpbx.TabStop = false;
            // 
            // ListeArticles_selected_listbox
            // 
            resources.ApplyResources(this.ListeArticles_selected_listbox, "ListeArticles_selected_listbox");
            this.ListeArticles_selected_listbox.FormattingEnabled = true;
            this.ListeArticles_selected_listbox.Name = "ListeArticles_selected_listbox";
            this.ListeArticles_selected_listbox.Click += new System.EventHandler(this.ListeArticles_selected_listbox_Click);
            this.ListeArticles_selected_listbox.SelectedValueChanged += new System.EventHandler(this.ListeArticles_selected_listbox_SelectedValueChanged);
            // 
            // Result_grpbox
            // 
            this.Result_grpbox.Controls.Add(this.Total_price_textbox);
            this.Result_grpbox.Controls.Add(this.label2);
            this.Result_grpbox.Controls.Add(this.Articles_count_textbox);
            this.Result_grpbox.Controls.Add(this.label1);
            resources.ApplyResources(this.Result_grpbox, "Result_grpbox");
            this.Result_grpbox.Name = "Result_grpbox";
            this.Result_grpbox.TabStop = false;
            // 
            // Total_price_textbox
            // 
            resources.ApplyResources(this.Total_price_textbox, "Total_price_textbox");
            this.Total_price_textbox.Name = "Total_price_textbox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Articles_count_textbox
            // 
            resources.ApplyResources(this.Articles_count_textbox, "Articles_count_textbox");
            this.Articles_count_textbox.Name = "Articles_count_textbox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btn_cancel
            // 
            resources.ApplyResources(this.btn_cancel, "btn_cancel");
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            resources.ApplyResources(this.btn_confirm, "btn_confirm");
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // Reference_textbox
            // 
            resources.ApplyResources(this.Reference_textbox, "Reference_textbox");
            this.Reference_textbox.Name = "Reference_textbox";
            this.Reference_textbox.TextChanged += new System.EventHandler(this.Reference_textbox_TextChanged);
            // 
            // FormSO
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.Operations);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormSO";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.OperationType_groupbox.ResumeLayout(false);
            this.Customer_groupbox.ResumeLayout(false);
            this.Customer_groupbox.PerformLayout();
            this.idCustomer_groupebox.ResumeLayout(false);
            this.idCustomer_groupebox.PerformLayout();
            this.ObjectCustomer_groupebox.ResumeLayout(false);
            this.OrderDate_groupebox.ResumeLayout(false);
            this.DeliveryDate_dtp.ResumeLayout(false);
            this.Operations.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Articles_datagridview)).EndInit();
            this.ArticlesSelected_grpbx.ResumeLayout(false);
            this.btn_pass_grpbx.ResumeLayout(false);
            this.Liste_grpbx.ResumeLayout(false);
            this.Result_grpbox.ResumeLayout(false);
            this.Result_grpbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox OperationType_groupbox;
        private System.Windows.Forms.GroupBox Customer_groupbox;
        private System.Windows.Forms.GroupBox idCustomer_groupebox;
        private System.Windows.Forms.Label idCustomer_label;
        private System.Windows.Forms.RadioButton IdCustomer_rdb;
        private System.Windows.Forms.RadioButton ObjectCustomer_rdb;
        private System.Windows.Forms.GroupBox ObjectCustomer_groupebox;
        private System.Windows.Forms.ComboBox ObjectCustomer_combo;
        private System.Windows.Forms.ComboBox OperationType_Combobox;
        private System.Windows.Forms.GroupBox OrderDate_groupebox;
        private System.Windows.Forms.DateTimePicker orderdate_dtp;
        private System.Windows.Forms.TableLayoutPanel Operations;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.GroupBox DeliveryDate_dtp;
        private System.Windows.Forms.DateTimePicker deliverydatep;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox ArticlesCategory_listbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView Articles_datagridview;
        private System.Windows.Forms.GroupBox ArticlesSelected_grpbx;
        private System.Windows.Forms.GroupBox btn_pass_grpbx;
        private System.Windows.Forms.Button btn_pass;
        private System.Windows.Forms.GroupBox Liste_grpbx;
        private System.Windows.Forms.ListBox ListeArticles_selected_listbox;
        private System.Windows.Forms.GroupBox Result_grpbox;
        private System.Windows.Forms.TextBox Articles_count_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Total_price_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.TextBox Reference_textbox;
    }
}