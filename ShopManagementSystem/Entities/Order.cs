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

    [GwinEntity(Localizable = true, DisplayMember = "OrderName")]
    [Menu]
    public class Order:BaseEntity
    {
        [DisplayProperty(Titre = "OrderName")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public string OrderName { get; set; }

        [DisplayProperty(Titre = "orderDate")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public DateTime orderDate { get; set; }

        [DisplayProperty(Titre = "DeliveryDateExpected")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public DateTime DeliveryDateExpected { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm]
        [Filter]
        [DataGrid(WidthColonne = 100)]
        public Provider provider { get; set; }

       
    }
}
