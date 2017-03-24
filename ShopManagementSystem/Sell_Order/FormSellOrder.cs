//Mariam Ait Al
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

namespace ShopManagement.Sell_Order
{
    public partial class FormSellOrder : Form
    {
        //Create a ModelContext Instance
        ModelContext db = new ModelContext();

        // create an Operation Type (Order/Buy)
        string OperationType = "";
        // Create a Customer Type (Object / id)
        string CustomerType = "";
        //Instance a customer object
        Customer customer = new Customer();
        //Instance CustomerOrder
        CustomerOrder co = new CustomerOrder();
        //Instance CustomerOrderLine
        CustomerOrderLine col = new CustomerOrderLine();


        public FormSellOrder()
        {
            InitializeComponent();
            //Starting The Gwin First !
            // Application User
            User user = new User();
            user.Language = GwinApp.Languages.en;

            // Start Gwin Application
            FormMenuApplication f = new FormMenuApplication();
            GwinApp.Start(typeof(ModelContext), typeof(BaseBLO<>), f, user);

            //customer groupbox disable 
            CustomerGroupBox.Enabled = false;

            //The customer combo and id are disabled before choosing a radiobutton
            Customername_combo.Enabled = false;
            idcustomer_grpbox.Enabled = false;

            //Test Rdb
            Test_rdb.Checked = true;
            Test_rdb.Visible = false;

            //disabled operations tablayout
            Operations.Enabled = false;

            //orderdate groupbox not visible before choosing the customer type
            orderdate_grpbox.Visible = false;

            //Filing the ArticleCategories listbox
            ArticleCategories_ListBox.DataSource = null;
            ArticleCategories_ListBox.DataSource = new ArticlesCategoryBLO(db).GetAll();

            //Disactivate the datagridview autogeneratecolumns
            Articles_DataGridView.AutoGenerateColumns = false;

            Details_grpbox.Enabled = false;
            //tab_btncancel.Enabled = true;
        }
        // event typecombo selected item 
        private void Typecombo_SelectedValueChanged_1(object sender, EventArgs e)
        {
            //Define the value selected
            OperationType = (Typecombo.SelectedItem).ToString();
            //disabled the operation type groupebox
            MessageBox.Show("your Operation is  : " + OperationType);
            OperationType_grpbox.Enabled = false;
            CustomerGroupBox.Enabled = true;
        }

        private void CustomerObject_rdb_CheckedChanged_1(object sender, EventArgs e)
        {
            //enabled objectCustomer combo
            Customername_combo.Enabled = true;
            CustomerType = "Object";
            //Filing the namecustomer combo
            Customername_combo.DataSource = null;
            Customername_combo.DataSource = new CustomersBLO(db).GetAll();
            //Orderdate groupe box is visible after choosing the object type client
            orderdate_grpbox.Visible = true;
        }

        private void Customername_combo_SelectedValueChanged_1(object sender, EventArgs e)
        {
            //define the selected customer
            customer = (Customer)Customername_combo.SelectedItem;
            
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if(CustomerObject_rdb.Checked == true)
            {
                CustomerType = "Object";
                customer = (Customer)Customername_combo.SelectedItem;
            }
            if(idCustomer_rdb.Checked == true)
            {
                CustomerType = "id";
            }
        }
        //OrderDate
        DateTime orderDate = DateTime.Now;
        private void orderdate_datetp_ValueChanged(object sender, EventArgs e)
        {
            //Create a Customer Order 
            orderDate = orderdate_datetp.Value;
            co.OrderDate = orderDate;
            co.customer = customer;
            //insert the customer order
            new CustomerOrdersBLO(db).Save(co);
            //close the customertype selection and enabled the operations
            orderdate_grpbox.Enabled = false;
            CustomerGroupBox.Enabled = false;
            Operations.Enabled = true;
            //Filing the articles datagridview
            Articles_DataGridView.DataSource = null;
            Articles_DataGridView.DataSource = new ArticlesBLO(db).GetAll();
        }

