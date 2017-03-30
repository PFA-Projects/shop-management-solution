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
        //Define the provider
        Provider provider = new Provider();
        //Define the provider order
        ProviderOrder providerOrder = new ProviderOrder();
        public FormBuyOrder()
        {
            InitializeComponent();
        }

        private void FormBuyOrder_Load(object sender, EventArgs e)
        {
            //Starting The Gwin First !
            // Application User
            User user = new User();
            user.Language = GwinApp.Languages.en;

            // Start Gwin Application
            FormMenuApplication f = new FormMenuApplication();
            GwinApp.Start(typeof(ModelContext), typeof(BaseBLO<>), f, user);

            //Filling the operation Type Combo with (Order || Buy)
            OpType_combo.DataSource = null;
            OpType_combo.Items.Add("Buy");
            OpType_combo.Items.Add("Order");
            //Disabled the delivery date expected before choosing the operation s type
            Deliveryde_grpx.Enabled = false;
            //Filling the provider combobox with the provider s list
            provider_combo.DataSource = null;
            provider_combo.DataSource = new ProviderBLO(db).GetAll();
            //Disabled Articles Category listbox before pass
            Articles_Category_grpbx.Enabled = false;
            //Filling the articles Category listbox
            Articles_c_listbx.DataSource = null;
            Articles_c_listbx.DataSource = new ArticlesCategoryBLO(db).GetAll();
            //
            Articles_dgv.Enabled = false;
            Articles_c_listbx.Enabled = false;
            Articles_dgv.DataSource = null;
            Articles_dgv.DataSource = new ArticlesBLO(db).GetAll();
            Reference_textbox.Enabled = false;
            Articles_dgv.AutoGenerateColumns = false;

            result_grpbx.Enabled = false;
        }

        //Define the operation 's type
        string operationType = "";
        private void OpType_combo_SelectedValueChanged(object sender, EventArgs e)
        {
            operationType = OpType_combo.SelectedItem.ToString();
            MessageBox.Show("The Operation Selected is : " + operationType);
            if (operationType == "Order")
            {
                Deliveryde_grpx.Enabled = true;
                providerOrder.OrderState = "Order";

            }
            if (operationType == "Buy")
            {
                providerOrder.OrderState = "Buy";
                providerOrder.orderDate = DateTime.Now;
            }
            providerOrder.Name = "Order N : " + providerOrder.Id;
        }
        //Define the selected provider
        private void provider_combo_SelectedValueChanged(object sender, EventArgs e)
        {
            provider = (Provider)provider_combo.SelectedItem;
        }
        //Define the delivery date expected if the operation type is an order
        DateTime DeliveryDateExpected = DateTime.Now;
        private void dde_dtp_ValueChanged(object sender, EventArgs e)
        {
            DeliveryDateExpected = dde_dtp.Value;
            providerOrder.DeliveryDateExpected = DeliveryDateExpected;
        }

        private void btn_pass_Click(object sender, EventArgs e)
        {
            provider_combo.Enabled = false;
            OpType_combo.Enabled = false;
            dde_dtp.Enabled = false;
            new ProviderOrderBLO(db).Save(providerOrder);
            Articles_Category_grpbx.Enabled = true;
            Articles_dgv.Enabled = true;
            Reference_textbox.Enabled = true;
            Articles_c_listbx.Enabled = true;
        }
        //Filling the articles datagrdview by the articles Category selected
        private void Articles_c_listbx_SelectedValueChanged(object sender, EventArgs e)
        {
            Articles_dgv.DataSource = null;
            Articles_dgv.DataSource = new ArticlesBLO(db).SearchByCateory((ArticleCategory)Articles_c_listbx.SelectedItem);
        }

        //Filter the datagridview by the refrence textbox (search)
        private void Reference_textbox_TextChanged(object sender, EventArgs e)
        {
            Articles_dgv.DataSource = null;

            Dictionary<string, object> Criteria = new Dictionary<string, object>();
            Criteria.Add(nameof(Article.Reference), Reference_textbox.Text);
            Articles_dgv.DataSource = new ArticlesBLO(db).Recherche(Criteria);
        }

        //
        List<Article> ArticlesList = new List<Article>();
        private void Articles_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //We make DataGridCheckBoxColumn commit changes with single click
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                this.Articles_dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            if ((bool)this.Articles_dgv.CurrentCell.Value == true)
            {
                Article article = new Article();
                article = new ArticlesBLO(db).GetByID(Convert.ToInt32(Articles_dgv.CurrentRow.Cells[1].Value));
                if (Articles_dgv.CurrentRow.Cells[2].Value == null)
                {
                    MessageBox.Show("Fill The Required Quantity Before selecting the articles !");
                    Articles_dgv.DataSource = null;
                    Articles_dgv.DataSource = new ArticlesBLO(db).GetAll();
                }else
                {
                    if (ArticlesList.Contains(article))
                    {
                        MessageBox.Show("This Article is already in the liste ! ");
                        Articles_dgv.DataSource = null;
                        Articles_dgv.DataSource = new ArticlesBLO(db).GetAll();
                    }
                    else
                    {
                        ProviderOrderLine pol = new ProviderOrderLine();
                        pol.Quantity = float.Parse(Articles_dgv.CurrentRow.Cells[5].Value.ToString());
                        pol.providerOrder = providerOrder;
                        pol.article = article;
                        new ProviderOrderLineBLO(db).Save(pol);
                        ArticlesList.Add(article);
                        Articles_dgv.DataSource = null;
                        Articles_dgv.DataSource = new ArticlesBLO(db).GetAll();
                        Articles_c_listbx.DataSource = null;
                        Articles_c_listbx.DataSource = ArticlesList;
                    }
                }
            }
        }

        private void articles_selected_lb_SelectedValueChanged(object sender, EventArgs e)
        {
            string message = "Do You want to unselected the article from the list";
           if(MessageBox.Show(message,"Confirmation Messag",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Article article = new Article();
                article = new ArticlesBLO(db).GetByID(Convert.ToInt32(Articles_dgv.CurrentRow.Cells[1].Value));
                ProviderOrderLine pol = new ProviderOrderLine();
                pol = new ProviderOrderLineBLO(db).GetPOLByArticle(article);
                new ProviderOrderLineBLO(db).Delete(pol);
                ArticlesList.Remove(article);
                Articles_c_listbx.DataSource = null;
                Articles_c_listbx.DataSource = ArticlesList;
            }

            }

        private void btn_result_Click(object sender, EventArgs e)
        {
            result_grpbx.Enabled = true;
            provider_tb.Text = provider.LastName + " " + provider.FirstName;
            articlescount_tb.Text = ArticlesList.Count().ToString();
            delivery_tb.Text = DeliveryDateExpected.ToShortDateString();

            float TotalPrice = 0;
            foreach (var item in ArticlesList)
            {
                ProviderOrderLine pol = new ProviderOrderLine();
                pol = new ProviderOrderLineBLO(db).GetPOLByArticle(item);
                float quantity = pol.Quantity;
                float ArticleBuyingPrice = item.BuyingPrice;
                float q_Art = quantity * ArticleBuyingPrice;
                TotalPrice = TotalPrice + q_Art;
            }
            total_tb.Text = TotalPrice.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            string message = "Another Operation ?";
            if (MessageBox.Show(message, "Confirmation Messag", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                result_grpbx.Enabled = false; 
                provider_tb.Text = "";
                articlescount_tb.Text = "";
                delivery_tb.Text = "";
                total_tb.Text = "";
                //Disabled the delivery date expected before choosing the operation s type
                Deliveryde_grpx.Enabled = false;
                //Filling the provider combobox with the provider s list
                provider_combo.DataSource = null;
                provider_combo.DataSource = new ProviderBLO(db).GetAll();
                //Disabled Articles Category listbox before pass
                Articles_Category_grpbx.Enabled = false;
                //Filling the articles Category listbox
                Articles_c_listbx.DataSource = null;
                Articles_c_listbx.DataSource = new ArticlesCategoryBLO(db).GetAll();
                //
                Articles_dgv.Enabled = false;
                Articles_c_listbx.Enabled = false;
                Articles_dgv.DataSource = null;
                Articles_dgv.DataSource = new ArticlesBLO(db).GetAll();
                Reference_textbox.Enabled = false;
                Articles_dgv.AutoGenerateColumns = false;

                result_grpbx.Enabled = false;
            }
    }
    }
}
