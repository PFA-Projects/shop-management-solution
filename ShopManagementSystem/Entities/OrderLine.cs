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
    [GwinEntity(Localizable = true, DisplayMember = "Quantity")]
    [Menu]
    public class OrderLine:BaseEntity
    {
        [DisplayProperty(Titre = "Quantity")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public int Quantity { get; set; }

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm]
        [Filter]
        [DataGrid(WidthColonne = 100)]
        public Article article { get; set; }


        //[Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        //[EntryForm]
        //[Filter]
        //[DataGrid(WidthColonne = 100)]
        //public Order order { get; set; }
    }
}
