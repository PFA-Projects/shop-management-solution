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

namespace ShopManagement.Forms.Buy_Order__Historic
{
    public partial class FormLivraison : Form
    {
        // ModelContext instance
        ModelContext db = new ModelContext();
        public FormLivraison()
        {
            InitializeComponent();
        }
        // define the combo selected value = Article  order state (Order || Buy)
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            // when the artcile order state is = Order
            if (comboBox1.SelectedItem.ToString() == "Order")
            {
                Operations_dgv.DataSource = null;
                // in this case we test about the count 
                if (new ProviderOrderLineBLO(db).GetPOlByOpType("Order").Count > 0)
                {
                    // add 2 boutons (delete | Update )
                    // Delete : Allows to delete the ProviderOrderLine selected 
                    //Update : Allows to change the aticle order state selected from Order to buy
                    //////
                    DataGridViewButtonColumn dgvbc1 = new DataGridViewButtonColumn();
                    dgvbc1.Name = "Delete";
                    dgvbc1.Text = "";
                    //
                    int columnIndex = 0;
                    if (Operations_dgv.Columns["uninstall_column"] == null)
                    {
                        Operations_dgv.Columns.Insert(columnIndex, dgvbc1);

                        //
                        DataGridViewButtonColumn c = (DataGridViewButtonColumn)Operations_dgv.Columns["Delete"];
                        //c.FlatStyle = FlatStyle.Popup;
                        c.DefaultCellStyle.ForeColor = Color.Red;
                        c.DefaultCellStyle.BackColor = Color.Red;
                    }

                    ////
                    DataGridViewButtonColumn dgvbc2 = new DataGridViewButtonColumn();
                    dgvbc2.Name = "Update";
                    dgvbc2.Text = "";
                    //
                    int columnIndex2 = 1;
                    if (Operations_dgv.Columns["uninstall_column2"] == null)
                    {
                        Operations_dgv.Columns.Insert(columnIndex2, dgvbc2);

                        //
                        DataGridViewButtonColumn c2 = (DataGridViewButtonColumn)Operations_dgv.Columns["Update"];
                        //c.FlatStyle = FlatStyle.Popup;
                        c2.DefaultCellStyle.ForeColor = Color.Green;
                        c2.DefaultCellStyle.BackColor = Color.Green;
                    }

                    Operations_dgv.DataSource = new ProviderOrderLineBLO(db).GetPOlByOpType("Order");
                    //
                    Operations_dgv.Columns[2].Visible = false;
                    Operations_dgv.Columns[3].Visible = false;
                }
                // in case of the search doesn t have no item to get 
                // we inform the user about the situation
                else
                {
                    MessageBox.Show("There s no item to get !");
                }
            }
            // when the item combo selected is buy
            // we get all the providers order line with the provider order state is Buy
            if (comboBox1.SelectedItem.ToString() == "Buy")
            {
                Operations_dgv.DataSource = null;
                if (new ProviderOrderLineBLO(db).GetPOlByOpType("Buy").Count > 0)
                {
                    Operations_dgv.DataSource = new ProviderOrderLineBLO(db).GetPOlByOpType("Buy");
                    Operations_dgv.Columns[0].Visible = false;
                    Operations_dgv.Columns[1].Visible = false;
                }
                // in another case that there s no item in the provider order state buy 
                //  we inform user
                else
                {
                    MessageBox.Show("There s no item to get !");
                }
            }
        }
        //
        private void FormHistoric_Load(object sender, EventArgs e)
        {
            // add 2 items ( Provider Order state (Order|| Buy) ) to the combo
            comboBox1.DataSource = null;
            comboBox1.Items.Add("Buy");
            comboBox1.Items.Add("Order");
        }

        // case delete || update in provider order state = Order
        private void Operations_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            
            if (comboBox1.SelectedItem.ToString() == "Order")
            {
                // case of dalete
                if (e.ColumnIndex == 0)
                {
                    // user confirm about the delete operation
                    string messag = "Do You really sure about the delete operation ?";
                    if(MessageBox.Show(messag,"Confirmation Messag",MessageBoxButtons.YesNo)== DialogResult.Yes)
                    {
                        new ProviderOrderLineBLO(db).Delete(Convert.ToInt32(Operations_dgv.CurrentRow.Cells[2].Value.ToString()));
                        MessageBox.Show("Deleted !!");
                        // referesh the datagridview after delliting the  item selected
                        Operations_dgv.DataSource = null;
                        Operations_dgv.DataSource = new ProviderOrderLineBLO(db).GetPOlByOpType(comboBox1.SelectedItem.ToString());
                        Operations_dgv.Columns[2].Visible = false;
                        Operations_dgv.Columns[3].Visible = false;
                    }
                }
                // Update s case
                if(e.ColumnIndex == 1)
                {
                    // user s confirm about the operation
                    string messsage = "This Order is already here ?";
                    if(MessageBox.Show(messsage,"Confirmation Messag",MessageBoxButtons.YesNo)== DialogResult.Yes)
                    { 
                        ProviderOrderLine pol = new ProviderOrderLine();
                        pol = new ProviderOrderLineBLO(db).GetByID(Convert.ToInt32(Operations_dgv.CurrentRow.Cells[2].Value.ToString()));
                        //MessageBox.Show(pol.Id.ToString());
                        ProviderOrder po = new ProviderOrder();
                        // change the order  state selected form order to buy
                        po = new ProviderOrderBLO(db).GetByID(Convert.ToInt32(Operations_dgv.CurrentRow.Cells[3].Value.ToString()));
                        po.OrderState = "Buy";
                        po.orderDate = DateTime.Now;
                        new ProviderOrderBLO(db).Save(po);
                        Article article = new Article();
                        article = new ArticlesBLO(db).SearchByReference(Operations_dgv.CurrentRow.Cells[4].Value.ToString())[0];
                        MessageBox.Show("Count Article Before  " + article.Quantity);
                        // add the quantity selected to the article in stock
                        article.Quantity = article.Quantity + pol.Quantity;
                        MessageBox.Show("Count Article After : " + article.Quantity);
                        // refresh the  articles datagridview after this operation
                        Operations_dgv.DataSource = null;
                        Operations_dgv.DataSource = new ProviderOrderLineBLO(db).GetPOlByOpType(comboBox1.SelectedItem.ToString());
                    }
                }
            }
        }
    }
}
