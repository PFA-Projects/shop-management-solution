//Mariam Ait Al
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

namespace ShopManagement.Forms.Statistic
{
    public partial class FormStatisticNotifications : Form
    {
        // Model Context Instance
        ModelContext db = new ModelContext();
        public FormStatisticNotifications()
        {
            InitializeComponent();
        }

        private void FormStatisticNotifications_Load(object sender, EventArgs e)
        {

            // disabled some parts before defining the start date and the end date values
            buy_grpbx.Enabled = false;
            sell_grpx.Enabled = false;
            exp_grpx.Enabled = false;
            result_grpx.Enabled = false;

        }
        // Define the start date and the end date values
        DateTime StartDate = DateTime.Now;
        DateTime EndDate = DateTime.Now;
        private void endadte_dtp_ValueChanged(object sender, EventArgs e)
        {
            // start date && end date confirming
            // Get the Articles list in buy order state  + the count + total price
            // Get the Articles list in sell order state + the count + total price
            // Get the expenses list + the count + total price
            // 



            EndDate = endadte_dtp.Value;
            string Message = "vous etes d'accord ? \n\t Date Debut est : " + StartDate.Day + "-" + StartDate.Month + "-" + StartDate.Year + "\n\t  Date Fin est : "
                + EndDate.Day + "-" + EndDate.Month + "-" + EndDate.Year;
            if(MessageBox.Show(Message,"Confirmation Messag",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // enable the other parts result
                buy_grpbx.Enabled = true;
                buy_dgv.DataSource = null;
                buy_dgv.DataSource = new ProviderOrderLineBLO(db).GetPOLBySD_ED_OS(StartDate, EndDate);
                if(new ProviderOrderLineBLO(db).GetPOLBySD_ED_OS(StartDate, EndDate).Count > 0)
                {
                    buy_dgv.Columns[0].Visible = false;
                    buy_dgv.Columns[1].Visible = false;
                }
                //
                sell_grpx.Enabled = true;
                sell_dgv.DataSource = null;
                sell_dgv.DataSource = new CustomerOrderLineBLO(db).GetCOLBySD_ED(StartDate, EndDate);
                if(new CustomerOrderLineBLO(db).GetCOLBySD_ED(StartDate, EndDate).Count() > 0)
                {
                    sell_dgv.Columns[0].Visible = false;
                    sell_dgv.Columns[1].Visible = false;
                }
                //
                exp_grpx.Enabled = true;
                exp_dgv.DataSource = null;
                exp_dgv.DataSource = new ExpensesBLO(db).GetExpByStartDate_Ed(StartDate, EndDate);
                //Informations  count
                SAC_tb.Text = (new CustomerOrderLineBLO(db).GetCOLBySD_ED(StartDate, EndDate).Count()).ToString();
                BAC_tb.Text = (new ProviderOrderLineBLO(db).GetPOLBySD_ED_OS(StartDate, EndDate).Count).ToString();
                E_tb.Text = (new ExpensesBLO(db).GetExpByStartDate_Ed(StartDate, EndDate).Count).ToString();
                /// Information Prices
                // 1- Sell
                List<Article> ArticlesList = new List<Article>();
                ArticlesList = new CustomerOrderLineBLO(db).GetArticles_SD_ED(StartDate, EndDate);
                float PriceTotal = 0;
                foreach (var item in ArticlesList)
                {
                    PriceTotal = PriceTotal + item.SellingPrice;
                }
                SP_tb.Text = PriceTotal.ToString();
                // 2- Buy
                List<Article> BuyArticlesList = new List<Article>();
                BuyArticlesList = new ProviderOrderLineBLO(db).GetArticlesList_SD_Ed(StartDate, EndDate);
                float BPriceTotal = 0;
                foreach (var item in BuyArticlesList)
                {
                    BPriceTotal = BPriceTotal + item.BuyingPrice;
                }
                BP_tb.Text = BPriceTotal.ToString();
                //3-Expenses 
                List<Expense> ExpensesList = new List<Expense>();
                ExpensesList = new ExpensesBLO(db).GetExpBySD_ES(StartDate, EndDate);
                float EPriceTotal = 0;
                foreach (var item in ExpensesList)
                {
                    EPriceTotal = EPriceTotal + item.price;
                }
                EP_tb.Text = EPriceTotal.ToString();
                
            }
        }

        //
        private void startdate_dp_ValueChanged(object sender, EventArgs e)
        {
            StartDate = startdate_dp.Value;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
