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
    
    public partial class FormCustomerLivraison : Form
    {
        //ModelContext Instantiate
        ModelContext db = new ModelContext();

        public FormCustomerLivraison()
        {
            InitializeComponent();
        }
        //
        private void FormCustomerLivraison_Load(object sender, EventArgs e)
        {
            //
            //Filling the combo with (Oredr || Sell) => 2 Sell Operations (OrderState : CustomerOrder class)
            //
            optype_combo.DataSource = null;
            optype_combo.Items.Add("Order");
            optype_combo.Items.Add("Sell");
        }

        // 
        private void col_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Delete (order) selected in datagridview
            if(e.ColumnIndex == 0)
            {
                string Message = "do you really want to delete this Order ?";
                if(MessageBox.Show(Message,"Confirmation Messag", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new CustomerOrderLineBLO(db).Delete(Convert.ToInt32(col_dgv.CurrentRow.Cells[2].Value.ToString()));
                    MessageBox.Show("Deleted !!");
                    col_dgv.DataSource = null;
                    col_dgv.DataSource = new CustomerOrderLineBLO(db).GetCOlByOpType("Order");
                    if(new CustomerOrderLineBLO(db).GetCOlByOpType("Order").Count() > 0)
                    {
                        // Hide 2 values : ProviderOrderLine_id , ProviderOrder_id 
                        col_dgv.Columns[2].Visible = false;
                        col_dgv.Columns[3].Visible = false;
                    }                 
                }
            }

            //Update (order) selected in datagridview and save changes in the stock 
            if(e.ColumnIndex == 1)
            {
                string Message = "Are u want To change it from Order To Sell ?";
                if (MessageBox.Show(Message, "Confirmation Messag", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CustomerOrderLine col = new CustomerOrderLine();
                    col = new CustomerOrderLineBLO(db).GetByID(Convert.ToInt32(col_dgv.CurrentRow.Cells[2].Value.ToString()));
                   
                    CustomerOrder co = new CustomerOrder();
                    co = new CustomerOrdersBLO(db).GetByID(Convert.ToInt32(col_dgv.CurrentRow.Cells[3].Value.ToString()));
                    co.OrderState = "Sell";
                    co.OrderDate = DateTime.Now;
                    new CustomerOrdersBLO(db).Save(co);
                    Article article = new Article();
                    article = new ArticlesBLO(db).SearchByReference(col_dgv.CurrentRow.Cells[4].Value.ToString())[0];
                    MessageBox.Show("Quantity Article Before : " + article.Quantity);
                    article.Quantity = article.Quantity - col.Quantity;
                    MessageBox.Show("Quantity Article After : " + article.Quantity);
                    col_dgv.DataSource = null;
                    col_dgv.DataSource = new CustomerOrderLineBLO(db).GetCOlByOpType(optype_combo.SelectedItem.ToString());
                }
            }
        }
        // Define the Operation Type selected in the combo and fill the datagridview
        // with the Operation type s items
        private void optype_combo_SelectedValueChanged(object sender, EventArgs e)
        {
            // Case Operation Type = "Order"
            if(optype_combo.SelectedItem.ToString() == "Order")
            {
                if(new CustomerOrderLineBLO(db).GetCOlByOpType("Order").Count > 0)
                {
                    col_dgv.DataSource = null;
                    // Add 2 datagridviewBouttons in order operation type case
                    // 1 - Delete : Allows to delete the current item selected with the delte boutton
                    // 2 -Update : Allows to update the current item selected and save the changes
                    DataGridViewButtonColumn dgvbc1 = new DataGridViewButtonColumn();
                    dgvbc1.Name = "Delete";
                    dgvbc1.Text = "";

                    int columnIndex = 0;
                    if (col_dgv.Columns["uninstall_column"] == null)
                    {
                        col_dgv.Columns.Insert(columnIndex, dgvbc1);

                        //
                        DataGridViewButtonColumn c = (DataGridViewButtonColumn)col_dgv.Columns["Delete"];
                        //c.FlatStyle = FlatStyle.Popup;
                        c.DefaultCellStyle.ForeColor = Color.Red;
                        c.DefaultCellStyle.BackColor = Color.Red;
                    }

                    DataGridViewButtonColumn dgvbc2 = new DataGridViewButtonColumn();
                    dgvbc2.Name = "Update";
                    dgvbc2.Text = "";

                    int columnIndex2 = 1;
                    if (col_dgv.Columns["uninstall_column2"] == null)
                    {
                        col_dgv.Columns.Insert(columnIndex2, dgvbc2);

                        //
                        DataGridViewButtonColumn c2 = (DataGridViewButtonColumn)col_dgv.Columns["Update"];
                        //c.FlatStyle = FlatStyle.Popup;
                        c2.DefaultCellStyle.ForeColor = Color.Green;
                        c2.DefaultCellStyle.BackColor = Color.Green;
                    }

                    col_dgv.DataSource = new CustomerOrderLineBLO(db).GetCOlByOpType("Order");
                    col_dgv.Columns[2].Visible = false;
                    col_dgv.Columns[3].Visible = false;
                }
                // inform user if there s no item in the db with the Operation Type selected
                else
                {
                    MessageBox.Show("There is no item to get !");
                }
            }
            //Case : operation Type = "sell"
            if (optype_combo.SelectedItem.ToString() == "Sell")
            {
                col_dgv.DataSource = null;
                if (new CustomerOrderLineBLO(db).GetCOlByOpType("Sell").Count > 0)
                {
                    col_dgv.DataSource = new CustomerOrderLineBLO(db).GetCOlByOpType("Sell");
                    col_dgv.Columns[0].Visible = false;
                    col_dgv.Columns[1].Visible = false;
                }
                else
                {
                    MessageBox.Show("There is no item to get !");
                }
            }
        }

        
    }
}
