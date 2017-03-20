//Mariam Ait al

using App.Gwin.Attributes;
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Entities
{
    

    [GwinEntity(Localizable = true, DisplayMember = "DeliveryName")]
    [Menu(Group = "Buy")]
    public class Delivery:BaseEntity
    {
        [DisplayProperty(Titre = "DeliveryName")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string DeliveryName { get; set; }

        [DisplayProperty(Titre = "DeliveryDate")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public DateTime DeliveryDate { get; set; }

        
        //Iniitialiser DateTime
        public Delivery()
        {
            this.DeliveryDate = DateTime.Now;
        }
    }
}
