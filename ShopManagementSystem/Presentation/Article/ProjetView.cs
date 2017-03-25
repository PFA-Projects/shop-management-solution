using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShopManagement.Presentation.Article
{
    public partial class ProjetView : App.Gwin.BaseEntryForm
    {
        public ProjetView()
        {
          
            InitializeComponent();
            this.panel_article.Dock = DockStyle.Fill;
           
        }
    }
}
