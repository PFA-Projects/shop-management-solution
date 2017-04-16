//Mariam Ait Al
using App;
using App.Gwin;
using App.Gwin.Application.Presentation;
using App.Gwin.Application.Presentation.EntityManagement;
using App.Gwin.Attributes;
using App.Gwin.Entities.Secrurity.Authentication;
using GenericWinForm.Demo;
using ShopManagement.BAL;
using ShopManagement.BLL;
using ShopManagement.Entities;
using ShopManagement.Forms.Buy_Order__Historic;
using ShopManagement.Forms.Form_Buy_Order;
using ShopManagement.Forms.Sell_Order;
using ShopManagement.Forms.Statistic;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

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
            // Start Gwin Application with Authentification
            User user = null;

            user = User.CreateRootUser();
            user.Language = GwinApp.Languages.fr;
            GwinApp.Start(typeof(ModelContext), typeof(BaseBLO<>), null, user);

            //Form Aggrandize
            this.WindowState = FormWindowState.Maximized;
        }

        //Execute Menu Forms
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

        private void buyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void operationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuyOrder f = new FormBuyOrder();
            ManagerForm form = new ManagerForm(new BaseBLO<Article>(), null, this);
            this.IsMdiContainer = true;
            f.MdiParent = this;
            f.Show();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerForm form = new ManagerForm(new CustomersBLO(), null, this);
            this.IsMdiContainer = true;
            form.MdiParent = this;
            form.Show();
        }

        private void livraisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLivraison f = new FormLivraison();
            ManagerForm form = new ManagerForm(new BaseBLO<Article>(), null, this);
            this.IsMdiContainer = true;
            f.MdiParent = this;
            f.Show();
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerForm form = new ManagerForm(new configurationBLO(), null, this);
            this.IsMdiContainer = true;
            form.MdiParent = this;
            form.Show();
        }

        private void deponsesCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerForm form = new ManagerForm(new ExpenseCategoryBLO(), null, this);
            this.IsMdiContainer = true;
            form.MdiParent = this;
            form.Show();
        }

        private void expensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerForm form = new ManagerForm(new ExpensesBLO(), null, this);
            this.IsMdiContainer = true;
            form.MdiParent = this;
            form.Show();
        }

        private void operationsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSellOrder f = new FormSellOrder();
            ManagerForm form = new ManagerForm(new BaseBLO<Article>(), null, this);
            this.IsMdiContainer = true;
            f.MdiParent = this;
            f.Show();
        }

        private void livraisonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCustomerLivraison f = new FormCustomerLivraison();
            ManagerForm form = new ManagerForm(new BaseBLO<Article>(), null, this);
            this.IsMdiContainer = true;
            f.MdiParent = this;
            f.Show();
        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatisticNotifications f = new FormStatisticNotifications();
            ManagerForm form = new ManagerForm(new BaseBLO<Article>(), null, this);
            this.IsMdiContainer = true;
            f.MdiParent = this;
            f.Show();
        }

        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage(CultureInfo.CreateSpecificCulture("ar"));
        }


        public  void ChangeLanguage(CultureInfo cultureInfo)
        {

            // Must Delete All Entity Configuration, bacause it demande with language
            ConfigEntity x = ConfigEntity.CreateConfigEntity(typeof(User));
            x.Dispose();

            // Change Gwin CultureInfo Instance
            GwinApp.Instance.CultureInfo = cultureInfo;

            if(cultureInfo.TwoLetterISOLanguageName == "ar")
            {
                GwinApp.Instance.user.Language = GwinApp.Languages.ar;
            }
            if(cultureInfo.TwoLetterISOLanguageName == "fr")
            {
                GwinApp.Instance.user.Language = GwinApp.Languages.fr;
            }

            

            // Change Thread CultureInfo Instance
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            this.Reload();
            // ReLoad Applicaton Interface
            //instance.FormApplication.Reload();

            //[Role] Restart must be after Language change, for Set Application Name Title after 
            // Initialize Form
            GwinApp.Restart();
        }


        /// <summary>
        /// Clear All Controls in this form
        /// </summary>
        private void ClearAllControls()
        {
            // [Bug] : Not working with showen child form
            // [Temporary Fix]
            foreach (Control item in this.MdiChildren)
            {
                item.Dispose();
            }
            this.Controls.Clear();
        }
        public override void Reload()
        {
            // Clear All controls in Form Application
            this.ClearAllControls();

            InitializeComponent();


            if (GwinApp.Instance.CultureInfo.TwoLetterISOLanguageName == "fr" || GwinApp.Instance.CultureInfo.TwoLetterISOLanguageName == "en")
            {
                this.RightToLeftLayout = false;
                this.RightToLeft = RightToLeft.No;
            }
            else
            {
                this.RightToLeftLayout = true;
                this.RightToLeft = RightToLeft.Yes;
            }

            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
        }

        private void francaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage(CultureInfo.CreateSpecificCulture("fr"));
        }
    }
}
