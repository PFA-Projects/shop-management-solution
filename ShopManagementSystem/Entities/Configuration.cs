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
        [DisplayProperty(Titre = "RiskOfStock")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public int RiskOfStock { get; set; }

        [DisplayProperty(Titre = "TVA")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public float TVA { get; set; }


        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm]
        [Filter]
        [DataGrid(WidthColonne = 100)]
        public Article article { get; set; }
    }
}
