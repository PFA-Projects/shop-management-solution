//Mariam Ait Al
using App;
using App.Gwin;
using App.Gwin.Application.Presentation;
using App.Gwin.Application.Presentation.EntityManagement;
using App.Gwin.Entities.Secrurity.Authentication;
using ShopManagement.BAL;
using ShopManagement.BLL;
using System;

namespace ShopManagement.Forms.Form_Menu
{
    public partial class FormMenu : BaseForm
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            // Application User
            User user = new User();
            user.Language = GwinApp.Languages.en;

            // Start Gwin Application
            GwinApp.Start(typeof(ModelContext), typeof(BaseBLO<>), null, user);
        }

        //
        private void providersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerForm form = new ManagerForm(new ProviderBLO(), null, this);
            this.IsMdiContainer = true;
            form.MdiParent = this;
            form.Show();
        }

        private void articleCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerForm form = new ManagerForm(new ArticlesCategoryBLO(), null, this);
            this.IsMdiContainer = true;
            form.MdiParent = this;
            form.Show();
        }

        private void articlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerForm form = new ManagerForm(new ArticlesBLO(), null, this);
            this.IsMdiContainer = true;
            form.MdiParent = this;
            form.Show();
        }
    }
}
