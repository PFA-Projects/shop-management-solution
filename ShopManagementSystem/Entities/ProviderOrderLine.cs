// Nom : Mariam Ait al
// Groupe : TDI204
//Annee : 2017
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
     /// ligne commande fournisseur
     /// </summary>
    [GwinEntity(Localizable = true, DisplayMember = "Quantity")]
    [Menu(Group = "Buy")]
    public class ProviderOrderLine:BaseEntity
    {
        [DisplayProperty(Titre = "Quantity")]
        [EntryForm]
        [DataGrid]
        [Filter]
        public float Quantity { get; set; }
        
    
        public ProviderOrder providerOrder { get; set; }
        //[Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        //[EntryForm]
        //[Filter]
        //[DataGrid(WidthColonne = 100)]
        //public Order order { get; set; }


        public Article article { get; set; }
    }
}
