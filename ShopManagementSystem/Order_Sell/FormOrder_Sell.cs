//Mariam Ait Al

using App;
using App.Gwin;
using App.Gwin.Entities.Secrurity.Authentication;
using GenericWinForm.Demo;
using ShopManagement.BAL;
using ShopManagement.Entities;
using ShopManagement.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement.Commande_Vente
{
    public partial class FormOrder_Sell : Form
    {
        //Instancier ModelContext
        ModelContext db = new ModelContext();

        public FormOrder_Sell()
        {
            InitializeComponent();

            CategoriesArticle_ListBox.SelectedIndex = -1;

            // Application User
            User user = new User();
            user.Language = GwinApp.Languages.fr;
            FormMenuApplication f = new FormMenuApplication();
            // Start Gwin Application
            GwinApp.Start(typeof(ModelContext), typeof(BaseBLO<>), f, user);

            //Initialiser Combo
            Customer_Combo.DataSource = null;

            //Enabled Combo / Label  Before Choosing the type with radioButton !
            Customer_Combo.Enabled = false;
            CustomerNumber_Label.Text = "0";

            //Filling the listebox with  the categories articles
            CategoriesArticle_ListBox.DataSource = null;
            CategoriesArticle_ListBox.DataSource = new ArticleCategories().ListCategoriesArticle();
            CategoriesArticle_ListBox.DisplayMember = "Name";
            CategoriesArticle_ListBox.ValueMember = "Id";

            //Filling the datagridview with list articles
            Articles_datagridview.DataSource = null;
            Articles_datagridview.DataSource = new Articles().ListArticles();
                //Remove some columns from the  datagridview
            Articles_datagridview.Columns["Id"].Visible = false;
            Articles_datagridview.Columns["BuyingPrice"].Visible = false;
            Articles_datagridview.Columns["DateCreation"].Visible = false;
            Articles_datagridview.Columns["DateModification"].Visible = false;
            Articles_datagridview.Columns["Ordre"].Visible = false;
            Articles_datagridview.Columns["articleCategory"].Visible = false;
            Articles_datagridview.Columns["Quantity"].Visible = false;
            //Add Checkbox column in the  datagridview
            DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
            Articles_datagridview.Columns.Insert(0, check);
            //Add TextBox Column in the datagridview
            DataGridViewTextBoxColumn qteTextBox = new DataGridViewTextBoxColumn();
            Articles_datagridview.Columns.Insert(5, qteTextBox);
            qteTextBox.Name = "quantity Article !";
            //Enable writing in the datagridview columns
            Articles_datagridview.Columns["SellingPrice"].ReadOnly = true;
            Articles_datagridview.Columns["Reference"].ReadOnly = true;
            Articles_datagridview.Columns["Name"].ReadOnly = true;
        }
        private void CustomerName_rdb_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Name");
            //After Choosing the combo 's RadioButton : 
            //Clean the Id Label customer
            CustomerNumber_Label.Text = "---";
            //Filing the customer Combo 
            Customer_Combo.Enabled = true;
            Customer_Combo.DataSource = null;
            Customer_Combo.DataSource = new Customers().ListCustomers();
            Customer_Combo.DisplayMember = "LastName";
            Customer_Combo.ValueMember = "Id";
        }

        private void CustomerId_rdb_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Id");
            //Clean the Customer combo
            Customer_Combo.DataSource = null;
            Customer_Combo.Enabled = false;
            //Filling the Id Lable Customer with :
            CustomerNumber_Label.Text = (db.Customers.Count() + 1).ToString();
        }


        private void CategoriesArticle_ListBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        

        private void Ref_Article_TextBox_TextChanged(object sender, EventArgs e)
        {
            Articles_datagridview.DataSource = null;
            Articles_datagridview.DataSource = new Articles().Filtrer(Ref_Article_TextBox.Text);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Articles_datagridview.DataSource = null;
            Articles_datagridview.DataSource = new Articles().Filtrer(Ref_Article_TextBox.Text);

        }

        

        private void CategoriesArticle_ListBox_DoubleClick(object sender, EventArgs e)
        {
            Articles_datagridview.DataSource = null;
            Articles_datagridview.DataSource = new Articles().SearchByCateory(Convert.ToInt32(CategoriesArticle_ListBox.SelectedValue));
        }
    }
}
