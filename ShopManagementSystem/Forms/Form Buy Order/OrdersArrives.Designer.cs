namespace ShopManagement.Forms.Form_Buy_Order
{
    partial class OrdersArrives
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
            this.provider_grpbox = new System.Windows.Forms.GroupBox();
            this.prov_combo = new System.Windows.Forms.ComboBox();
            this.articles_dgv = new System.Windows.Forms.DataGridView();
            this.info_grpbx = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.diff_tb = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.provider_grpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articles_dgv)).BeginInit();
            this.info_grpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.28523F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.71477F));
            this.tableLayoutPanel1.Controls.Add(this.articles_dgv, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1192, 399);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.provider_grpbox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.info_grpbx, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.74046F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.25954F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(354, 393);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // provider_grpbox
            // 
            this.provider_grpbox.Controls.Add(this.prov_combo);
            this.provider_grpbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.provider_grpbox.Location = new System.Drawing.Point(3, 3);
            this.provider_grpbox.Name = "provider_grpbox";
            this.provider_grpbox.Size = new System.Drawing.Size(348, 48);
            this.provider_grpbox.TabIndex = 0;
            this.provider_grpbox.TabStop = false;
            this.provider_grpbox.Text = "Provider : ";
            // 
            // prov_combo
            // 
            this.prov_combo.FormattingEnabled = true;
            this.prov_combo.Location = new System.Drawing.Point(31, 21);
            this.prov_combo.Name = "prov_combo";
            this.prov_combo.Size = new System.Drawing.Size(297, 21);
            this.prov_combo.TabIndex = 0;
            // 
            // articles_dgv
            // 
            this.articles_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articles_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.articles_dgv.Location = new System.Drawing.Point(363, 3);
            this.articles_dgv.Name = "articles_dgv";
            this.articles_dgv.Size = new System.Drawing.Size(826, 393);
            this.articles_dgv.TabIndex = 2;
            // 
            // info_grpbx
            // 
            this.info_grpbx.Controls.Add(this.diff_tb);
            this.info_grpbx.Controls.Add(this.label1);
            this.info_grpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info_grpbx.Location = new System.Drawing.Point(3, 57);
            this.info_grpbx.Name = "info_grpbx";
            this.info_grpbx.Size = new System.Drawing.Size(348, 333);
            this.info_grpbx.TabIndex = 1;
            this.info_grpbx.TabStop = false;
            this.info_grpbx.Text = "Informations : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Difference between delivery date Expected and Now : ";
            // 
            // diff_tb
            // 
            this.diff_tb.Enabled = false;
            this.diff_tb.Location = new System.Drawing.Point(88, 73);
            this.diff_tb.Name = "diff_tb";
            this.diff_tb.Size = new System.Drawing.Size(231, 20);
            this.diff_tb.TabIndex = 1;
            // 
            // OrdersArrives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 399);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrdersArrives";
            this.Text = "Orders Arrives";
            this.Load += new System.EventHandler(this.OrdersArrives_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.provider_grpbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.articles_dgv)).EndInit();
            this.info_grpbx.ResumeLayout(false);
            this.info_grpbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox provider_grpbox;
        private System.Windows.Forms.ComboBox prov_combo;
        private System.Windows.Forms.DataGridView articles_dgv;
        private System.Windows.Forms.GroupBox info_grpbx;
        private System.Windows.Forms.TextBox diff_tb;
        private System.Windows.Forms.Label label1;
    }
}