        private void Reference_TextBox_TextChanged(object sender, EventArgs e)
        {
            Articles_DataGridView.DataSource = null;

            Dictionary<string, object> Criteria = new Dictionary<string, object>();
            Criteria.Add(nameof(Article.Reference), Reference_TextBox.Text);
            Articles_DataGridView.DataSource = new ArticlesBLO(db).Recherche(Criteria);
        }

        private void Articles_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ArticleCategories_ListBox_Click(object sender, EventArgs e)
        {
            Articles_DataGridView.DataSource = null;
            Articles_DataGridView.DataSource = new ArticlesBLO(db).SearchByCateory((ArticleCategory)ArticleCategories_ListBox.SelectedItem);
        }
        List<Article> listeArticles = new List<Article>();
        private void Articles_DataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //We make DataGridCheckBoxColumn commit changes with single click
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                this.Articles_DataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            if ((bool)this.Articles_DataGridView.CurrentCell.Value == true)
            {
                Article article = new Article();
                article = new ArticlesBLO(db).GetByID(Convert.ToInt32(Articles_DataGridView.CurrentRow.Cells[1].Value));
                //Insert the customer in table customerorderline
                col.customerOrder = co;
                //Test if the item is in the list or not
                if (listeArticles.Contains(article))
                {
                    MessageBox.Show("This article is already in the list");
                }
                else
                {
                    //Test filing quantity textbox in dgv
                    if (Articles_DataGridView.CurrentRow.Cells[5].Value == null)
                    {
                        MessageBox.Show("Try to fill the quantity Before adding the article to the customer's liste");
                        Articles_DataGridView.CurrentRow.Cells["Selected"].Value = false;
                    }
                    else
                    {
                        article = new ArticlesBLO(db).GetByID(Convert.ToInt32(Articles_DataGridView.CurrentRow.Cells[1].Value));
                        string q = Articles_DataGridView.CurrentRow.Cells[5].Value.ToString();
                        float quantity = float.Parse(q);
                        //Test between the customer's quantity and the article 's quantity in the stock
                        if(article.Quantity < quantity)
                        {
                            MessageBox.Show("Please , Try To choose a quantity less than : " + article.Quantity);
                            Articles_DataGridView.CurrentRow.Cells["Quantity"].Value = "";
                            Articles_DataGridView.CurrentRow.Cells["Selected"].Value = false;
                        }
                        else
                        {
                            col.Quantity = quantity;
                            new CustomerOrderLineBLO(db).Save(col);
                            article.customerorderline = col;
                            new ArticlesBLO(db).Save(article);
                            listeArticles.Add(article);
                        }
                        
                    }
                }
                SelectedArticles_Listbox.DataSource = null;
                SelectedArticles_Listbox.DataSource = listeArticles;
                SelectedArticles_Listbox.DisplayMember = "Reference";
                SelectedArticles_Listbox.ValueMember = "Id";
            }
            Articles_DataGridView.DataSource = null;
            Articles_DataGridView.DataSource = new ArticlesBLO(db).GetAll().Except(listeArticles);
        }

        private void SelectedArticles_Listbox_Click(object sender, EventArgs e)
        {
            int idArticle = Convert.ToInt32(SelectedArticles_Listbox.SelectedValue);
            Article article = new ArticlesBLO(db).GetByID(idArticle);
            listeArticles.Remove(article);
            new CustomerOrderLineBLO(db).Delete(col.Id);
            SelectedArticles_Listbox.DataSource = null;
            SelectedArticles_Listbox.DataSource = listeArticles;
            SelectedArticles_Listbox.DisplayMember = "Reference";
            SelectedArticles_Listbox.ValueMember = "Id";
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            Details_grpbox.Enabled = false;
        }

        //listeArticles = null;
        //    Articles_DataGridView.DataSource = null;
        //    Operations.Enabled = false;
        //    Test_rdb.Checked = true;
        //    Test_rdb.Visible = false;
        //    orderdate_datetp.Visible = false;
        //    CustomerGroupBox.Enabled = false;
        //    CustomerType = "";
        //    OperationType = "";
    }
}
