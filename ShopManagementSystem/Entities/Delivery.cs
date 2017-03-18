using App.Gwin.Attributes;
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Entities
{
    /// <summary>
    /// Mariam Ait al
    /// </summary>
    /// 

    [GwinEntity(Localizable = true, DisplayMember = "DeliveryName")]
    [Menu]
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
        public string DeliveryDate { get; set; }
    }
}
