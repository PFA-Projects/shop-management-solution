using App;
using App.Gwin;
using App.Gwin.Entities.Secrurity.Authentication;
using GenericWinForm.Demo;
using ShopManagement.BAL;
using ShopManagement.BLL;
using ShopManagement.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement.Forms.Form_Buy_Order
{
    public partial class FormBuyOrder : Form
    {
        //Initialize the ModelContext
        ModelContext db = new ModelContext();
        public FormBuyOrder()
        {
            InitializeComponent();
        }

        private void FormBuyOrder_Load(object sender, EventArgs e)
        {
            // Application User
            User user = new User();
            user.Language = GwinApp.Languages.en;

            // Start Gwin Application
            FormMenuApplication form = new FormMenuApplication();
            GwinApp.Start(typeof(ModelContext), typeof(BaseBLO<>), form, user);

            //Alert about choosing the provider
            MessageBox.Show("Please , Choose The Provider , Before starting the operation !! ");
            //Filling the provider's combobox 
            prov_combo.DataSource = null;
            prov_combo.DataSource = new ProviderBLO(db).GetAll();
            //Filling the articles categories listbox
            ArtC_listbox.DataSource = null;
            ArtC_listbox.DataSource = new ArticlesCategoryBLO(db).GetAll();
            
        }
        //Define the selected  provider 
        Provider provider = new Provider();
        private void prov_combo_SelectedValueChanged(object sender, EventArgs e)
        {
            provider = (Provider)prov_combo.SelectedItem;
        }

        private void ArtC_listbox_Click(object sender, EventArgs e)
        {
            Articles_dgv.DataSource = null;
            Articles_dgv.DataSource = new ArticlesBLO(db).SearchByCateory((ArticleCategory)ArtC_listbox.SelectedItem);
        }

        private void Search_tb_TextChanged(object sender, EventArgs e)
        {
            Articles_dgv.DataSource = null;

            Dictionary<string, object> Criteria = new Dictionary<string, object>();
            Criteria.Add(nameof(Article.Reference), Search_tb.Text);
            Articles_dgv.DataSource = new ArticlesBLO(db).Recherche(Criteria);
        }

        private void Search_tb_TextChanged_1(object sender, EventArgs e)
        {
            Articles_dgv.DataSource = null;

            Dictionary<string, object> Criteria = new Dictionary<string, object>();
            Criteria.Add(nameof(Article.Reference), Search_tb.Text);
            Articles_dgv.DataSource = new ArticlesBLO(db).Recherche(Criteria);
        }
    }
}
