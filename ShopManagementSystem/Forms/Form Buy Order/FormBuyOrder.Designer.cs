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
            this.s_grpbx = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.search_grpbx = new System.Windows.Forms.GroupBox();
            this.Articles_dgv = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequiredQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.get_grpbx = new System.Windows.Forms.GroupBox();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.selected_articles_lb = new System.Windows.Forms.ListBox();
            this.result_grpbx = new System.Windows.Forms.GroupBox();
            this.TotalPrice_tb = new System.Windows.Forms.TextBox();
            this.ac_count_tb = new System.Windows.Forms.TextBox();
            this.pro_tb = new System.Windows.Forms.TextBox();
            this.Optype_tb = new System.Windows.Forms.TextBox();
            this.btn_pass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Articles_Category_lb = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.OperationType_grpbx.SuspendLayout();
            this.prov_grpx.SuspendLayout();
            this.dde_grpx.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.s_grpbx.SuspendLayout();
            this.search_grpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Articles_dgv)).BeginInit();
            this.get_grpbx.SuspendLayout();
            this.result_grpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78498F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.21502F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1283, 484);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.OperationType_grpbx, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.prov_grpx, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dde_grpx, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.86792F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.13208F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(196, 478);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // OperationType_grpbx
            // 
            this.OperationType_grpbx.Controls.Add(this.OpType_combo);
            this.OperationType_grpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OperationType_grpbx.Location = new System.Drawing.Point(3, 3);
            this.OperationType_grpbx.Name = "OperationType_grpbx";
            this.OperationType_grpbx.Size = new System.Drawing.Size(190, 111);
            this.OperationType_grpbx.TabIndex = 0;
            this.OperationType_grpbx.TabStop = false;
            this.OperationType_grpbx.Text = "Operation Type : ";
            // 
            // OpType_combo
            // 
            this.OpType_combo.FormattingEnabled = true;
            this.OpType_combo.Location = new System.Drawing.Point(21, 38);
            this.OpType_combo.Name = "OpType_combo";
            this.OpType_combo.Size = new System.Drawing.Size(145, 21);
            this.OpType_combo.TabIndex = 0;
            this.OpType_combo.SelectedValueChanged += new System.EventHandler(this.OpType_combo_SelectedValueChanged);
            // 
            // prov_grpx
            // 
            this.prov_grpx.Controls.Add(this.id_pro_label);
            this.prov_grpx.Controls.Add(this.pro_rdb);
            this.prov_grpx.Controls.Add(this.providerId_label);
            this.prov_grpx.Controls.Add(this.id_provider_label);
            this.prov_grpx.Controls.Add(this.pro_combo);
            this.prov_grpx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prov_grpx.Location = new System.Drawing.Point(3, 120);
            this.prov_grpx.Name = "prov_grpx";
            this.prov_grpx.Size = new System.Drawing.Size(190, 144);
            this.prov_grpx.TabIndex = 1;
            this.prov_grpx.TabStop = false;
            this.prov_grpx.Text = "Provider : ";
            // 
            // id_pro_label
            // 
            this.id_pro_label.AutoSize = true;
            this.id_pro_label.Location = new System.Drawing.Point(7, 96);
            this.id_pro_label.Name = "id_pro_label";
            this.id_pro_label.Size = new System.Drawing.Size(14, 13);
            this.id_pro_label.TabIndex = 6;
            this.id_pro_label.TabStop = true;
            this.id_pro_label.UseVisualStyleBackColor = true;
            this.id_pro_label.CheckedChanged += new System.EventHandler(this.id_pro_label_CheckedChanged);
            // 
            // pro_rdb
            // 
            this.pro_rdb.AutoSize = true;
            this.pro_rdb.Location = new System.Drawing.Point(7, 49);
            this.pro_rdb.Name = "pro_rdb";
            this.pro_rdb.Size = new System.Drawing.Size(14, 13);
            this.pro_rdb.TabIndex = 5;
            this.pro_rdb.TabStop = true;
            this.pro_rdb.UseVisualStyleBackColor = true;
            this.pro_rdb.CheckedChanged += new System.EventHandler(this.pro_rdb_CheckedChanged);
            // 
            // providerId_label
            // 
            this.providerId_label.AutoSize = true;
            this.providerId_label.Location = new System.Drawing.Point(37, 96);
            this.providerId_label.Name = "providerId_label";
            this.providerId_label.Size = new System.Drawing.Size(0, 13);
            this.providerId_label.TabIndex = 4;
            // 
            // id_provider_label
            // 
            this.id_provider_label.AutoSize = true;
            this.id_provider_label.Location = new System.Drawing.Point(37, 96);
            this.id_provider_label.Name = "id_provider_label";
            this.id_provider_label.Size = new System.Drawing.Size(0, 13);
            this.id_provider_label.TabIndex = 1;
            // 
            // pro_combo
            // 
            this.pro_combo.FormattingEnabled = true;
            this.pro_combo.Location = new System.Drawing.Point(37, 46);
            this.pro_combo.Name = "pro_combo";
            this.pro_combo.Size = new System.Drawing.Size(129, 21);
            this.pro_combo.TabIndex = 0;
            this.pro_combo.SelectedValueChanged += new System.EventHandler(this.pro_combo_SelectedValueChanged);
            // 
            // dde_grpx
            // 
            this.dde_grpx.Controls.Add(this.dd_dtp);
            this.dde_grpx.Location = new System.Drawing.Point(3, 270);
            this.dde_grpx.Name = "dde_grpx";
            this.dde_grpx.Size = new System.Drawing.Size(172, 103);
            this.dde_grpx.TabIndex = 2;
            this.dde_grpx.TabStop = false;
            this.dde_grpx.Text = "Delivery Date Expected : ";
            // 
            // dd_dtp
            // 
            this.dd_dtp.Location = new System.Drawing.Point(21, 56);
            this.dd_dtp.Name = "dd_dtp";
            this.dd_dtp.Size = new System.Drawing.Size(145, 20);
            this.dd_dtp.TabIndex = 0;
            this.dd_dtp.ValueChanged += new System.EventHandler(this.dd_dtp_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_confirm);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(21, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 96);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(52, 53);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(114, 23);
            this.btn_confirm.TabIndex = 0;
            this.btn_confirm.Text = "confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.452139F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.54786F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Articles_Category_lb, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(205, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1075, 478);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.8547F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.1453F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 395F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.selected_articles_lb, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.result_grpbx, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(93, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.77119F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.22881F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(979, 472);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.s_grpbx, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.search_grpbx, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.get_grpbx, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.55856F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.44144F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 354F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(466, 466);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // s_grpbx
            // 
            this.s_grpbx.Controls.Add(this.label6);
            this.s_grpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.s_grpbx.Location = new System.Drawing.Point(3, 3);
            this.s_grpbx.Name = "s_grpbx";
            this.s_grpbx.Size = new System.Drawing.Size(460, 59);
            this.s_grpbx.TabIndex = 1;
            this.s_grpbx.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(422, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "YOU MUST FILL THE REQUIRED QUANTITY BEFORE SELECTING ANY ARTICLE !!";
            // 
            // search_grpbx
            // 
            this.search_grpbx.Controls.Add(this.Articles_dgv);
            this.search_grpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_grpbx.Location = new System.Drawing.Point(3, 114);
            this.search_grpbx.Name = "search_grpbx";
            this.search_grpbx.Size = new System.Drawing.Size(460, 349);
            this.search_grpbx.TabIndex = 2;
            this.search_grpbx.TabStop = false;
            // 
            // Articles_dgv
            // 
            this.Articles_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Articles_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.Id,
            this.RequiredQuantity,
            this.Reference,
            this.Quantity});
            this.Articles_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Articles_dgv.Location = new System.Drawing.Point(3, 16);
            this.Articles_dgv.Name = "Articles_dgv";
            this.Articles_dgv.Size = new System.Drawing.Size(454, 330);
            this.Articles_dgv.TabIndex = 1;
            this.Articles_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Articles_dgv_CellContentClick_1);
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
            // RequiredQuantity
            // 
            this.RequiredQuantity.HeaderText = "Required Quantity";
            this.RequiredQuantity.Name = "RequiredQuantity";
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
            this.Quantity.HeaderText = "Quantity in stock";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // get_grpbx
            // 
            this.get_grpbx.Controls.Add(this.search_tb);
            this.get_grpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.get_grpbx.Location = new System.Drawing.Point(3, 68);
            this.get_grpbx.Name = "get_grpbx";
            this.get_grpbx.Size = new System.Drawing.Size(460, 40);
            this.get_grpbx.TabIndex = 3;
            this.get_grpbx.TabStop = false;
            this.get_grpbx.Text = "Search : ";
            // 
            // search_tb
            // 
            this.search_tb.Location = new System.Drawing.Point(178, 14);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(277, 20);
            this.search_tb.TabIndex = 0;
            // 
            // selected_articles_lb
            // 
            this.selected_articles_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selected_articles_lb.FormattingEnabled = true;
            this.selected_articles_lb.Location = new System.Drawing.Point(475, 3);
            this.selected_articles_lb.Name = "selected_articles_lb";
            this.selected_articles_lb.Size = new System.Drawing.Size(105, 466);
            this.selected_articles_lb.TabIndex = 1;
            // 
            // result_grpbx
            // 
            this.result_grpbx.Controls.Add(this.TotalPrice_tb);
            this.result_grpbx.Controls.Add(this.ac_count_tb);
            this.result_grpbx.Controls.Add(this.pro_tb);
            this.result_grpbx.Controls.Add(this.Optype_tb);
            this.result_grpbx.Controls.Add(this.btn_pass);
            this.result_grpbx.Controls.Add(this.label5);
            this.result_grpbx.Controls.Add(this.label4);
            this.result_grpbx.Controls.Add(this.label3);
            this.result_grpbx.Controls.Add(this.label2);
            this.result_grpbx.Controls.Add(this.label1);
            this.result_grpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result_grpbx.Location = new System.Drawing.Point(586, 3);
            this.result_grpbx.Name = "result_grpbx";
            this.result_grpbx.Size = new System.Drawing.Size(390, 466);
            this.result_grpbx.TabIndex = 2;
            this.result_grpbx.TabStop = false;
            this.result_grpbx.Text = "Result : ";
            // 
            // TotalPrice_tb
            // 
            this.TotalPrice_tb.Enabled = false;
            this.TotalPrice_tb.Location = new System.Drawing.Point(76, 280);
            this.TotalPrice_tb.Name = "TotalPrice_tb";
            this.TotalPrice_tb.Size = new System.Drawing.Size(244, 20);
            this.TotalPrice_tb.TabIndex = 9;
            // 
            // ac_count_tb
            // 
            this.ac_count_tb.Enabled = false;
            this.ac_count_tb.Location = new System.Drawing.Point(76, 220);
            this.ac_count_tb.Name = "ac_count_tb";
            this.ac_count_tb.Size = new System.Drawing.Size(244, 20);
            this.ac_count_tb.TabIndex = 8;
            // 
            // pro_tb
            // 
            this.pro_tb.Enabled = false;
            this.pro_tb.Location = new System.Drawing.Point(76, 148);
            this.pro_tb.Name = "pro_tb";
            this.pro_tb.Size = new System.Drawing.Size(244, 20);
            this.pro_tb.TabIndex = 7;
            // 
            // Optype_tb
            // 
            this.Optype_tb.Enabled = false;
            this.Optype_tb.Location = new System.Drawing.Point(76, 85);
            this.Optype_tb.Name = "Optype_tb";
            this.Optype_tb.Size = new System.Drawing.Size(244, 20);
            this.Optype_tb.TabIndex = 6;
            // 
            // btn_pass
            // 
            this.btn_pass.Location = new System.Drawing.Point(7, 442);
            this.btn_pass.Name = "btn_pass";
            this.btn_pass.Size = new System.Drawing.Size(96, 23);
            this.btn_pass.TabIndex = 5;
            this.btn_pass.Text = "Confirm";
            this.btn_pass.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Price : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Articles Count : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Provider : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operation Type : ";
            // 
            // Articles_Category_lb
            // 
            this.Articles_Category_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Articles_Category_lb.FormattingEnabled = true;
            this.Articles_Category_lb.Location = new System.Drawing.Point(3, 3);
            this.Articles_Category_lb.Name = "Articles_Category_lb";
            this.Articles_Category_lb.Size = new System.Drawing.Size(84, 472);
            this.Articles_Category_lb.TabIndex = 1;
            this.Articles_Category_lb.Click += new System.EventHandler(this.Articles_Category_lb_Click);
            // 
            // FormBuyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 484);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormBuyOrder";
            this.Text = "Buy Order";
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
            this.s_grpbx.ResumeLayout(false);
            this.s_grpbx.PerformLayout();
            this.search_grpbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Articles_dgv)).EndInit();
            this.get_grpbx.ResumeLayout(false);
            this.get_grpbx.PerformLayout();
            this.result_grpbx.ResumeLayout(false);
            this.result_grpbx.PerformLayout();
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
        private System.Windows.Forms.GroupBox result_grpbx;
        private System.Windows.Forms.Button btn_pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalPrice_tb;
        private System.Windows.Forms.TextBox ac_count_tb;
        private System.Windows.Forms.TextBox pro_tb;
        private System.Windows.Forms.TextBox Optype_tb;
        private System.Windows.Forms.ListBox selected_articles_lb;
        private System.Windows.Forms.Label providerId_label;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton prov_rdb;
        private System.Windows.Forms.Label id_provider_label;
        private System.Windows.Forms.GroupBox s_grpbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox search_grpbx;
        private System.Windows.Forms.DataGridView Articles_dgv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequiredQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.GroupBox get_grpbx;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.ListBox Articles_Category_lb;
        private System.Windows.Forms.RadioButton id_pro_label;
        private System.Windows.Forms.RadioButton pro_rdb;
    }
}