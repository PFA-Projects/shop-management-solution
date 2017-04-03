﻿//Mariam Ait Al

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

namespace ShopManagement.Forms.Form_Buy_Order
{
    public partial class FormBuyOrder : Form
    {
        //
        ModelContext db = new ModelContext();
        public FormBuyOrder()
        {
            InitializeComponent();
        }

        private void FormBuyOrder_Load(object sender, EventArgs e)
        {
            //
            // Application User
            User user = new User();
            user.Language = GwinApp.Languages.en;

            // Start Gwin Application
            GwinApp.Start(typeof(ModelContext), typeof(BaseBLO<>), null, user);
            //
            OpType_combo.DataSource = null;
            OpType_combo.Items.Add("Buy");
            OpType_combo.Items.Add("Order");
            //
            prov_grpx.Enabled = false;
            //
            dde_grpx.Enabled = false;
            //
            Articles_dgv.Enabled = false;
            //
            Articles_dgv.AutoGenerateColumns = false;
            //
            result_grpbx.Enabled = false;
            btn_pass.Visible = false;
            //
            providerId_label.Enabled = false;
            pro_rdb.Enabled = false;
            //
            Articles_Category_lb.DataSource = null;
            Articles_Category_lb.Enabled = false;
            //
            s_grpbx.Enabled = false;
        }
        string OperationType = "";
        private void OpType_combo_SelectedValueChanged(object sender, EventArgs e)
        {
            OperationType = OpType_combo.SelectedItem.ToString();
            if (OperationType != null)
            {
                prov_grpx.Enabled = true;
                pro_combo.DataSource = null;
                pro_combo.DataSource = new ProviderBLO(db).GetAll();
                //
                pro_rdb.Enabled = true;
                id_pro_label.Enabled = true;
            }
            if (OperationType == "Order")
                dde_grpx.Enabled = true;
            else
                dde_grpx.Enabled = false;
        }
        //
        Provider provider = new Provider();
        private void pro_combo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ProviderType == "Object")
            {
                provider = (Provider)pro_combo.SelectedItem;
            }
        }
        //
        DateTime DeliveryDateExpected = DateTime.Now;
        private void dd_dtp_ValueChanged(object sender, EventArgs e)
        {
            DeliveryDateExpected = dd_dtp.Value;
        }
        //
        ProviderOrder po = new ProviderOrder();
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string message = "Are you sure about this informations  : \nProvider : "
                + provider.FirstName + " " + provider.LastName + "\n Operation Type : " + OperationType + " \nProvider Type : " + ProviderType
                + "\n Delivery Date Expected : " + DeliveryDateExpected; 
            if (MessageBox.Show(message, "Confirmation Messag", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                po.Name = OperationType + po.Id + "," + provider.LastName + " " + provider.FirstName;
                if (OperationType == "Buy")
                {
                    po.orderDate = DateTime.Now;
                }
                if (OperationType == "Order")
                {
                    po.DeliveryDateExpected = DeliveryDateExpected;
                }
                if (provider != null)
                {
                    po.provider = provider;
                }
                po.OrderState = OperationType;
                new ProviderOrderBLO(db).Save(po);
                OperationType_grpbx.Enabled = false;
                prov_grpx.Enabled = false;
                dde_grpx.Enabled = false;
                btn_confirm.Enabled = false;
                //
                Articles_dgv.Enabled = true;
                Articles_dgv.DataSource = null;
                Articles_dgv.DataSource = new ArticlesBLO(db).GetAll();
                //
                
                providerId_label.Enabled = false;
                pro_combo.Enabled = false;
                
                //
                Articles_Category_lb.Enabled = true;
                Articles_Category_lb.DataSource = new ArticlesCategoryBLO(db).GetAll();
                //
                s_grpbx.Enabled = true;
            }

        }
        
        
        //
        string ProviderType = "";
        private void pro_rdb_CheckedChanged(object sender, EventArgs e)
        {
            ProviderType = "Object";
            providerId_label.Text = "";
            pro_combo.Enabled = true;
            pro_combo.DataSource = null;
            pro_combo.DataSource = new ProviderBLO(db).GetAll();
        }
        //
        private void id_pro_label_CheckedChanged(object sender, EventArgs e)
        {
            ProviderType = "Id";
            pro_combo.DataSource = null;
            pro_combo.Enabled = false;
            providerId_label.Text = (new ProviderOrderLineBLO(db).Count() + 1).ToString();
        }
        //
        private void Articles_Category_lb_Click(object sender, EventArgs e)
        {
            Articles_dgv.DataSource = null;
            Articles_dgv.DataSource = new ArticlesBLO(db).SearchByCateory((ArticleCategory)Articles_Category_lb.SelectedItem);
        }
        //
        List<Article> ArticlesList = new List<Article>();
        private void Articles_dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //We make DataGridCheckBoxColumn commit changes with single click
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                this.Articles_dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            if ((bool)this.Articles_dgv.CurrentCell.Value == true)
            {
                if(Articles_dgv.CurrentRow.Cells[2].Value == null)
                {
                    MessageBox.Show("You should fill the article s required quantity before ");
                    Articles_dgv.DataSource = null;
                    Articles_dgv.DataSource = new ArticlesBLO(db).GetAll();
                }
                else
                {
                    //
                    string qte = Articles_dgv.CurrentRow.Cells[2].Value.ToString();
                    float RequieredQuantity = float.Parse(qte);
                    //
                    ProviderOrderLine pol = new ProviderOrderLine();
                    pol.Quantity = RequieredQuantity;
                    pol.providerOrder = po;
                    pol.article = new ArticlesBLO(db).GetByID(Convert.ToInt32(Articles_dgv.CurrentRow.Cells[1].Value));
                    new ProviderOrderLineBLO(db).Save(pol);
                    //
                    if(po.OrderState == "Buy")
                    {
                        Article article = new ArticlesBLO(db).GetByID(Convert.ToInt32(Articles_dgv.CurrentRow.Cells[1].Value));
                        MessageBox.Show("Quantity Before : " + article.Quantity);
                        article.Quantity = article.Quantity + RequieredQuantity;
                        MessageBox.Show("Quantity after : " + article.Quantity);
                        new ArticlesBLO(db).Save(article);
                    }
                    
                }
            }
        }
    }
       
       
    }


