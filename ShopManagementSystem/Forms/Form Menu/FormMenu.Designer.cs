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
            this.deponsesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deponsesManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deponseCategoryManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellToolStripMenuItem,
            this.deponsesToolStripMenuItem});
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
            // deponsesToolStripMenuItem
            // 
            this.deponsesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deponsesManagementToolStripMenuItem,
            this.deponseCategoryManagementToolStripMenuItem});
            this.deponsesToolStripMenuItem.Name = "deponsesToolStripMenuItem";
            this.deponsesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.deponsesToolStripMenuItem.Text = "Deponses";
            // 
            // deponsesManagementToolStripMenuItem
            // 
            this.deponsesManagementToolStripMenuItem.Name = "deponsesManagementToolStripMenuItem";
            this.deponsesManagementToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.deponsesManagementToolStripMenuItem.Text = "Deponses Management";
            this.deponsesManagementToolStripMenuItem.Click += new System.EventHandler(this.deponsesManagementToolStripMenuItem_Click);
            // 
            // deponseCategoryManagementToolStripMenuItem
            // 
            this.deponseCategoryManagementToolStripMenuItem.Name = "deponseCategoryManagementToolStripMenuItem";
            this.deponseCategoryManagementToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.deponseCategoryManagementToolStripMenuItem.Text = "Deponse Category Management";
            this.deponseCategoryManagementToolStripMenuItem.Click += new System.EventHandler(this.deponseCategoryManagementToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 262);
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
        private System.Windows.Forms.ToolStripMenuItem deponsesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deponsesManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deponseCategoryManagementToolStripMenuItem;
    }
}