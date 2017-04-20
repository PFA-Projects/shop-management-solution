//Mariam Ait Al

using App.Gwin.Attributes;
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Entities
{
    [GwinEntity(Localizable = true, DisplayMember = "Reference")]
    [Menu]
    public class configuration:BaseEntity
    {
        

        [DisplayProperty(Titre = "TVA")]
        [EntryForm]
        [DataGrid]
        
        public float TVA { get; set; }

        [DisplayProperty(Titre = "RiskOfStock")]
        [EntryForm]
        [DataGrid]
       
        public int RiskOfStock { get; set; }

        public configuration()
        {
            TVA = 20 ;
            RiskOfStock = 10;
        }

    }
}
