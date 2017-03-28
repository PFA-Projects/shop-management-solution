namespace ShopManagement.Forms.Form_Menu
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesCategoriesManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.providersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articlesManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articlesManagementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.articlesCategoryManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellToolStripMenuItem,
            this.expensesToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.providersToolStripMenuItem,
            this.articlesManagementToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.buyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sellToolStripMenuItem
            // 
            this.sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            this.sellToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.sellToolStripMenuItem.Text = "Sell";
            this.sellToolStripMenuItem.Click += new System.EventHandler(this.sellToolStripMenuItem_Click);
            // 
            // expensesToolStripMenuItem
            // 
            this.expensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expensesManagementToolStripMenuItem,
            this.expensesCategoriesManagementToolStripMenuItem});
            this.expensesToolStripMenuItem.Name = "expensesToolStripMenuItem";
            this.expensesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.expensesToolStripMenuItem.Text = "Expenses ";
            // 
            // expensesManagementToolStripMenuItem
            // 
            this.expensesManagementToolStripMenuItem.Name = "expensesManagementToolStripMenuItem";
            this.expensesManagementToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.expensesManagementToolStripMenuItem.Text = "Expenses Management";
            this.expensesManagementToolStripMenuItem.Click += new System.EventHandler(this.expensesManagementToolStripMenuItem_Click);
            // 
            // expensesCategoriesManagementToolStripMenuItem
            // 
            this.expensesCategoriesManagementToolStripMenuItem.Name = "expensesCategoriesManagementToolStripMenuItem";
            this.expensesCategoriesManagementToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.expensesCategoriesManagementToolStripMenuItem.Text = "Expenses Categories Management";
            this.expensesCategoriesManagementToolStripMenuItem.Click += new System.EventHandler(this.expensesCategoriesManagementToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // providersToolStripMenuItem
            // 
            this.providersToolStripMenuItem.Name = "providersToolStripMenuItem";
            this.providersToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.providersToolStripMenuItem.Text = "Providers Management";
            this.providersToolStripMenuItem.Click += new System.EventHandler(this.providersToolStripMenuItem_Click);
            // 
            // articlesManagementToolStripMenuItem
            // 
            this.articlesManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articlesManagementToolStripMenuItem1,
            this.articlesCategoryManagementToolStripMenuItem});
            this.articlesManagementToolStripMenuItem.Name = "articlesManagementToolStripMenuItem";
            this.articlesManagementToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.articlesManagementToolStripMenuItem.Text = "Articles ";
            // 
            // articlesManagementToolStripMenuItem1
            // 
            this.articlesManagementToolStripMenuItem1.Name = "articlesManagementToolStripMenuItem1";
            this.articlesManagementToolStripMenuItem1.Size = new System.Drawing.Size(238, 22);
            this.articlesManagementToolStripMenuItem1.Text = "Articles  Management";
            this.articlesManagementToolStripMenuItem1.Click += new System.EventHandler(this.articlesManagementToolStripMenuItem1_Click);
            // 
            // articlesCategoryManagementToolStripMenuItem
            // 
            this.articlesCategoryManagementToolStripMenuItem.Name = "articlesCategoryManagementToolStripMenuItem";
            this.articlesCategoryManagementToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.articlesCategoryManagementToolStripMenuItem.Text = "Articles Category Management";
            this.articlesCategoryManagementToolStripMenuItem.Click += new System.EventHandler(this.articlesCategoryManagementToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // buyToolStripMenuItem
            // 
            this.buyToolStripMenuItem.Name = "buyToolStripMenuItem";
            this.buyToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.buyToolStripMenuItem.Text = "Buy";
            this.buyToolStripMenuItem.Click += new System.EventHandler(this.buyToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 51);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.Click += new System.EventHandler(this.FormMenu_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expensesManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expensesCategoriesManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem providersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articlesManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articlesManagementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem articlesCategoryManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyToolStripMenuItem;
    }
}