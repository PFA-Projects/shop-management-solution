namespace ShopManagement.Commande_Vente
{
    partial class FormOrder_Sell
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
            this.tab_vente = new System.Windows.Forms.TabPage();
            this.Ref_Article_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CustomerNumber_Label = new System.Windows.Forms.Label();
            this.Customer_Combo = new System.Windows.Forms.ComboBox();
            this.CustomerId_rdb = new System.Windows.Forms.RadioButton();
            this.CustomerName_rdb = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CategoriesArticle_ListBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Articles_datagridview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_vente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Articles_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_vente
            // 
            this.tab_vente.Controls.Add(this.label1);
            this.tab_vente.Controls.Add(this.Ref_Article_TextBox);
            this.tab_vente.Controls.Add(this.groupBox1);
            this.tab_vente.Controls.Add(this.tableLayoutPanel2);
            this.tab_vente.Controls.Add(this.tableLayoutPanel1);
            this.tab_vente.Location = new System.Drawing.Point(4, 22);
            this.tab_vente.Name = "tab_vente";
            this.tab_vente.Size = new System.Drawing.Size(1241, 443);
            this.tab_vente.TabIndex = 0;
            this.tab_vente.Text = "vente";
            this.tab_vente.UseVisualStyleBackColor = true;
            this.tab_vente.Click += new System.EventHandler(this.tab_vente_Click);
            // 
            // Ref_Article_TextBox
            // 
            this.Ref_Article_TextBox.Location = new System.Drawing.Point(460, 142);
            this.Ref_Article_TextBox.Name = "Ref_Article_TextBox";
            this.Ref_Article_TextBox.Size = new System.Drawing.Size(255, 20);
            this.Ref_Article_TextBox.TabIndex = 8;
            this.Ref_Article_TextBox.TextChanged += new System.EventHandler(this.Ref_Article_TextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CustomerNumber_Label);
            this.groupBox1.Controls.Add(this.Customer_Combo);
            this.groupBox1.Controls.Add(this.CustomerId_rdb);
            this.groupBox1.Controls.Add(this.CustomerName_rdb);
            this.groupBox1.Location = new System.Drawing.Point(460, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 97);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client : ";
            // 
            // CustomerNumber_Label
            // 
            this.CustomerNumber_Label.AutoSize = true;
            this.CustomerNumber_Label.Location = new System.Drawing.Point(79, 61);
            this.CustomerNumber_Label.Name = "CustomerNumber_Label";
            this.CustomerNumber_Label.Size = new System.Drawing.Size(13, 13);
            this.CustomerNumber_Label.TabIndex = 3;
            this.CustomerNumber_Label.Text = "0";
            // 
            // Customer_Combo
            // 
            this.Customer_Combo.FormattingEnabled = true;
            this.Customer_Combo.Location = new System.Drawing.Point(79, 26);
            this.Customer_Combo.Name = "Customer_Combo";
            this.Customer_Combo.Size = new System.Drawing.Size(255, 21);
            this.Customer_Combo.TabIndex = 2;
            // 
            // CustomerId_rdb
            // 
            this.CustomerId_rdb.AutoSize = true;
            this.CustomerId_rdb.Location = new System.Drawing.Point(35, 61);
            this.CustomerId_rdb.Name = "CustomerId_rdb";
            this.CustomerId_rdb.Size = new System.Drawing.Size(14, 13);
            this.CustomerId_rdb.TabIndex = 1;
            this.CustomerId_rdb.TabStop = true;
            this.CustomerId_rdb.UseVisualStyleBackColor = true;
            this.CustomerId_rdb.Click += new System.EventHandler(this.CustomerId_rdb_Click);
            // 
            // CustomerName_rdb
            // 
            this.CustomerName_rdb.AutoSize = true;
            this.CustomerName_rdb.Location = new System.Drawing.Point(35, 29);
            this.CustomerName_rdb.Name = "CustomerName_rdb";
            this.CustomerName_rdb.Size = new System.Drawing.Size(14, 13);
            this.CustomerName_rdb.TabIndex = 0;
            this.CustomerName_rdb.TabStop = true;
            this.CustomerName_rdb.UseVisualStyleBackColor = true;
            this.CustomerName_rdb.Click += new System.EventHandler(this.CustomerName_rdb_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.72046F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.27954F));
            this.tableLayoutPanel2.Controls.Add(this.Articles_datagridview, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(200, 168);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1041, 275);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CategoriesArticle_ListBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 443);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CategoriesArticle_ListBox
            // 
            this.CategoriesArticle_ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriesArticle_ListBox.FormattingEnabled = true;
            this.CategoriesArticle_ListBox.Location = new System.Drawing.Point(3, 3);
            this.CategoriesArticle_ListBox.Name = "CategoriesArticle_ListBox";
            this.CategoriesArticle_ListBox.Size = new System.Drawing.Size(194, 437);
            this.CategoriesArticle_ListBox.TabIndex = 0;
            this.CategoriesArticle_ListBox.SelectedValueChanged += new System.EventHandler(this.CategoriesArticle_ListBox_SelectedValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_vente);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1249, 469);
            this.tabControl1.TabIndex = 0;
            // 
            // Articles_datagridview
            // 
            this.Articles_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Articles_datagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Articles_datagridview.Location = new System.Drawing.Point(3, 3);
            this.Articles_datagridview.Name = "Articles_datagridview";
            this.Articles_datagridview.Size = new System.Drawing.Size(522, 269);
            this.Articles_datagridview.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reference : ";
            // 
            // FormOrder_Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 469);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormOrder_Sell";
            this.Text = "Order/Sell";
            this.tab_vente.ResumeLayout(false);
            this.tab_vente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Articles_datagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tab_vente;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CustomerNumber_Label;
        private System.Windows.Forms.ComboBox Customer_Combo;
        private System.Windows.Forms.RadioButton CustomerId_rdb;
        private System.Windows.Forms.RadioButton CustomerName_rdb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox CategoriesArticle_ListBox;
        private System.Windows.Forms.TextBox Ref_Article_TextBox;
        private System.Windows.Forms.DataGridView Articles_datagridview;
        private System.Windows.Forms.Label label1;
    }
}