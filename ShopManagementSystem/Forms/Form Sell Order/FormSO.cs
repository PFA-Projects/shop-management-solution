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

namespace ShopManagement.Test
{
    public partial class FormSO : Form
    {
        //Database ModelContext
        ModelContext db = new ModelContext();
        //Operation Type (Buy || Order)
        string OperationType = "";
        //Customer Type (Object ||Id)
        string CustomerType = "";

        public FormSO()
        {
            InitializeComponent();
           
            //Starting The Gwin First !
            // Application User
            User user = new User();
            user.Language = GwinApp.Languages.en;

            // Start Gwin Application
            FormMenuApplication f = new FormMenuApplication();
            GwinApp.Start(typeof(ModelContext), typeof(BaseBLO<>), f, user);


            //Customer Type is disabled before completing the operation type part
            Customer_groupbox.Enabled = false;
            //OrderDate is disabled before completing the customer type part
            OrderDate_groupebox.Enabled = false;

            btn_cancel.Enabled = true;
            Operations.Enabled = false;

            OperationType_Combobox.SelectedItem = "";
            DeliveryDate_dtp.Visible = false;

            Articles_datagridview.AutoGenerateColumns = false;
            Result_grpbox.Enabled = false;
        }

        private void OperationType_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OperationType = OperationType_Combobox.SelectedItem.ToString();
            MessageBox.Show(OperationType);
            OperationType_groupbox.Enabled = false;
            Customer_groupbox.Enabled = true;
        }
        Customer customer = new Customer();
        private void ObjectCustomer_rdb_CheckedChanged(object sender, EventArgs e)
        {
            CustomerType = "Object";
            ObjectCustomer_combo.DataSource = null;
            ObjectCustomer_combo.DataSource = new CustomersBLO(db).GetAll();

            idCustomer_label.Text = "";
        }
        DateTime orderdate = DateTime.Now;
        private void ObjectCustomer_combo_SelectedValueChanged(object sender, EventArgs e)
        {
            customer = (Customer)ObjectCustomer_combo.SelectedItem;
            if (OperationType == "Order" && CustomerType == "Object")
            {
                DeliveryDate_dtp.Visible = true;
            }

            if (OperationType == "Order")
            {
                OrderDate_groupebox.Enabled = true;
                MessageBox.Show(" delivery order Date !!");
            }
            if (OperationType == "Buy")
            {
                OrderDate_groupebox.Enabled = false;
            }


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
                OperationType_groupbox.Enabled = true;
                orderdate = DateTime.Now;
                OrderDate_groupebox.Enabled = false;
                ObjectCustomer_combo.DataSource = null;
                Customer_groupbox.Enabled = false;
                CustomerType = "";
                OperationType = "";
                ObjectCustomer_rdb.Checked = false;
                IdCustomer_rdb.Checked = false;
           

        }
        DateTime deliverydate = DateTime.Now;
        CustomerOrder co = new CustomerOrder();
        CustomerDelivery cd = new CustomerDelivery();
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            btn_cancel.Enabled = false;

            if (OperationType == "Buy" && CustomerType == "Object")
            {
                co.customer = customer;
                co.OrderDate = orderdate;
            }
            if (OperationType == "Buy" && CustomerType == "Id")
            {
                co.customer = null;
                co.OrderDate = orderdate;
            }
            if (OperationType == "Order" && CustomerType == "Object")
            {
                co.customer = customer;
                co.OrderDate = orderdate;
                deliverydate = deliverydatep.Value;
                cd.DeliveryDate = deliverydate;
                DeliveryDate_dtp.Enabled = false;
                new CustomerDeliveryBLO(db).Save(cd);
            }
            OperationType_groupbox.Enabled = false;
            Customer_groupbox.Enabled = false;
            OrderDate_groupebox.Enabled = false;

            Operations.Enabled = true;
            new CustomerOrdersBLO(db).Save(co);
            ArticlesCategory_listbox.DataSource = null;
            ArticlesCategory_listbox.DataSource = new ArticlesCategoryBLO(db).GetAll();

