//Mariam Ait Al

using App;
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
    public partial class FormBuy : Form
    {
        //Initialize the modelContext
        ModelContext db = new ModelContext();
        public FormBuy()
        {
            InitializeComponent();
        }

        private void FormBuy_Load(object sender, EventArgs e)
        {
            Articles_Dgv.AutoGenerateColumns = false;
            //Filling the provider combo with the providers list
            provider_combo.DataSource = null;
            provider_combo.DataSource = new ProviderBLO(db).GetAll();
            //
            ArticlesCategory_Listbox.DataSource = null;
        }
        //Provider Instance
        Provider provider = new Provider();
        private void provider_combo_SelectedValueChanged(object sender, EventArgs e)
        {
            //Define the selected provider
            provider = (Provider)provider_combo.SelectedItem;
            //Filling the Articles Category listbox
            ArticlesCategory_Listbox.DataSource = null;
            ArticlesCategory_Listbox.DataSource = new ArticlesCategoryBLO(db).GetAll();
        }

        private void ArticlesCategory_Listbox_Click(object sender, EventArgs e)
        {
            Articles_Dgv.DataSource = null;
            Articles_Dgv.DataSource = new ArticlesBLO(db).SearchByCateory((ArticleCategory)ArticlesCategory_Listbox.SelectedItem);
        }

        private void ArticlesCategory_Listbox_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
