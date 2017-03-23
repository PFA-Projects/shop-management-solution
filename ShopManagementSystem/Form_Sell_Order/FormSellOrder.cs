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

namespace ShopManagement.Form_Sell_Order
{
    public partial class FormSellOrder : Form
    {
        //Model Context 's Instance
        ModelContext db = new ModelContext();
        public FormSellOrder()
        {
            InitializeComponent();
        }
        //Variables and instanciations
        string CustomerEtat = "";


        private void FormSellOrder_Load(object sender, EventArgs e)
        {
            //App Gwin Must be Executed First 
            // Application User
            User user = new User();
            user.Language = GwinApp.Languages.fr;

            // Start Gwin Application
            FormMenuApplication f = new FormMenuApplication();
            GwinApp.Start(typeof(ModelContext), typeof(BaseBLO<>), f, user);


            //Filing ArticlesCategoryListBox with the ArticlesCategory Liste
            ArticlesCategoryListBox.DataSource = null;
            ArticlesCategoryListBox.DataSource = new ArticlesCategoryBLO(db).GetAll();

            //Filing Clientscombo with the Customers Liste
            CustomerssCombo.DataSource = null;
            CustomerssCombo.DataSource = new CustomersBLO(db).GetAll();
            CustomerssCombo.DisplayMember = "LastName";
            CustomerssCombo.ValueMember = "Id";

            //Disabled CustomersCombo and CustomerLabel Befor Choosing a Type with RadioButton !
            CustomerssCombo.Enabled = false;
            CustomerLabel.Text = "0";
            CustomerLabel.Enabled = false;
            //turn off the datagridview autogenerate columns
            ArticlesDataGridView.AutoGenerateColumns = false;
            //Filing ArticlesDateGridView with Articles List
            ArticlesDataGridView.DataSource = null;
            ArticlesDataGridView.DataSource = new ArticlesBLO(db).GetAll();
            //Disabled part result_groupbox
            result_groupbox.Enabled = false;
            //initialise liste articles selected (ListBox)
            ArticlesListSelected.DataSource = null;
        }

        //The CustomerClient 's Radio Button Click event
        private void NameClientRadioButton_Click(object sender, EventArgs e)
        {
            CustomerssCombo.Enabled = true;
            CustomerLabel.Text = "------";
            CustomerLabel.Enabled = false;
            CustomerEtat = "Object";
            
        }

        private void IdClientRadioButton_Click(object sender, EventArgs e)
        {
            CustomerssCombo.Enabled = false;
            CustomerLabel.Enabled = true;
            //The next Customer id value
            CustomerLabel.Text = (db.Customers.Count() + 1).ToString();
            CustomerEtat = "Id";
        }

        //ArticlesCategoryListBox event click 
        private void ArticlesCategoryListBox_Click(object sender, EventArgs e)
        {
            //Filing ArticlesDataGridView with the Articles of the categoryarticles selected in the ArticlesCategoryListBox
            ArticlesDataGridView.DataSource = null;
            ArticlesDataGridView.DataSource = new ArticlesBLO(db).SearchByCateory((ArticleCategory)ArticlesCategoryListBox.SelectedItem);
        }

        //Filtring ArticlesDataGridView with search Articles By Reference / TextChanged Evenement
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ArticlesDataGridView.DataSource = null;

            Dictionary<string, object> Criteria = new Dictionary<string, object>();
            Criteria.Add(nameof(Article.Reference), RefArticleTextBox.Text);
            ArticlesDataGridView.DataSource = new ArticlesBLO(db).Recherche(Criteria);
        }
        //disabled the ArticlesDataGridView and enabled the part result_groupbox
        private void btn_pass_Click(object sender, EventArgs e)
        {
            ArticlesDataGridView.Enabled = false;
            result_groupbox.Enabled = true;
        }

        private void ArticlesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ////We make DataGridCheckBoxColumn commit changes with single click
            //if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            //    this.ArticlesDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);

            ////Check the value of cell
            //if ((bool)this.ArticlesDataGridView.CurrentCell.Value == true)
            //{
            //    //Checked = true
            //    //MessageBox.Show("Checked : " + ArticlesDataGridView.Rows[e.RowIndex].Cells[0].Value);


            //}
            //else
            //{
            //    //Unchecked = False
            //   // MessageBox.Show("Checked : " + ArticlesDataGridView.Rows[e.RowIndex].Cells[0].Value);
            //    //ArticlesDataGridView.CurrentRow.Cells[1].Value


            //}

            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                MessageBox.Show("Count Before : " + new CustomerOrdersBLO(db).Count().ToString());
              //  MessageBox.Show("Id :" + ArticlesDataGridView.CurrentRow.Cells[0].Value);
                Article article = new ArticlesBLO(db).GetByID(Convert.ToInt32(ArticlesDataGridView.CurrentRow.Cells[0].Value));
                if(CustomerEtat == "Object")
                {
                    //MessageBox.Show("Id : " + CustomerssCombo.SelectedValue);
                    Customer customer = new CustomersBLO(db).GetByID(Convert.ToInt32(CustomerssCombo.SelectedValue));
                    CustomerOrder co = new CustomerOrder();
                    co.customer = customer;
                    co.OrderDate = DateTime.Now;
                    new CustomerOrdersBLO(db).Save(co);
                    MessageBox.Show("Count After : " + new CustomerOrdersBLO(db).Count().ToString());
                }
            }


        }

        private void ArticlesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
