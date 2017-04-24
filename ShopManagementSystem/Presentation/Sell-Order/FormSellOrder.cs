// Nom : Mariam Ait al
// Groupe : TDI204
//Annee : 2017

using App;
using App.Gwin;
using App.Gwin.Entities.Secrurity.Authentication;
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

namespace ShopManagement.Presentation.Sell_Order
{
    public partial class FormSellOrder : Form
    {
        //ModelContext Instantiate
        ModelContext db = new ModelContext();
        public FormSellOrder()
        {
            InitializeComponent();
        }

        private void FormSellOrder_Load(object sender, EventArgs e)
        {
            //
            //Filling the combo with 2 values (Order || Sell) => OrderState : CustomerOrder (class)
            //

            op_type_combo.DataSource = null;
            op_type_combo.Items.Add("Order");
            op_type_combo.Items.Add("Sell");

            //disable the  customer type operation
            customer_grpx.Enabled = false;
            //disable the delivery date operation
            deliverydate_grpx.Enabled = false;
            //disable the listbox article category listbox
            articles_cat_lb.Enabled = false;
            //disable the articles datagridview
            articles_dgv.Enabled = false;
            //disable the datagridview autogenerationcolumns
            articles_dgv.AutoGenerateColumns = false;
            //disable the search by reference textbox
            search_grpx.Enabled = false;
        }

        //Define the operationType selected
        string OperationType = "";
        private void op_type_combo_SelectedValueChanged(object sender, EventArgs e)
        {
            OperationType = op_type_combo.SelectedItem.ToString();
            customer_grpx.Enabled = true;
            //in Operation type = "order" case we allows to define the delivery date expected operation
            if (OperationType == "Order")
            {
                deliverydate_grpx.Enabled = true;
            }
        }
        //
        //define the customertype
        string CustomerType = "";
        // Object Customer type
        //means that the customer is selected in the Model Context customers !
        private void Object_rdb_CheckedChanged(object sender, EventArgs e)
        {
            CustomerType = "Object";
            customer_combo.DataSource = null;
            customer_combo.DataSource = new CustomersBLO(db).GetAll();
            idcustomer_label.Text = "";
            customer_combo.Enabled = true;
        }
        //Id Customer type
        //means that the customer is not selected
        private void id_rdb_CheckedChanged(object sender, EventArgs e)
        {
            CustomerType = "Id";
            customer_combo.DataSource = null;
            customer_combo.Enabled = false;
            idcustomer_label.Text = (new CustomerOrdersBLO(db).Count() + 1).ToString();
        }

