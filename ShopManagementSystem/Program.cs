using ShopManagement.Forms.Buy_Order__Historic;
using ShopManagement.Forms.Form_Buy_Order;
using ShopManagement.Forms.Form_Menu;
using ShopManagement.Forms.Sell_Order;
using ShopManagement.Forms.Statistic;
using System;
using System.Windows.Forms;

namespace GenericWinFormApplication
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenu());
        }
    }

    
}
