namespace ShopManagement.Forms.Form_Buy_Order
{
    partial class FormBuy
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
            this.provider_grpbx = new System.Windows.Forms.GroupBox();
            this.prov_label = new System.Windows.Forms.Label();
            this.provider_combo = new System.Windows.Forms.ComboBox();
            this.ArticlesCategory_Listbox = new System.Windows.Forms.ListBox();
            this.Articles_Dgv = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provider_grpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Articles_Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // provider_grpbx
            // 
            this.provider_grpbx.Controls.Add(this.prov_label);
            this.provider_grpbx.Controls.Add(this.provider_combo);
            this.provider_grpbx.Location = new System.Drawing.Point(0, 2);
            this.provider_grpbx.Name = "provider_grpbx";
            this.provider_grpbx.Size = new System.Drawing.Size(147, 78);
            this.provider_grpbx.TabIndex = 0;
            this.provider_grpbx.TabStop = false;
            this.provider_grpbx.Text = "Provider : ";
            // 
            // prov_label
            // 
            this.prov_label.AutoSize = true;
            this.prov_label.Location = new System.Drawing.Point(52, 72);
            this.prov_label.Name = "prov_label";
            this.prov_label.Size = new System.Drawing.Size(0, 13);
            this.prov_label.TabIndex = 1;
            // 
            // provider_combo
            // 
            this.provider_combo.FormattingEnabled = true;
            this.provider_combo.Location = new System.Drawing.Point(6, 33);
            this.provider_combo.Name = "provider_combo";
            this.provider_combo.Size = new System.Drawing.Size(121, 21);
            this.provider_combo.TabIndex = 1;
            this.provider_combo.SelectedValueChanged += new System.EventHandler(this.provider_combo_SelectedValueChanged);
            // 
            // ArticlesCategory_Listbox
            // 
            this.ArticlesCategory_Listbox.FormattingEnabled = true;
            this.ArticlesCategory_Listbox.Location = new System.Drawing.Point(0, 87);
            this.ArticlesCategory_Listbox.Name = "ArticlesCategory_Listbox";
            this.ArticlesCategory_Listbox.Size = new System.Drawing.Size(147, 251);
            this.ArticlesCategory_Listbox.TabIndex = 1;
            this.ArticlesCategory_Listbox.Click += new System.EventHandler(this.ArticlesCategory_Listbox_Click);
            this.ArticlesCategory_Listbox.SelectedValueChanged += new System.EventHandler(this.ArticlesCategory_Listbox_SelectedValueChanged);
            // 
            // Articles_Dgv
            // 
            this.Articles_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Articles_Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Quantity,
            this.BuyingPrice,
            this.SellingPrice,
            this.articleCategory});
            this.Articles_Dgv.Location = new System.Drawing.Point(153, 48);
            this.Articles_Dgv.Name = "Articles_Dgv";
            this.Articles_Dgv.Size = new System.Drawing.Size(649, 290);
            this.Articles_Dgv.TabIndex = 2;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
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
            // SellingPrice
            // 
            this.SellingPrice.DataPropertyName = "SellingPrice";
            this.SellingPrice.HeaderText = "SellingPrice";
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.ReadOnly = true;
            // 
            // articleCategory
            // 
            this.articleCategory.DataPropertyName = "articleCategory";
            this.articleCategory.HeaderText = "articleCategory";
            this.articleCategory.Name = "articleCategory";
            this.articleCategory.ReadOnly = true;
            // 
            // FormBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 345);
            this.Controls.Add(this.Articles_Dgv);
            this.Controls.Add(this.ArticlesCategory_Listbox);
            this.Controls.Add(this.provider_grpbx);
          //  this.Name = "FormBuy";
            this.Text = "Buy";
            this.Load += new System.EventHandler(this.FormBuy_Load);
            this.provider_grpbx.ResumeLayout(false);
            this.provider_grpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Articles_Dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox provider_grpbx;
        private System.Windows.Forms.Label prov_label;
        private System.Windows.Forms.ComboBox provider_combo;
        private System.Windows.Forms.ListBox ArticlesCategory_Listbox;
        private System.Windows.Forms.DataGridView Articles_Dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleCategory;
    }
}