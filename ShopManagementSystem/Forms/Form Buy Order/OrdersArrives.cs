//Mariam Ait Al

using App;
using ShopManagement.BLL;
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
    public partial class OrdersArrives : Form
    {
        //The modelContext Instance
        ModelContext db = new ModelContext();
        public OrdersArrives()
        {
            InitializeComponent();

            
        }

        private void OrdersArrives_Load(object sender, EventArgs e)
        {
            //Filling the providerCombo with the provider s list
            prov_combo.DataSource = null;
            prov_combo.DataSource = new ProviderBLO(db).GetAll();
        }
    }
}
