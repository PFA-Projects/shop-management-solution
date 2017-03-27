//Mariam Ait Al
using App;
using App.Gwin;
using App.Gwin.Application.Presentation;
using App.Gwin.Application.Presentation.EntityManagement;
using App.Gwin.Entities.Secrurity.Authentication;
using ShopManagement.BAL;
using ShopManagement.BLL;
using ShopManagement.Entities;
using ShopManagement.Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // Application User
            User user = new User();
            user.Language = GwinApp.Languages.fr;

            // Start Gwin Application
            GwinApp.Start(typeof(ModelContext), typeof(BaseBLO<>), null, user);
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSO fso = new FormSO();
            //ManagerForm form = new ManagerForm(new BaseBLO<Customer>(), null, this);
            //
            this.IsMdiContainer = true;
            //
            fso.MdiParent = this;
            fso.Show();
            //fso.Show();
        }

        private void FormMenu_Click(object sender, EventArgs e)
        {
           
        }

        private void deponsesManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerForm form = new ManagerForm(new DeponsesBLO(), null, this);
            //
            this.IsMdiContainer = true;
            //
            form.MdiParent = this;
            form.Show();
        }

        private void deponseCategoryManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerForm form = new ManagerForm(new DeponseCategoryBLO(), null, this);
            //
            this.IsMdiContainer = true;
            //
            form.MdiParent = this;
            form.Show();
        }
    }
}