        //Define the delivery date expected in case of order s operation type
        DateTime DeliveryDateExpected = DateTime.Now;
        private void deliverydateexpected_dtp_ValueChanged(object sender, EventArgs e)
        {
            if (OperationType == "Order")
            {
                DeliveryDateExpected = deliverydateexpected_dtp.Value;
            }
        }
        //
        // define the  customer order object
        CustomerOrder co = new CustomerOrder();
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            // confirm about information selected before procede to the second part
            string Message = "Are You sure About this informations ? \n\t Operation Type : " + OperationType
                + "\n\t Customer Type : " + CustomerType + "\n\t Delivery Date Expected : " + DeliveryDateExpected;
            if (MessageBox.Show(Message, "Confirmation Messag", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // save the customer order informations selected
                co.Name = OperationType + co.Id + customer.LastName + " " + customer.FirstName;
                if (OperationType == "Sell")
                {
                    co.OrderDate = DateTime.Now;
                }
                if (OperationType == "Order")
                {
                    co.DeliveryDateExpected = DeliveryDateExpected;
                }
                if (customer != null && CustomerType == "Object")
                {
                    co.customer = customer;
                }
                co.OrderState = OperationType;
                new CustomerOrdersBLO(db).Save(co);
                //disable the confirm button 
                btn_confirm.Enabled = false;
                //disable the delivery date expected date time picker
                deliverydate_grpx.Enabled = false;
                //disable the operation type combo
                op_type_grpx.Enabled = false;
                // disable the customer type operation
                id_rdb.Enabled = false;
                Object_rdb.Enabled = false;
                customer_combo.Enabled = false;
                //enable the articles category selected listbox
                //Fill it with the items
                articles_cat_lb.Enabled = true;
                articles_cat_lb.DataSource = null;
                articles_cat_lb.DataSource = new ArticlesCategoryBLO(db).GetAll();
                //
                // Enable the articles datagridview 
                //fill it with the articles items
                articles_dgv.Enabled = true;
                articles_dgv.DataSource = new ArticlesBLO(db).GetAll();
                //
                //enable the search by reference textbox (Filter)
                search_grpx.Enabled = true;
            }
        }
        //
        //define the customer selected in case of customer type = "object"
        Customer customer = new Customer();
        private void customer_combo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CustomerType == "Object")
            {
                customer = (Customer)customer_combo.SelectedItem;
            }
        }
        //
        // define the category article selected in the listbox
        //filling the articles datagridview by this category article
        /// <summary>
        /// 
        /// </summary>
        private void articles_cat_lb_SelectedValueChanged(object sender, EventArgs e)
        {
            articles_dgv.DataSource = null;
            articles_dgv.DataSource = new ArticlesBLO(db).SearchByCateory((ArticleCategory)articles_cat_lb.SelectedItem);
        }
        //
        // Filter the articles datagridview with the search textbox value
        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            articles_dgv.DataSource = null;

            Dictionary<string, object> Criteria = new Dictionary<string, object>();
            Criteria.Add(nameof(Article.Reference), search_tb.Text);
            articles_dgv.DataSource = new ArticlesBLO(db).Recherche(Criteria);
        }
        // define a virtual Articles List checked in the datagridview
        List<Article> SelectedArticles = new List<Article>();
        //
        // define the articles selected TotalPrice 
        float TotalPrice = 0;
        // define the datagridview 's article selected 
        //
        private void articles_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //We make DataGridCheckBoxColumn commit changes with single click
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                this.articles_dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            if ((bool)this.articles_dgv.CurrentCell.Value == true)
            {
                // in case of the required quantity is empty we inform the 
                //user to Fill this information before check any item
                if (articles_dgv.CurrentRow.Cells[1].Value == null)
                {
                    MessageBox.Show("You Must Fill the Required Quantity Before selecting Any Article ! ");
                    articles_dgv.DataSource = null;
                    articles_dgv.DataSource = new ArticlesBLO(db).GetAll();
                }
                else
                {
                    //
                    // Get the required quantity value 
                    string Rqte = articles_dgv.CurrentRow.Cells[1].Value.ToString();
                    float RequieredQuantity = float.Parse(Rqte);
                    // Get the Article selected s quantity
                    string qtestock = articles_dgv.CurrentRow.Cells[4].Value.ToString();
                    float QuantityInStock = float.Parse(qtestock);
                    // compare between the quantity in stock and the quantity filled by the user
                    // in case of the Rrequired quantity > quantity in stock
                    // we inform the user to  check the article and fill again the required quantity
                    // with a quantity less then the quantity ins stock
                    if (RequieredQuantity > QuantityInStock)
                    {
                        MessageBox.Show("The Required Quantity must be less than : " + QuantityInStock);
                        articles_dgv.DataSource = null;
                        articles_dgv.DataSource = new ArticlesBLO(db).GetAll();
                    }
                    //
                    else
                    {
                        // test if the article is already in the virtual sell articles list or not
                        // in case of the article selected is in the already selected
                        // we inform the user to select another article !
                        if(SelectedArticles.Contains(new ArticlesBLO(db).GetByID(Convert.ToInt32(articles_dgv.CurrentRow.Cells[2].Value))))
                        {
                            MessageBox.Show("This Article is already in the list !");
                            articles_dgv.DataSource = null;
                            articles_dgv.DataSource = new ArticlesBLO(db).GetAll();
                        }
                        else
                        {
                            // define the customer order line and save the changes
                            
                            CustomerOrderLine col = new CustomerOrderLine();
                            col.Quantity = RequieredQuantity;
                            col.customerOrder = co;
                            col.article = new ArticlesBLO(db).GetByID(Convert.ToInt32(articles_dgv.CurrentRow.Cells[2].Value));
                            new CustomerOrderLineBLO(db).Save(col);
                            if (co.OrderState == "Sell")
                            {
                                // rduce the article s quantity in stock in state of the article is in state of sell
                                Article article = new ArticlesBLO(db).GetByID(Convert.ToInt32(articles_dgv.CurrentRow.Cells[2].Value));
                                MessageBox.Show("Quantity Before : " + article.Quantity);
                                article.Quantity = article.Quantity - RequieredQuantity;
                                MessageBox.Show("Quantity After : " + article.Quantity);
                                new ArticlesBLO(db).Save(article);
                            }
                            SelectedArticles.Add(new ArticlesBLO(db).GetByID(Convert.ToInt32(articles_dgv.CurrentRow.Cells[2].Value)));
                            MessageBox.Show("Article : " + col.article.Reference + "\nQuantity : " + col.Quantity);
                            // filled again the datagridview
                            articles_dgv.DataSource = null;
                            articles_dgv.DataSource = new ArticlesBLO(db).GetAll();

                            // compute the  selected articles count
                            articles_count_tb.Text = SelectedArticles.Count().ToString();
                            //compute the articles selected total price
                            TotalPrice = TotalPrice + (col.Quantity * col.article.SellingPrice);
                            totalPrice_tb.Text = TotalPrice.ToString();
                        }

                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SelectedArticles.Count.ToString());
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            string Message = "Do You really want To start another Operation ?";
            if (MessageBox.Show(Message, "Confirmation Messag", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Visible = false;
                FormSellOrder f = new FormSellOrder();
                f.Show();
            }
        }
    }
}
