using ShopManagement.Presentation.Buy_Order__Historic;
using ShopManagement.Presentation.Form_Buy_Order;
using ShopManagement.Presentation.Form_Menu;
using ShopManagement.Presentation.Sell_Order;
using ShopManagement.Presentation.Statistic;
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
