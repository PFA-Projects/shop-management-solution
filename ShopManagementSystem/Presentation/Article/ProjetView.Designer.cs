namespace ShopManagement.Presentation.Article
{
    partial class ProjetView
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_article = new System.Windows.Forms.Panel();
            this.stringField1 = new App.Gwin.Fields.StringField();
            this.stringField2 = new App.Gwin.Fields.StringField();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_article.SuspendLayout();
            this.SuspendLayout();
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.Location = new System.Drawing.Point(12, 48);
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel_article);
            this.splitContainer1.Size = new System.Drawing.Size(764, 517);
            this.splitContainer1.SplitterDistance = 425;
            // 
            // tabControlForm
            // 
            this.tabControlForm.Location = new System.Drawing.Point(23, 48);
            this.tabControlForm.Size = new System.Drawing.Size(259, 156);
            this.tabControlForm.Visible = false;
            // 
            // panel_article
            // 
            this.panel_article.Controls.Add(this.stringField2);
            this.panel_article.Controls.Add(this.stringField1);
            this.panel_article.Location = new System.Drawing.Point(12, 17);
            this.panel_article.Name = "panel_article";
            this.panel_article.Size = new System.Drawing.Size(687, 337);
            this.panel_article.TabIndex = 0;
            // 
            // stringField1
            // 
            this.stringField1.AutoSizeConfig = true;
            this.stringField1.IsMultiline = false;
            this.stringField1.Location = new System.Drawing.Point(32, 41);
            this.stringField1.Name = "stringField1";
            this.stringField1.NombreLigne = 5;
            this.stringField1.OrientationField = System.Windows.Forms.Orientation.Horizontal;
            this.stringField1.PropertyInfo = null;
            this.stringField1.Size = new System.Drawing.Size(100, 40);
            this.stringField1.SizeControl = new System.Drawing.Size(100, 20);
            this.stringField1.SizeLabel = new System.Drawing.Size(100, 20);
            this.stringField1.TabIndex = 0;
            this.stringField1.Value = "";
            // 
            // stringField2
            // 
            this.stringField2.AutoSizeConfig = true;
            this.stringField2.IsMultiline = false;
            this.stringField2.Location = new System.Drawing.Point(32, 114);
            this.stringField2.Name = "stringField2";
            this.stringField2.NombreLigne = 5;
            this.stringField2.OrientationField = System.Windows.Forms.Orientation.Horizontal;
            this.stringField2.PropertyInfo = null;
            this.stringField2.Size = new System.Drawing.Size(100, 40);
            this.stringField2.SizeControl = new System.Drawing.Size(100, 20);
            this.stringField2.SizeLabel = new System.Drawing.Size(100, 20);
            this.stringField2.TabIndex = 1;
            this.stringField2.Value = "";
            // 
            // ProjetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "ProjetView";
            this.Size = new System.Drawing.Size(764, 517);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel_article.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_article;
        private App.Gwin.Fields.StringField stringField2;
        private App.Gwin.Fields.StringField stringField1;
    }
}