            Articles_datagridview.DataSource = null;
            Articles_datagridview.DataSource = new ArticlesBLO(db).GetAll();
        }
        private void IdCustomer_rdb_CheckedChanged(object sender, EventArgs e)
        {
            ObjectCustomer_combo.DataSource = null;
            ObjectCustomer_groupebox.Enabled = false;
            idCustomer_label.Text = (new CustomerOrdersBLO(db).Count() + 1).ToString();
            OrderDate_groupebox.Enabled = false;
            orderdate = DateTime.Now;
        }

        private void deliverydatep_ValueChanged(object sender, EventArgs e)
        {
            deliverydate = deliverydate = deliverydatep.Value;
            if (deliverydate <= orderdate)
            {
                MessageBox.Show("Delivery date must be superior then the orderdate !!!!");
            }
        }

        private void ArticlesCategory_listbox_Click(object sender, EventArgs e)
        {
            Articles_datagridview.DataSource = null;
            Articles_datagridview.DataSource = new ArticlesBLO(db).SearchByCateory((ArticleCategory)ArticlesCategory_listbox.SelectedItem);
           
        }

        private void Reference_textbox_TextChanged(object sender, EventArgs e)
        {
            Articles_datagridview.DataSource = null;

            Dictionary<string, object> Criteria = new Dictionary<string, object>();
            Criteria.Add(nameof(Article.Reference), Reference_textbox.Text);
            Articles_datagridview.DataSource = new ArticlesBLO(db).Recherche(Criteria);
        }
        List<Article> listeArticles = new List<Article>();
        Article article = new Article();
        
        private void Articles_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //We make DataGridCheckBoxColumn commit changes with single click
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                this.Articles_datagridview.CommitEdit(DataGridViewDataErrorContexts.Commit);

            if ((bool)this.Articles_datagridview.CurrentCell.Value == true)
            {
                CustomerOrderLine col = new CustomerOrderLine();
                MessageBox.Show("Selected !");
                article = new ArticlesBLO(db).GetByID(Convert.ToInt32(Articles_datagridview.CurrentRow.Cells[1].Value));
                if (listeArticles.Contains(article))
                {
                    MessageBox.Show("Already selected");
                    Articles_datagridview.DataSource = null;
                    Articles_datagridview.DataSource = new ArticlesBLO(db).GetAll();
                }
                else
                {

                if (Articles_datagridview.CurrentRow.Cells[5].Value == null)
                {
                    MessageBox.Show("Try to fill the quantity Before adding the article to the customer's liste");
                    Articles_datagridview.DataSource = null;
                    Articles_datagridview.DataSource = new ArticlesBLO(db).GetAll();
                }
                else
                {
                    article = new ArticlesBLO(db).GetByID(Convert.ToInt32(Articles_datagridview.CurrentRow.Cells[1].Value));
                    
                    string q = Articles_datagridview.CurrentRow.Cells[5].Value.ToString();
                    float quantity = float.Parse(q);
                    if (article.Quantity < quantity)
                    {
                        MessageBox.Show("Please , Try To choose a quantity less than : " + article.Quantity);
                        Articles_datagridview.DataSource = null;
                        Articles_datagridview.DataSource = new ArticlesBLO(db).GetAll();
                    }
                    else
                    {
                        col.Quantity = quantity;
                        col.customerOrder = co;
                        new CustomerOrderLineBLO(db).Save(col);
                        ListeArticles_selected_listbox.DataSource = null;
                        ListeArticles_selected_listbox.DataSource = listeArticles;
                        article.customerorderline = col;
                        listeArticles.Add(article);
                        ListeArticles_selected_listbox.DataSource = null;
                        ListeArticles_selected_listbox.DataSource = listeArticles;
                            article.Quantity--;
                    }
                }
            }

          }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ArticlesCategory_listbox_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void ListeArticles_selected_listbox_Click(object sender, EventArgs e)
        {
            Article article = new Article();
            article = (Article)ListeArticles_selected_listbox.SelectedItem;

            ////CustomerOrderLine col = new CustomerOrderLine();
            ////int idcol = Convert.ToInt32(article.customerorderline);
            ////MessageBox.Show(idcol.ToString());
            //col = new CustomerOrderLineBLO(db).GetByID(idcol);
            //new CustomerOrderLineBLO(db).Delete(col);
            //ListeArticles_selected_listbox.DataSource = null;
            //ListeArticles_selected_listbox.DataSource = listeArticles;

        }

        private void btn_pass_Click(object sender, EventArgs e)
        {
            Articles_count_textbox.Enabled = false;
            Articles_count_textbox.Text = (listeArticles.Count).ToString();
            Total_price_textbox.Enabled = false;
            float TotalPrice = 0;
            foreach (var item in listeArticles)
            {
                float SellingPrice = item.SellingPrice;
                float quantity = item.customerorderline.Quantity;
                TotalPrice += SellingPrice * quantity;
            }
            Total_price_textbox.Text = TotalPrice.ToString();
        }

        private void ListeArticles_selected_listbox_SelectedValueChanged(object sender, EventArgs e)
        {
            //Article article = new Article();
            //article = (Article)ListeArticles_selected_listbox.SelectedItem;
            //listeArticles.Remove(article);
            //int idCustomerOrderLine = (int)article.customerorderline.Id;
            //CustomerOrderLine col = new CustomerOrderLineBLO(db).GetByID(idCustomerOrderLine);
            //new CustomerOrderLineBLO(db).Delete(col);
            //Articles_datagridview.DataSource = null;
            //Articles_datagridview.DataSource = new ArticlesBLO(db).GetAll();
        }
    }
}
