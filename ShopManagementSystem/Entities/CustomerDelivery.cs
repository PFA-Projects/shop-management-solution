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
    [GwinEntity(Localizable = true, DisplayMember = "DeliveryDate")]
    [Menu]
    public class CustomerDelivery:BaseEntity
    {
        [DisplayProperty(Titre = "DeliveryDate")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public DateTime DeliveryDate { get; set; }

        //Initiaiser Datetime
        public CustomerDelivery()
        {
            DeliveryDate = DateTime.Now;
        }
    }
}
